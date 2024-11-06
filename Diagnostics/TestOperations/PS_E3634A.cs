using System;
using System.Collections.Generic;
using System.Diagnostics;
using ABT.TestExec.Lib;
using ABT.TestExec.Lib.AppConfig;
using ABT.TestExec.Lib.InstrumentDrivers.Interfaces;
using ABT.TestExec.Lib.InstrumentDrivers.PowerSupplies;

namespace ABT.TestExec.Tests.Diagnostics.TestOperations {
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
                CancelNotPassed: true,
                Arguments: "NotApplicable"));

            Boolean passed = true;
            foreach (KeyValuePair<String, Object> kvp in TestLib.InstrumentDrivers) {
                if (kvp.Value is PS_E3634A_SCPI_NET ps_e3634A_scpi_net) {
                    passed &= ps_e3634A_scpi_net.Diagnostics() is DIAGNOSTICS_RESULTS.PASS;
                    passed &= Diagnostics_PS_E3634A_SCPI_NET(ps_e3634A_scpi_net);
                }
            }

            return passed ? EVENTS.PASS.ToString() : EVENTS.FAIL.ToString();
        }
        #endregion GroupID PS_E3634A

        private static Boolean Diagnostics_PS_E3634A_SCPI_NET(PS_E3634A_SCPI_NET ps_e3634A_scpi_net) {
            return true;
        }
    }
}
