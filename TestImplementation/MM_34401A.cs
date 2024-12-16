using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using ABT.Test.Lib;
using ABT.Test.Lib.AppConfig;
using ABT.Test.Lib.InstrumentDrivers.Interfaces;
using ABT.Test.Lib.InstrumentDrivers.MultiMeters;

namespace ABT.Test.Plans.Diagnostics.TestImplementation {
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

            return Diagnostics_MM_34401A_SCPI_NET();
        }

        internal static String Diagnostics_MM_34401A_SCPI_NET() {
            Dictionary<String, MM_34401A_SCPI_NET> mm_34401a_scpi_net = TestLib.InstrumentDrivers.Where(kvp => kvp.Value is MM_34401A_SCPI_NET).ToDictionary(kvp => kvp.Key, kvp => (MM_34401A_SCPI_NET)kvp.Value);
            if (mm_34401a_scpi_net.Count() == 0) return EVENTS.IGNORE.ToString();

            Boolean passedIndividual;
            Boolean passedCollective = true;
            foreach (KeyValuePair<String, MM_34401A_SCPI_NET> kvp in mm_34401a_scpi_net) {
                passedIndividual = kvp.Value.SelfTests() is SELF_TEST_RESULTS.PASS;
                passedCollective &= passedIndividual;
                if (passedIndividual) passedCollective &= Diagnostics_MM_34401A_SCPI_NET_Extended(); // Skip extended diagnostics if self-test failed.
            }
            return passedCollective ? EVENTS.PASS.ToString() : EVENTS.FAIL.ToString();
        }

        internal static Boolean Diagnostics_MM_34401A_SCPI_NET_Extended() {
            Boolean passedExtended = true;
            // TODO: Add diagnostics that utilize other instruments and/or self-test harnesses, log results.
            return passedExtended;
        }
        #endregion GroupID MM_34401A
    }
}
