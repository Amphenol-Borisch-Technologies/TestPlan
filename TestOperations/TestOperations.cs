namespace ABT.Test.TestPlans.Diagnostics.TestOperations.SCPI_VISA_Instruments {
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using ABT.Test.TestLib;
    using ABT.Test.TestLib.InstrumentDrivers.Interfaces;
    using ABT.Test.TestLib.InstrumentDrivers.Multifunction;
    using ABT.Test.TestLib.InstrumentDrivers.MultiMeters;
    using ABT.Test.TestLib.InstrumentDrivers.Oscilloscopes;
    using ABT.Test.TestLib.InstrumentDrivers.PowerSupplies;
    using ABT.Test.TestLib.TestConfiguration;
    using static ABT.Test.TestLib.Data;
    using static ABT.Test.TestLib.TestConfiguration.Assertions;

    internal class TestMethods {
        public static Dictionary<String, Object> InstrumentDriversSystem = GetInstrumentDriversSystemDefinition();

        static String MM_34401A() {
            if (testSequence.IsOperation) Debug.Assert(TestOperation(NamespaceTrunk: "SCPI_VISA_Instruments", Description: "Diagnostics of instruments exclusively defined in configuration file SystemDefinition.xml.", TestGroups: "TestMethods"));
            Debug.Assert(TestGroupPrior(Classname: NONE));
            Debug.Assert(TestGroup(Classname: "TestMethods", Description: "Comprised of manufacturer provided instrument self-tests + optional ABT diagnostics.", CancelNotPassed: "false", Independent: "true", Methods: "MM_34401A|MSO_3014|PS_E3634A|PS_E3649A|MSMU_34980A"));
            Debug.Assert(TestGroupNext(Classname: NONE));
            Debug.Assert(MethodPrior(Name: NONE));
            Debug.Assert(MethodCustom(Name: "MM_34401A", Description: "Keysight 34401A Digital Multi-Meters.", CancelNotPassed: "false"));
            Debug.Assert(MethodNext(Name: "MSO_3014"));

            TestIndices.Method.Event = DiagnosticsT<MM_34401A_SCPI_NET>();
            return TestIndices.Method.LogFetchAndClear();
        }

        static String MSO_3014() {
            Debug.Assert(MethodPrior(Name: "MM_34401A"));
            Debug.Assert(MethodCustom(Name: "MSO_3014", Description: "Tektronix MSO-3014 Mixed-Signal Oscilloscopes.", CancelNotPassed: "false"));
            Debug.Assert(MethodNext(Name: "PS_E3634A"));

            TestIndices.Method.Event =  DiagnosticsT<MSO_3014_IVI_COM>();
            return TestIndices.Method.LogFetchAndClear();
        }

        static String PS_E3634A() {
            Debug.Assert(MethodPrior(Name: "MSO_3014"));
            Debug.Assert(MethodCustom(Name: "PS_E3634A", Description: "Keysight E3634A Power Supplies.", CancelNotPassed: "false"));
            Debug.Assert(MethodNext(Name: "PS_E3649A"));

            TestIndices.Method.Event =  DiagnosticsT<PS_E3634A_SCPI_NET>();
            return TestIndices.Method.LogFetchAndClear();
        }

        static String PS_E3649A() {
            Debug.Assert(MethodPrior(Name: "PS_E3634A"));
            Debug.Assert(MethodCustom(Name: "PS_E3649A", Description: "Keysight E3649A Power Supplies.", CancelNotPassed: "false"));
            Debug.Assert(MethodNext(Name: "MSMU_34980A"));

            TestIndices.Method.Event =  DiagnosticsT<PS_E3649A_SCPI_NET>();
            return TestIndices.Method.LogFetchAndClear();
        }

        static String MSMU_34980A() {
            Debug.Assert(MethodPrior(Name: "PS_E3649A"));
            Debug.Assert(MethodCustom(Name: "MSMU_34980A", Description: "Keysight 34980A Multifunction Switch/Measurement Units.", CancelNotPassed: "false"));
            Debug.Assert(MethodNext(Name: NONE));

            TestIndices.Method.Event =  DiagnosticsT<MSMU_34980A_SCPI_NET>();
            return TestIndices.Method.LogFetchAndClear();
        }

        private static EVENTS DiagnosticsT<T>() where T : IDiagnostics {
            Dictionary<String, T> instrumentDriversT = InstrumentDriversSystem.Where(kvp => kvp.Value is T).ToDictionary(kvp => kvp.Key, kvp => (T)kvp.Value);
            if (instrumentDriversT.Count() == 0) {
                TestIndices.Method.Log.AppendLine($"No instruments of type '{typeof(T).Name}' defined in '{SystemDefinitionXML}'.");
                return EVENTS.INFORMATION;
            }

            (Boolean Summary, List<DiagnosticsResult> Details) resultDiagnostics;
            Boolean passedCollective = true;
            foreach (KeyValuePair<String, T> kvp in instrumentDriversT) {
                resultDiagnostics = kvp.Value.Diagnostics();
                passedCollective &= resultDiagnostics.Summary;
                TestIndices.Method.Log.AppendLine($"ID '{kvp.Key}', Driver '{typeof(T).Name}', Result '{(resultDiagnostics.Summary ? EVENTS.PASS.ToString() : EVENTS.FAIL.ToString())}'.");
                foreach (DiagnosticsResult dr in resultDiagnostics.Details) TestIndices.Method.Log.AppendLine($"{dr.Label}{dr.Message}, Result '{dr.Event}'.");
            }
            return passedCollective ? EVENTS.PASS : EVENTS.FAIL;
        }
    }
}

