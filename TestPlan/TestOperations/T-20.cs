using System;
using System.Diagnostics;
using System.Threading;
using ABT.Test.Exec;
using ABT.Test.Exec.AppConfig;

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
                    GroupsIDs: "Programming"));
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
                IDNext: TestExec.NONE,
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }
        #endregion GroupID Programming
    }
}
