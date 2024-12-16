using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using ABT.Test.Lib;
using ABT.Test.Lib.AppConfig;
using ABT.Test.Lib.InstrumentDrivers.Interfaces;
using ABT.Test.Lib.InstrumentDrivers.PowerSupplies;

namespace ABT.Test.Plans.Diagnostics.TestImplementation {
    internal static partial class TestMeasurements {
        // NOTE:  Invocable test methods in this class, defined as TestMeasurement IDs in App.config, require signatures like "internal static String MethodName()".
        #region GroupID PS_E3634A
        internal static String PS_E3634A() {
            Debug.Assert(TestLib.IsGroup(
                GroupID: "PS_E3634A",
                Description: "Keysight E3634A Diagnostics.",
                MeasurementIDs: "PS_E3634A",
                Selectable: true,
                CancelNotPassed: false));
            Debug.Assert(TestLib.IsMeasurement(
                Description: "Keysight E3634A Power Supplies.",
                IDPrior: "MSO_3014",
                IDNext: "PS_E3649A",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: false,
                Arguments: "NotApplicable"));

            return Diagnostics_PS_E3634A_SCPI_NET();
        }

        internal static String Diagnostics_PS_E3634A_SCPI_NET() {
            Dictionary<String, PS_E3634A_SCPI_NET> ps_e3634A_scpi_net = TestLib.InstrumentDrivers.Where(kvp => kvp.Value is PS_E3634A_SCPI_NET).ToDictionary(kvp => kvp.Key, kvp => (PS_E3634A_SCPI_NET)kvp.Value);
            if (ps_e3634A_scpi_net.Count() == 0) return EVENTS.IGNORE.ToString();

            Boolean passedIndividual;
            Boolean passedCollective = true;
            foreach (KeyValuePair<String, PS_E3634A_SCPI_NET> kvp in ps_e3634A_scpi_net) {
                passedIndividual = kvp.Value.SelfTests() is SELF_TEST_RESULTS.PASS;
                passedCollective &= passedIndividual;
                if (passedIndividual) passedCollective &= Diagnostics_MM_34401A_SCPI_NET_Extended(); // Skip extended diagnostics if self-test failed.
            }
            return passedCollective ? EVENTS.PASS.ToString() : EVENTS.FAIL.ToString();
        }

        internal static Boolean Diagnostics_PS_E3634A_SCPI_NET_Extended() {
            Boolean passedExtended = true;
            // TODO: Add diagnostics that utilize other instruments and/or self-test harnesses, log results.
            return passedExtended;
        }
        #endregion GroupID PS_E3634A
    }
}