using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using ABT.Test.TestLib;
using ABT.Test.TestLib.AppConfig;
using ABT.Test.TestLib.InstrumentDrivers.Interfaces;
using ABT.Test.TestLib.InstrumentDrivers.Oscilloscopes;

namespace ABT.Test.TestPlans.Diagnostics.TestOperations {
    internal static partial class TestMeasurements {
        // NOTE:  Invocable test methods in this class, defined as TestMeasurement IDs in App.config, require signatures like "internal static String MethodName()".
        #region GroupID MSO_3014
        internal static String MSO_3014() {
            Debug.Assert(TestLib.TestLib.IsGroup(
                GroupID: "MSO_3014",
                Description: "Tektronix MSO-3014 Diagnostics.",
                MeasurementIDs: "MSO_3014",
                Selectable: true,
                CancelNotPassed: false));
            Debug.Assert(TestLib.TestLib.IsMeasurement(
                Description: "Tektronix MSO-3014 Mixed-Signal Oscilloscopes.",
                IDPrior: "MSMU_34980A",
                IDNext: "PS_E3634A",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: false,
                Arguments: "NotApplicable"));

            return Diagnostics_MSO_3014_IVI_COM();
        }

        internal static String Diagnostics_MSO_3014_IVI_COM() {
            Dictionary<String, MSO_3014_IVI_COM> mso_3014_ivi_com = TestLib.TestLib.InstrumentDrivers.Where(kvp => kvp.Value is MSO_3014_IVI_COM).ToDictionary(kvp => kvp.Key, kvp => (MSO_3014_IVI_COM)kvp.Value);
            if (mso_3014_ivi_com.Count() == 0) return EVENTS.IGNORE.ToString();

            Boolean passedIndividual;
            Boolean passedCollective = true;
            foreach (KeyValuePair<String, MSO_3014_IVI_COM> kvp in mso_3014_ivi_com) {
                passedIndividual = kvp.Value.SelfTests() is SELF_TEST_RESULTS.PASS;
                passedCollective &= passedIndividual;
                if (passedIndividual) passedCollective &= Diagnostics_MM_34401A_SCPI_NET_Extended(); // Skip extended diagnostics if self-test failed.
            }
            return passedCollective ? EVENTS.PASS.ToString() : EVENTS.FAIL.ToString();
        }

        internal static Boolean Diagnostics_MSO_3014_IVI_COM_Extended() {
            Boolean passedExtended = true;
            // TODO: Add diagnostics that utilize other instruments and/or self-test harnesses, log results.
            return passedExtended;
        }
        #endregion GroupID MSO_3014
    }
}
