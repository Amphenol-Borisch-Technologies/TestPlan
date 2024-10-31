using System;
using System.Diagnostics;
using System.Windows.Forms;
using ABT.TestExec.Lib;
using ABT.TestExec.Lib.AppConfig;
using ABT.TestExec.Lib.InstrumentDrivers;
using ABT.TestExec.Lib.InstrumentDrivers.Interfaces;
using ABT.TestExec.Tests.UUT.InstrumentsDrivers;

namespace ABT.TestExec.Tests.UUT.TestOperations {
    internal static partial class TestMeasurements {
        // NOTE:  Invocable test methods in this class, defined as TestMeasurement IDs in App.config, require signatures like "internal static String MethodName()".
        #region GroupID Programming
        internal static String TM_00_00() {
            if (TestLib.ConfigTest.IsOperation) {
                Debug.Assert(
                    TestLib.IsOperation(
                    OperationID: "T-20",
                    Description: "FilePro T-20 Programming.",
                    Revision: "1.0",
                    GroupsIDs: "Programming"));
            }
            Debug.Assert(TestLib.IsGroup(
                GroupID: "Programming",
                Description: "Programming.",
                MeasurementIDs: "TM_00_00",
                Selectable: true,
                CancelNotPassed: true));
            Debug.Assert(TestLib.IsMeasurement(
                Description: "Description.",
                IDPrior: TestLib.NONE,
                IDNext: TestLib.NONE,
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));

            ID.V28_IN.Set(Volts: 3.3, Amps: 0.1, OVP: 7, STATES.ON);
            ID.SEAL.Set(OUTPUTS2.OUTput1, Volts: 1, Amps: 0.1, OVP: 7, STATES.ON);
            ID.SEAL.Set(OUTPUTS2.OUTput2, Volts: 2, Amps: 0.1, OVP: 7, STATES.ON);
            _ = MessageBox.Show($"Waiting...", "zzzzzzz", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return EVENTS.PASS.ToString();
        }
        #endregion GroupID Programming
    }
}
