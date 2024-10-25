using System;
using System.Diagnostics;
using System.Windows.Forms;
using ABT.Test.Lib;
using ABT.Test.Lib.AppConfig;
using ABT.Test.Lib.InstrumentDrivers;
using ABT.Test.Lib.InstrumentDrivers.Interfaces;
using ABT.Test.Plan.UUT.Instruments;

namespace ABT.Test.Plan.UUT.TestOperations {
    internal static partial class TestMeasurements {
        // NOTE:  Invocable test methods in this class, defined as TestMeasurement IDs in App.config, require signatures like "internal static String MethodName()".
        #region GroupID Programming
        internal static String TM_00_00() {
            if (TestData.ConfigTest.IsOperation) {
                Debug.Assert(
                    TestData.IsOperation(
                    OperationID: "T-20",
                    Description: "FilePro T-20 Programming.",
                    Revision: "1.0",
                    GroupsIDs: "Programming"));
            }
            Debug.Assert(TestData.IsGroup(
                GroupID: "Programming",
                Description: "Programming.",
                MeasurementIDs: "TM_00_00",
                Selectable: true,
                CancelNotPassed: true));
            Debug.Assert(TestData.IsMeasurement(
                Description: "Description.",
                IDPrior: TestData.NONE,
                IDNext: TestData.NONE,
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));

            ID.V28_IN.Set(3.3, 0.1, 7, STATES.ON);
            ID.SEAL.Set(OUTPUTS2.OUTput1, 1, 0.1, 7, STATES.ON);
            ID.SEAL.Set(OUTPUTS2.OUTput2, 2, 0.1, 7, STATES.ON);
            _ = MessageBox.Show($"Waiting...", "zzzzzzz", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TestData.MeasurementPresent.TestEvent = TestEvents.PASS;
            return String.Empty;
        }
        #endregion GroupID Programming
    }
}
