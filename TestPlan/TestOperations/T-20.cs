using System;
using System.Diagnostics;
using System.Threading;
using ABT.Test.Exec;
using ABT.Test.Exec.AppConfig;
using ABT.Test.UUT.Instruments;

namespace ABT.Test.UUT.TestOperations {
    internal static partial class TestMeasurements {
        // NOTE:  Invocable test methods in this class, defined as TestMeasurement IDs in App.config, require signatures like "internal static String MethodName()".
        #region GroupID Programming
        internal static String TM_00_00() {
            if (TestPlan.Only.ConfigTest.IsOperation) {
                Debug.Assert(
                    TestPlan.Only.IsOperation(
                    OperationID: "T-20",
                    Description: "FilePro T-20 Programming.",
                    Revision: "1.0",
                    GroupsIDs: "Programming|4.2|4.4.1|4.4.2|4.5|4.6|4.7|4.8|4.9|4.10"));
            }
            Debug.Assert(TestPlan.Only.IsGroup(
                GroupID: "Programming",
                Description: "Programming.",
                MeasurementIDs: "TM_00_00",
                Selectable: true,
                CancelNotPassed: true));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: TestExec.NONE,
                IDNext: "TM_01_00",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Thread.Sleep(5000);
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }
        #endregion GroupID Programming
    }
}
