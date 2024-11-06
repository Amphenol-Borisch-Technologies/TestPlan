using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Channels;
using System.Windows.Forms;
using ABT.TestExec.Exec;
using ABT.TestExec.Lib;
using ABT.TestExec.Lib.AppConfig;
using ABT.TestExec.Lib.InstrumentDrivers;
using ABT.TestExec.Lib.InstrumentDrivers.Interfaces;
using ABT.TestExec.Lib.InstrumentDrivers.MultiMeters;
using ABT.TestExec.Lib.InstrumentDrivers.PowerSupplies;
using ABT.TestExec.Tests.Diagnostics.InstrumentsDrivers;
using Windows.Foundation.Metadata;

namespace ABT.TestExec.Tests.Diagnostics.TestOperations {
    internal static partial class TestMeasurements {
        // NOTE:  Invocable test methods in this class, defined as TestMeasurement IDs in App.config, require signatures like "internal static String MethodName()".
        #region GroupID MM_34401A
        internal static String MM_34401A() {
            if (TestLib.ConfigTest.IsOperation) {
                Debug.Assert(
                    TestLib.IsOperation(
                    OperationID: "Diagnostics",
                    Description: "System Diagnostics.",
                    Revision: "0",
                    GroupsIDs: "MM_34401A|MSMU_34980A|MSO_3014|PS_E3634A|PS_E3649A"));
            }
            Debug.Assert(TestLib.IsGroup(
                GroupID: "MM_34401A",
                Description: "Keysight 34401A Diagnostics.",
                MeasurementIDs: "MM_34401A",
                Selectable: true,
                CancelNotPassed: false));
            Debug.Assert(TestLib.IsMeasurement(
                Description: "Keysight 34401A Digital Multi-Meters.",
                IDPrior: TestLib.NONE,
                IDNext: "MSMU_34980A",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: false,
                Arguments: "NotApplicable"));

            Boolean passed = true;
            foreach (KeyValuePair<String, Object> kvp in TestLib.InstrumentDrivers) {
                if (kvp.Value is MM_34401A_SCPI_NET mm_34401a_scpi_net) {
                    passed &= mm_34401a_scpi_net.Diagnostics() is DIAGNOSTICS_RESULTS.PASS;
                    passed &= Diagnostics_MM_34401A_SCPI_NET(mm_34401a_scpi_net);
                }
            }

            return passed ? EVENTS.PASS.ToString() : EVENTS.FAIL.ToString();
        }
        #endregion GroupID MM_34401A

        private static Boolean Diagnostics_MM_34401A_SCPI_NET(MM_34401A_SCPI_NET mm_34401a_scpi_net) {
            return true;
        }
    }
}
