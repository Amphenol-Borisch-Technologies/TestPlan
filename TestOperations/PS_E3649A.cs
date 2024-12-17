﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using ABT.Test.TestLib;
using ABT.Test.TestLib.AppConfig;
using ABT.Test.TestLib.InstrumentDrivers.Interfaces;
using ABT.Test.TestLib.InstrumentDrivers.PowerSupplies;

namespace ABT.Test.TestPlans.Diagnostics.TestOperations {
    internal static partial class TestMeasurementsOld {
        // NOTE:  Invocable test methods in this class, defined as TestMeasurement IDs in App.config, require signatures like "internal static String MethodName()".
        #region GroupID PS_E3649A
        internal static String PS_E3649A() {
            Debug.Assert(TestLib.TestLib.IsGroup(
                GroupID: "PS_E3649A",
                Description: "Keysight E3649A Diagnostics.",
                MeasurementIDs: "PS_E3649A",
                Selectable: true,
                CancelNotPassed: false));
            Debug.Assert(TestLib.TestLib.IsMeasurement(
                Description: "Keysight E3649A Power Supplies.",
                IDPrior: "PS_E3634A",
                IDNext: TestLib.TestLib.NONE,
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: false,
                Arguments: "NotApplicable"));

            return Diagnostics_PS_E3649A_SCPI_NET();
        }

        internal static String Diagnostics_PS_E3649A_SCPI_NET() {
            Dictionary<String, PS_E3649A_SCPI_NET> ps_e3649A_scpi_net = TestLib.TestLib.InstrumentDrivers.Where(kvp => kvp.Value is PS_E3649A_SCPI_NET).ToDictionary(kvp => kvp.Key, kvp => (PS_E3649A_SCPI_NET)kvp.Value);
            if (ps_e3649A_scpi_net.Count() == 0) return EVENTS.IGNORE.ToString();

            Boolean passedIndividual;
            Boolean passedCollective = true;
            foreach (KeyValuePair<String, PS_E3649A_SCPI_NET> kvp in ps_e3649A_scpi_net) {
                passedIndividual = kvp.Value.SelfTests() is SELF_TEST_RESULTS.PASS;
                passedCollective &= passedIndividual;
                if (passedIndividual) passedCollective &= Diagnostics_MM_34401A_SCPI_NET_Extended(); // Skip extended diagnostics if self-test failed.
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