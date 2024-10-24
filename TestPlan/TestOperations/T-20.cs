using System;
using System.Diagnostics;
using System.Windows.Forms;
using ABT.Test.Exec;
using ABT.Test.Exec.AppConfig;
using ABT.Test.Exec.InstrumentDrivers;
using ABT.Test.Exec.InstrumentDrivers.Interfaces;
using ABT.Test.Exec.InstrumentDrivers.Multifunction;
using ABT.Test.Exec.InstrumentDrivers.MultiMeters;
using ABT.Test.Exec.InstrumentDrivers.Oscilloscopes;
using ABT.Test.Exec.InstrumentDrivers.PowerSupplies;
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
            _ = ((MSO_3014_IVI_COM)TestPlan.Only.Instruments[IA.MSO]).Diagnostics();
            _ = ((PS_E3634A_SCPI_NET)TestPlan.Only.Instruments[IA.V28_IN]).Diagnostics();
            _ = ((PS_E3649A_SCPI_NET)TestPlan.Only.Instruments[IA.SEAL]).Diagnostics();
            _ = ((MM_34401A_SCPI_NET)TestPlan.Only.Instruments[IA.MM]).Diagnostics();
            _ = ((MSMU_34980A_SCPI_NET)TestPlan.Only.Instruments[IA.MSMU]).Diagnostics();

            ((PS_E3634A_SCPI_NET)TestPlan.Only.Instruments[IA.V28_IN]).Set(3.3, 0.1, 7, STATES.ON);
            ((PS_E3649A_SCPI_NET)TestPlan.Only.Instruments[IA.SEAL]).Set(OUTPUTS2.OUTput1, 1, 0.1, 7, STATES.ON);
            ((PS_E3649A_SCPI_NET)TestPlan.Only.Instruments[IA.SEAL]).Set(OUTPUTS2.OUTput2, 2, 0.1, 7, STATES.ON);
            _ = MessageBox.Show($"Waiting...", "zzzzzzz", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TestPlan.Only.MeasurementPresent.TestEvent = TestEvents.PASS;
            return String.Empty;
        }
        #endregion GroupID Programming
    }
}
