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
using ABT.TestExec.Lib.InstrumentDrivers.Oscilloscopes;
using ABT.TestExec.Lib.InstrumentDrivers.PowerSupplies;
using ABT.TestExec.Tests.Diagnostics.InstrumentsDrivers;
using Windows.Foundation.Metadata;

namespace ABT.TestExec.Tests.Diagnostics.TestOperations {
    internal static partial class TestMeasurements {
        // NOTE:  Invocable test methods in this class, defined as TestMeasurement IDs in App.config, require signatures like "internal static String MethodName()".
        #region GroupID MSO_3014
        internal static String MSO_3014() {
            Debug.Assert(TestLib.IsGroup(
                GroupID: "MSO_3014",
                Description: "Tektronix MSO-3014 Diagnostics.",
                MeasurementIDs: "MSO_3014",
                Selectable: true,
                CancelNotPassed: false));
            Debug.Assert(TestLib.IsMeasurement(
                Description: "Tektronix MSO-3014 Mixed-Signal Oscilloscopes.",
                IDPrior: "MSMU_34980A",
                IDNext: "PS_E3634A",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: false,
                Arguments: "NotApplicable"));

            return Diagnostics_MSO_3014_IVI_COM();
        }

        internal static String Diagnostics_MSO_3014_IVI_COM() {
            Boolean passed = true;
            foreach (KeyValuePair<String, Object> kvp in TestLib.InstrumentDrivers) {
                if (kvp.Value is MSO_3014_IVI_COM mso_3014_ivi_com) {
                    passed &= mso_3014_ivi_com.Diagnostics() is DIAGNOSTICS_RESULTS.PASS;
                    // TODO: Add diagnostics that utilize other instruments and/or self-test harnesses.
                }
            }
            return passed ? EVENTS.PASS.ToString() : EVENTS.FAIL.ToString();
        }
        #endregion GroupID PS_E3634A
    }
}
