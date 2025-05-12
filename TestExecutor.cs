using ABT.Test.TestExecutive.TestExec;
using ABT.Test.TestExecutive.TestLib;
using ABT.Test.TestExecutive.TestLib.Configuration;
using Microsoft.Win32;
using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

// NOTE:  Recommend using Microsoft's Visual Studio Code to develop/debug TestExec based closed source/proprietary projects:
//        - Visual Studio Code is a co$t free, open-source Integrated Development Environment entirely suitable for textual C# development, like Exec.
//          - That is, it's excellent for non-GUI C# development.
//          - VS Code is free for both private & commercial use:
//            - https://code.visualstudio.com/docs/supporting/FAQ
//            - https://code.visualstudio.com/license
// NOTE:  Recommend using Microsoft's Visual Studio Community Edition to develop/debug open sourced TestExec:
//        - https://github.com/Amphenol-Borisch-Technologies/TestExecutive/blob/master/LICENSE.txt
//        - "An unlimited number of users within an organization can use Visual Studio Community for the following scenarios:
//           in a classroom learning environment, for academic research, or for contributing to open source projects."
//        - Test based projects are very likely closed source/proprietary, which are disqualified from using VS Studio Community Edition.
//          - https://visualstudio.microsoft.com/vs/community/
//          - https://visualstudio.microsoft.com/license-terms/vs2022-ga-community/
// NOTE:  - VS Studio Community Edition is more preferable for GUI C# development than VS Code.
//          - If not developing GUI code, then VS Code is entirely sufficient & potentially preferable.
// TODO:  Eventually; refactor TestPlan to Microsoft's C# Coding Conventions, https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions.
// TODO:  Eventually; add documentation per https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/documentation-comments.
// NOTE:  For public methods, will deviate by using PascalCasing for parameters.  Will use recommended camelCasing for internal & private method parameters.
//        - Prefer named arguments for public methods be Capitalized/PascalCased, not uncapitalized/camelCased.
//        - Invoking public methods with named arguments is a superb, self-documenting coding technique, improved by PascalCasing.
// NOTE:  Liberal usage of Debug.Asserts, which improve code readability & quality and provide better documentation than comments, since they'll fail if they become outdated.
//        - https://stackoverflow.com/questions/129120/when-should-i-use-debug-assert
//        - https://softwareengineering.stackexchange.com/questions/87250/is-possible-to-write-too-many-asserts/307012#307012
//        - https://stackoverflow.com/questions/13856525/in-c-is-a-debug-assert-test-run-in-release-mode

/// <para>
///  References:
///  - https://github.com/Amphenol-Borisch-Technologies/TestExecutive
///  - https://github.com/Amphenol-Borisch-Technologies/TestPlan
///  </para>

/// <summary>
/// NOTE:  Test Developer is responsible for ensuring Methods can be both safely & correctly called in sequence defined in TestPlanDefinition.xml:
/// <para>
///        - That is, if Methods execute sequentially as (M1, M2, M3, M4, M5), Test Developer is responsible for ensuring all equipment is
///          configured safely & correctly between each Method's step.
///          - If:
///            - M1 is unpowered Shorts & Opens measurements.
///            - M2 is powered voltage measurements.
///            - M3 begins with unpowered operator cable connections/disconnections for In-System Programming.
///          - Then Test Developer must ensure necessary equipment state transitions are implemented so test operator isn't
///            plugging/unplugging a powered UUT in M3.
/// </para>
/// </summary>
/// 
/// <summary>
/// NOTE:  Two types of TestExec cancellations possible, each having two sub-types resulting in 4 altogether:
/// <para>
/// A) Spontaneous Operator Initiated Cancellations:
///      1)  Operator Proactive:
///          - Microsoft's recommended CancellationTokenSource technique, permitting Operator to proactively
///            cancel currently executing Methods.
///          - Requires Test project implementation by the Test Developer, but is initiated by Operator, so categorized as such.
///          - Implementation necessary if the *currently* executing Method must be cancellable during execution by the Operator.
///          - https://learn.microsoft.com/en-us/dotnet/standard/threading/cancellation-in-managed-threads
///          - https://learn.microsoft.com/en-us/dotnet/standard/parallel-programming/task-cancellation
///          - https://learn.microsoft.com/en-us/dotnet/standard/threading/canceling-threads-cooperatively
///      2)  Operator Reactive:
///          - TestExec's already implemented, always available & default reactive "Cancel before next Test" technique,
///            which simply invokes CT_Cancel.Cancel().
///          - If CT_Cancel.IsCancellationRequested, the TestExec.MethodsRun() foreach loop is broken, causing reactive cancellation
///            prior to the next Method's execution.
///          - Note: This doesn't proactively cancel the *currently* executing Method, which runs to completion.
/// B) PrePlanned Developer Programmed Cancellations:
///      3)  TestExec Developer initiated cancellations:
///          - Any Test project's Methods can initiate a cancellation programmatically by simply throwing an OperationCanceledException:
///          - Permits immediate cancellation if specific condition(s) occur in a Method; perhaps to prevent UUT or equipment damage,
///            or simply because futher execution is pointless.
///          - Simply throw an OperationCanceledException if the specific condition(s) occcur.
///      4)  TestPlanDefinition.xml's CancelNotPassed:
///          - TestPlanDefinition.xml's Method element has a Boolean "CancelNotPassed" field:
///          - If the current TestExec.MethodRun() has CancelNotPassed=true and it's resulting EvaluateEvent() doesn't return EVENTS.PASS,
///            TestExec.MethodRun() will break/exit, stopping further testing.
///		    - Do not pass Go, do not collect $200, go directly to TestExec.PostRun().
///
/// NOTE:  The Operator Proactive & TestExec Developer initiated cancellations both occur while the currently executing TestExec.MethodRun() conpletes, via 
///        thrown OperationCanceledExceptions.
/// NOTE:  The Operator Reactive & TestPlanDefinition.xml's CancelNotPassed cancellations both occur after the currently executing TestExec.MethodRun() completes, via checks
///        inside the TestExec.MethodsRun() loop.
/// </para>
/// </summary>
namespace ABT.Test.TestPlans.Diagnostics {
    internal static class Program {
        internal static Mutex MutexTestExecutor { get; private set; } = null;
        [STAThread]
        static void Main() {
            MutexTestExecutor = new Mutex(true, nameof(MutexTestExecutor), out Boolean onlyInstance);
            if (!onlyInstance) {
                _ = MessageBox.Show($"Already have one executing instance of {nameof(TestExec)}.{Environment.NewLine}{Environment.NewLine}" +
                    $"Cannot have two, as both would attempt to control system instruments simultaneously.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                return;
            }
            GC.KeepAlive(MutexTestExecutor);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try {
                Application.Run(TestExecutor.Only);
            } catch (Exception exception) {
                TestExec.StatusTimer?.Stop();
                TestLib.ErrorMessage(exception.ToString());
            }
        }
    }

