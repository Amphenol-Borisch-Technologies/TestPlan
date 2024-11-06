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
        #region GroupID PS_E3649A
        internal static String PS_E3649A() {
            Debug.Assert(TestLib.IsGroup(
                GroupID: "PS_E3649A",
                Description: "Keysight E3634A Diagnostics.",
                MeasurementIDs: "PS_E3649A",
                Selectable: true,
                CancelNotPassed: false));
            Debug.Assert(TestLib.IsMeasurement(
                Description: "Keysight E3649A Power Supplies.",
                IDPrior: "PS_E3634A",
                IDNext: TestLib.NONE,
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));

            return Diagnostics_PS_E3649A_SCPI_NET();
        }

        internal static String Diagnostics_PS_E3649A_SCPI_NET() {
            Boolean passedIndividual;
            Boolean passedCollective = true;
            foreach (KeyValuePair<String, Object> kvp in TestLib.InstrumentDrivers) {
                if (kvp.Value is PS_E3649A_SCPI_NET ps_e3649A_scpi_net) {
                    passedIndividual = ps_e3649A_scpi_net.Diagnostics() is DIAGNOSTICS_RESULTS.PASS;
                    passedCollective &= passedIndividual;
                    if (passedIndividual) passedCollective &= Diagnostics_PS_E3649A_SCPI_NET_Extended(); // Skip extended diagnostics if self-test failed.
                }
            }
            return passedCollective ? EVENTS.PASS.ToString() : EVENTS.FAIL.ToString();
        }

        internal static Boolean Diagnostics_PS_E3649A_SCPI_NET_Extended() {
            Boolean passedExtended = true;
            // TODO: Add diagnostics that utilize other instruments and/or self-test harnesses, log results.
            return passedExtended;
        }
        #endregion GroupID PS_E3649A
    }
}