namespace ABT.Test.TestPlans.Diagnostics.TestOperations.Miscellaneous {
    using System;
    using System.Diagnostics;
    using ABT.Test.TestLib;
    using ABT.Test.TestLib.TestConfiguration;
    using static ABT.Test.TestLib.Data;
    using static ABT.Test.TestLib.TestConfiguration.Assertions;


    internal class MoreMethods {

        internal static String MoreMM_34401A() {
            if (testSequence.IsOperation) Debug.Assert(TestOperation(NamespaceTrunk: "Miscellaneous", Description: "Miscellaneous items, including instruments that aren\'t both SCPI & VISA instruments.", TestGroups: "MoreMethods"));
            Debug.Assert(TestGroupPrior(Classname: NONE));
            Debug.Assert(TestGroup(Classname: "MoreMethods", Description: "Diagnostics.", CancelNotPassed: "false", Independent: "true", Methods: "MoreMM_34401A|MoreMSO_3014|MorePS_E3634A|MorePS_E3649A|MoreMSMU_34980A"));
            Debug.Assert(TestGroupNext(Classname: NONE));
            Debug.Assert(MethodPrior(Name: NONE));
            Debug.Assert(MethodProcess(Name: "MoreMM_34401A", Description: "Keysight 34401A Digital Multi-Meters.", CancelNotPassed: "false", Folder: "C:\\Test", File: "Temp.exe", Parameters: "", Expected: "0"));
            Debug.Assert(MethodNext(Name: "MoreMSO_3014"));

            return "-1";
        }

        internal static String MoreMSO_3014() {
            Debug.Assert(MethodPrior(Name: "MoreMM_34401A"));
            Debug.Assert(MethodTextual(Name: "MoreMSO_3014", Description: "Tektronix MSO-3014 Mixed-Signal Oscilloscopes.", CancelNotPassed: "false", Text: "Hi There!"));
            Debug.Assert(MethodNext(Name: "MorePS_E3634A"));

            return "";
        }

        internal static String MorePS_E3634A() {
            Debug.Assert(MethodPrior(Name: "MoreMSO_3014"));
            Debug.Assert(MethodCustom(Name: "MorePS_E3634A", Description: "Keysight E3634A Power Supplies.", CancelNotPassed: "false"));
            Debug.Assert(MethodNext(Name: "MorePS_E3649A"));

            TestIndices.Method.Event = EVENTS.PASS;
            return nameof(MorePS_E3634A);
        }

        internal static String MorePS_E3649A() {
            Debug.Assert(MethodPrior(Name: "MorePS_E3634A"));
            Debug.Assert(MethodCustom(Name: "MorePS_E3649A", Description: "Keysight E3649A Power Supplies.", CancelNotPassed: "false", Parameters: "Key1=Value1|Key2=Value2|Key3=Value3"));
            Debug.Assert(MethodNext(Name: "MoreMSMU_34980A"));

            TestIndices.Method.Event = EVENTS.PASS;
            return nameof(MorePS_E3649A);
        }

        internal static String MoreMSMU_34980A() {
            Debug.Assert(MethodPrior(Name: "MorePS_E3649A"));
            Debug.Assert(MethodInterval(Name: "MoreMSMU_34980A", Description: "Keysight 34980A Multifunction Switch/Measurement Units.", CancelNotPassed: "false", LowComparator: "GToE", Low: "5", High: "10", HighComparator: "LT", FractionalDigits: "2", UnitPrefix: "NONE", Units: "NONE", UnitSuffix: "NONE"));
            Debug.Assert(MethodNext(Name: NONE));

            return "NaN";
        }
    }
}