    internal sealed class TestExecutor : TestExec {
        internal static TestExecutor Only { get; } = new TestExecutor();

        static TestExecutor() { }
        /// <summary>
        /// Singleton pattern requires explicit static constructor to tell C# compiler not to mark type as beforefieldinit.
        /// https://csharpindepth.com/articles/singleton
        /// <para>
        ///  - Utilized Singleton for TestExecutor class because there should only ever be 1 instance of TestExecutor.
        ///  - Also, TestExecutor being a Singleton eliminates needing to pass it's instance to all TestPlan methods, most which don't require it, which generates annoying compiler warnings.
        ///    - Realize both mayn't be optimal practices, and may refactor TestExecutor to a non-Singleton class, and resume explicitly passing TestExecutor object into methods.
        /// </para>
        /// </summary>
        private TestExecutor() : base(Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location), Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)) {
            // NOTE:  Create base constructor's Icon as applicable, depending on customer.
            // https://stackoverflow.com/questions/40933304/how-to-create-an-icon-for-visual-studio-with-just-mspaint-and-visual-studio
            WindowState = FormWindowState.Maximized;
            SystemEvents.SessionEnding += OnSessionEnding;
        }

        // NOTE: Class TestExecutor could be located in the TestExec project, but is placed in TestPlan projects so TestPlans can
        // conveniently override methods such as SystemReset(), IInstrumentsResetClear(), IPowerSuppliesOutputsOff() & IRelaysOpenAll().
        // This is necessary for TestPlans that utilize custom equipment or require special handling:
        // - Any non-SCPI equipment exclusively utilized by individual TestPlan's can be initialized/reset in their TestPlan projects.
        //   - Portable SCPI equipment that's not part of a system's TestExecDefinition.xml configuration is automatically handled by TestExec.
        //   - Stationary non-SCPI equipment that's permanently part of a test system should also be initialized/reset in TestExec, by modifying it's SystemReset() and other applicable methods.
        // - Only non-SCPI equipment that's portable and not a permanent part of a test system requires initialization/reset in TestPlan projects that utilize it.
        //public override void SystemReset() {
        //    if (TestLib.testPlanDefinition.TestSpace.Simulate) return;
        //    base.SystemReset();
        //    // Custom TestPlan specific System Reset code here.
        // }

        //public override void IInstrumentsResetClear() {
        //    if (TestLib.testPlanDefinition.TestSpace.Simulate) return;
        //    base.IInstrumentsResetClear();
        //    // Custom TestPlan specific Instrument Reset/Clear code here.
        // }

        //public override void IPowerSuppliesOutputsOff() {
        //    if (TestLib.testPlanDefinition.TestSpace.Simulate) return;
        //    base.IPowerSuppliesOutputsOff();
        //    // Custom TestPlan specific Power Supply Outputs Off code here.
        // }

        // public override void IRelaysOpenAll() {
        //     if (TestLib.testPlanDefinition.TestSpace.Simulate) return;
        //     base.IRelaysOpenAll();
        //     // Custom TestPlan specific Relay Open All code here.
        // }

        protected override void OnFormClosed(FormClosedEventArgs e) {
            base.OnFormClosed(e);
            SystemEvents.SessionEnding -= OnSessionEnding;
            Program.MutexTestExecutor?.ReleaseMutex();
            Program.MutexTestExecutor?.Dispose();
        }

        private void OnSessionEnding(Object sender, SessionEndingEventArgs e) { Application.Exit(); }

        protected override async Task<String> MethodRun(Method method) {
            Type type = Type.GetType($"{TestLib.testPlanDefinition.TestSpace.NamespaceRoot}.{TestIndices.TestOperation.NamespaceTrunk}.{TestIndices.TestGroup.Classname}");
            // NOTE:  Will only seek invocable methods in TestIndices.TestGroup.Classname that are defined as Method IDs in TestPlanDefinition.xml & and are part of a Group.
            MethodInfo methodInfo = type.GetMethod(method.Name, BindingFlags.Static | BindingFlags.NonPublic);
            // NOTE:  Invocable methods in TestIndices.TestGroup.Classname, defined as Method Names in TestPlanDefinition.xml, must have signatures identical to "internal static String MethodName()",
            Object task = await Task.Run(() => methodInfo.Invoke(null, null));
            return (String)task;
        }
    }
}
