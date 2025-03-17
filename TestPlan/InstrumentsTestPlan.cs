﻿namespace ABT.Test.TestPlans.Diagnostics.TestPlan.InstrumentsTestPlan {
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Windows.Forms;
    using ABT.Test.TestLib;
    using ABT.Test.TestPlans.Diagnostics.InstrumentDrivers;
    using ABT.Test.TestLib.InstrumentDrivers.Generic;
    using ABT.Test.TestLib.InstrumentDrivers.Interfaces;
    using ABT.Test.TestLib.InstrumentDrivers.Multifunction;
    using ABT.Test.TestLib.InstrumentDrivers.MultiMeters;
    using ABT.Test.TestLib.InstrumentDrivers.Oscilloscopes;
    using ABT.Test.TestLib.InstrumentDrivers.PowerSupplies;
    using ABT.Test.TestLib.Configuration;
    using static ABT.Test.TestLib.Data;
    using static ABT.Test.TestLib.Configuration.Assertions;
    using static ABT.Test.TestPlans.Diagnostics.TestPlan.InstrumentsTestPlan.TestMethods;

    internal class SwitchingUnits {
        internal static String MSMU_34980A() {
            if (Data.testSequence.IsOperation) Debug.Assert(TestOperation(NamespaceTrunk: "InstrumentsTestPlan", ProductionTest: "true", Description: "Manufacturer\'s self-tests + ABT tests of TestPlanDefinition\'s InstrumentsTestPlan.", TestGroups: "SwitchingUnits|PowerSupplies|DigitalMultiMeters|Oscilloscopes|WaveformGenerators"));
            Debug.Assert(TestGroup(Classname: "SwitchingUnits", Description: "Keysight 34980As.", CancelNotPassed: "false", Independent: "true", Methods: "MSMU_34980A"));
            Debug.Assert(MethodCustom(Name: "MSMU_34980A", Description: "Keysight 34980A Multifunction Switch/Measurement Units.", CancelNotPassed: "false"));

            TestIndices.Method.Event = DiagnosticsT<MSMU_34980A_SCPI_NET>(((MethodCustom)TestIndices.Method).Parameters);
            return TestIndices.Method.LogFetchAndClear();
        }
    }

    internal class PowerSupplies {
        internal static String PS_E3634A() {
            Debug.Assert(TestGroup(Classname: "PowerSupplies", Description: "Keysight E3634As & E3649As.", CancelNotPassed: "false", Independent: "true", Methods: "PS_E3634A|PS_E3649A"));
            Debug.Assert(MethodCustom(Name: "PS_E3634A", Description: "Keysight E3634A Power Supplies.", CancelNotPassed: "false"));

            TestIndices.Method.Event = DiagnosticsT<PS_E3634A_SCPI_NET>(((MethodCustom)TestIndices.Method).Parameters);
            return TestIndices.Method.LogFetchAndClear();
        }

        internal static String PS_E3649A() {
            Debug.Assert(MethodCustom(Name: "PS_E3649A", Description: "Keysight E3649A Power Supplies.", CancelNotPassed: "false"));

            TestIndices.Method.Event = DiagnosticsT<PS_E3649A_SCPI_NET>(((MethodCustom)TestIndices.Method).Parameters);
            return TestIndices.Method.LogFetchAndClear();
        }
    }

    internal class DigitalMultiMeters {
        internal static String MM_34401A() {
            Debug.Assert(TestGroup(Classname: "DigitalMultiMeters", Description: "Keysight 34401As.", CancelNotPassed: "false", Independent: "true", Methods: "MM_34401A"));
            Debug.Assert(MethodCustom(Name: "MM_34401A", Description: "Keysight 34401A Digital Multi-Meters.", CancelNotPassed: "false"));

            TestIndices.Method.Event = DiagnosticsT<MM_34401A_SCPI_NET>(((MethodCustom)TestIndices.Method).Parameters);
            return TestIndices.Method.LogFetchAndClear();
        }
    }

    internal class Oscilloscopes {
        internal static String MSO_3014() {
            Debug.Assert(TestGroup(Classname: "Oscilloscopes", Description: "Tektronix MSO-3014s.", CancelNotPassed: "false", Independent: "true", Methods: "MSO_3014"));
            Debug.Assert(MethodCustom(Name: "MSO_3014", Description: "Tektronix MSO-3014 Mixed-Signal Oscilloscopes.", CancelNotPassed: "false"));

            TestIndices.Method.Event = DiagnosticsT<MSO_3014_IVI_COM>(((MethodCustom)TestIndices.Method).Parameters);
            return TestIndices.Method.LogFetchAndClear();
        }
    }

    internal class WaveformGenerators {
        internal static String WG_33120A() {
            Debug.Assert(TestGroup(Classname: "WaveformGenerators", Description: "Keysight 33120As.", CancelNotPassed: "false", Independent: "true", Methods: "WG_33120A"));
            Debug.Assert(MethodCustom(Name: "WG_33120A", Description: "Keysight 33120A 15MHz Function/Arbitrary Waveform Generators.", CancelNotPassed: "false"));

            TestIndices.Method.Event = DiagnosticsT<SCPI_NET>(((MethodCustom)TestIndices.Method).Parameters);
            if (TestIndices.Method.Event != EVENTS.INFORMATION) { // No SCPI_NET instruments defined in TestPlanDefinition.xml.
                IA.WG.Transport.Command.Invoke("APPLy:SQUare 10E+6, 5.0, -2.5");
                _ = MessageBox.Show("Press OK to continue.", "Waveform Generator", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            return TestIndices.Method.LogFetchAndClear();
        }
    }


    internal static class TestMethods {
        internal static EVENTS DiagnosticsT<T>(List<Parameter> Parameters) where T : IDiagnostics {
            Dictionary<String, T> instrumentDriversT = Data.InstrumentDrivers.Where(kvp => kvp.Value is T).ToDictionary(kvp => kvp.Key, kvp => (T)kvp.Value);
            if (instrumentDriversT.Count() == 0) {
                TestIndices.Method.Log.AppendLine($"No instruments of type '{typeof(T).Name}' defined in '{TestExecDefinitionXML}'.");
                return EVENTS.INFORMATION;
            }

            (Boolean Summary, List<DiagnosticsResult> Details) resultDiagnostics;
            Boolean passedCollective = true;
            foreach (KeyValuePair<String, T> kvp in instrumentDriversT) {
                resultDiagnostics = kvp.Value.Diagnostics(o);
                passedCollective &= resultDiagnostics.Summary;
                TestIndices.Method.Log.AppendLine($"ID '{kvp.Key}', Driver '{typeof(T).Name}', Result '{(resultDiagnostics.Summary ? EVENTS.PASS.ToString() : EVENTS.FAIL.ToString())}'.");
                foreach (DiagnosticsResult dr in resultDiagnostics.Details) TestIndices.Method.Log.AppendLine($"{dr.Label}{dr.Message}, Result '{dr.Event}'.");
            }
            return passedCollective ? EVENTS.PASS : EVENTS.FAIL;
        }
    }
}
