﻿namespace ABT.Test.TestPlans.Diagnostics.TestOperations {
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using ABT.Test.TestLib;
    using ABT.Test.TestLib.InstrumentDrivers.Interfaces;
    using ABT.Test.TestLib.InstrumentDrivers.Multifunction;
    using ABT.Test.TestLib.InstrumentDrivers.MultiMeters;
    using ABT.Test.TestLib.InstrumentDrivers.Oscilloscopes;
    using ABT.Test.TestLib.InstrumentDrivers.PowerSupplies;
    using static ABT.Test.TestLib.TestSpec.Assertions;
    using static ABT.Test.TestLib.InstrumentDrivers.Multifunction.MSMU_34980A_SCPI_NET;

    internal class TestMeasurements {
        
        static String MSMU_34980A() {
			Debug.Assert(TO(NamespaceLeaf: "ABT.Test.TestPlans.Diagnostics.TestOperations", Description: "Diagnostics.", TestGroups: "TestMeasurements"));
			Debug.Assert(TG_Prior(Class: "NONE"));
			Debug.Assert(TG(Class: "TestMeasurements", Description: "Diagnostics Measurements.", CancelNotPassed: "true", Independent: "true", Methods: "MSMU_34980A|MM_34401A|MSO_3014|PS_E3634A|PS_E3649A"));
			Debug.Assert(TG_Next(Class: "NONE"));
			Debug.Assert(M_Prior(Method: "NONE"));
			Debug.Assert(MC(Method: "MSMU_34980A", Description: "Keysight 34980A Multifunction Switch/Measurement Units.", CancelNotPassed: "true"));
			Debug.Assert(M_Next(Method: "MM_34401A"));

            // TODO: foreach (KeyValuePair<String, Object> kvp in TestLib.TestLib.InstrumentDrivers) if (kvp.Value is IDiagnostics id) id.Diagnostics();

            Dictionary<String, MSMU_34980A_SCPI_NET> msmu_34980a_scpi_net = TestLib.InstrumentDrivers.Where(kvp => kvp.Value is MSMU_34980A_SCPI_NET).ToDictionary(kvp => kvp.Key, kvp => (MSMU_34980A_SCPI_NET)kvp.Value);
            if (msmu_34980a_scpi_net.Count() == 0) return EVENTS.IGNORE.ToString();

            (Boolean Summary, List<DiagnosticsResult> Details) resultDiagnostics;
            Boolean passedCollective = true;
            foreach (KeyValuePair<String, MSMU_34980A_SCPI_NET> kvp in msmu_34980a_scpi_net) {
                resultDiagnostics = kvp.Value.Diagnostics(new DiagnosticParameter_34980A(Ω: 3));
                passedCollective &= resultDiagnostics.Summary;
                Diagnostics.Only.MessageAppendLine(Label: $"{nameof(MSMU_34980A_SCPI_NET)} ID {kvp.Key}:", Message: $"Result: {(resultDiagnostics.Summary ? EVENTS.PASS.ToString() : EVENTS.FAIL.ToString())}");
                foreach (DiagnosticsResult dr in resultDiagnostics.Details) Diagnostics.Only.MessageAppendLine(Label: $"{dr.Label}", Message: $"{dr.Message}, {dr.Event}.");
            }
            return passedCollective ? EVENTS.PASS.ToString() : EVENTS.FAIL.ToString();
        }
        
        static String MM_34401A() {
			Debug.Assert(M_Prior(Method: "MSMU_34980A"));
			Debug.Assert(MC(Method: "MM_34401A", Description: "Keysight 34401A Digital Multi-Meters.", CancelNotPassed: "true"));
			Debug.Assert(M_Next(Method: "MSO_3014"));

            Dictionary<String, MM_34401A_SCPI_NET> mm_34401a_scpi_net = TestLib.InstrumentDrivers.Where(kvp => kvp.Value is MM_34401A_SCPI_NET).ToDictionary(kvp => kvp.Key, kvp => (MM_34401A_SCPI_NET)kvp.Value);
            if (mm_34401a_scpi_net.Count() == 0) return EVENTS.IGNORE.ToString();

            (Boolean Summary, List<DiagnosticsResult> Details) resultDiagnostics;
            Boolean passedCollective = true;
            foreach (KeyValuePair<String, MM_34401A_SCPI_NET> kvp in mm_34401a_scpi_net) {
                // TODO: resultDiagnostics = kvp.Value.Diagnostics();
                resultDiagnostics = (false, new List<DiagnosticsResult>() { new DiagnosticsResult(Label: $"Diagnostic '{nameof(MM_34401A_SCPI_NET)}'", Message: "Not Implemented yet.", Event: EVENTS.IGNORE) });
                passedCollective &= resultDiagnostics.Summary;
                Diagnostics.Only.MessageAppendLine(Label: $"{nameof(MM_34401A_SCPI_NET)} ID {kvp.Key}:", Message: $"Result: {(resultDiagnostics.Summary ? EVENTS.PASS.ToString() : EVENTS.FAIL.ToString())}");
                foreach (DiagnosticsResult dr in resultDiagnostics.Details) Diagnostics.Only.MessageAppendLine(Label: $"{dr.Label}", Message: $"{dr.Message}, {dr.Event}.");
            }
            return passedCollective ? EVENTS.PASS.ToString() : EVENTS.FAIL.ToString();
        }
        
        static String MSO_3014() {
			Debug.Assert(M_Prior(Method: "MM_34401A"));
			Debug.Assert(MC(Method: "MSO_3014", Description: "Tektronix MSO-3014 Mixed-Signal Oscilloscopes.", CancelNotPassed: "true"));
			Debug.Assert(M_Next(Method: "PS_E3634A"));

            Dictionary<String, MSO_3014_IVI_COM> mso_3014_ivi_com = TestLib.InstrumentDrivers.Where(kvp => kvp.Value is MSO_3014_IVI_COM).ToDictionary(kvp => kvp.Key, kvp => (MSO_3014_IVI_COM)kvp.Value);
            if (mso_3014_ivi_com.Count() == 0) return EVENTS.IGNORE.ToString();

            (Boolean Summary, List<DiagnosticsResult> Details) resultDiagnostics;
            Boolean passedCollective = true;
            foreach (KeyValuePair<String, MSO_3014_IVI_COM> kvp in mso_3014_ivi_com) {
                // TODO: resultDiagnostics = kvp.Value.Diagnostics();
                resultDiagnostics = (false, new List<DiagnosticsResult>() { new DiagnosticsResult(Label: $"Diagnostic '{nameof(MSO_3014_IVI_COM)}'", Message: "Not Implemented yet.", Event: EVENTS.IGNORE) });
                passedCollective &= resultDiagnostics.Summary;
                Diagnostics.Only.MessageAppendLine(Label: $"{nameof(MSO_3014_IVI_COM)} ID {kvp.Key}:", Message: $"Result: {(resultDiagnostics.Summary ? EVENTS.PASS.ToString() : EVENTS.FAIL.ToString())}");
                foreach (DiagnosticsResult dr in resultDiagnostics.Details) Diagnostics.Only.MessageAppendLine(Label: $"{dr.Label}", Message: $"{dr.Message}, {dr.Event}.");
            }
            return passedCollective ? EVENTS.PASS.ToString() : EVENTS.FAIL.ToString();
        }
        
        static String PS_E3634A() {
			Debug.Assert(M_Prior(Method: "MSO_3014"));
			Debug.Assert(MC(Method: "PS_E3634A", Description: "Keysight E3634A Power Supplies.", CancelNotPassed: "true"));
			Debug.Assert(M_Next(Method: "PS_E3649A"));

            Dictionary<String, PS_E3634A_SCPI_NET> ps_e3634A_scpi_net = TestLib.InstrumentDrivers.Where(kvp => kvp.Value is PS_E3634A_SCPI_NET).ToDictionary(kvp => kvp.Key, kvp => (PS_E3634A_SCPI_NET)kvp.Value);
            if (ps_e3634A_scpi_net.Count() == 0) return EVENTS.IGNORE.ToString();

            (Boolean Summary, List<DiagnosticsResult> Details) resultDiagnostics;
            Boolean passedCollective = true;
            foreach (KeyValuePair<String, PS_E3634A_SCPI_NET> kvp in ps_e3634A_scpi_net) {
                // TODO: resultDiagnostics = kvp.Value.Diagnostics();
                resultDiagnostics = (false, new List<DiagnosticsResult>() { new DiagnosticsResult(Label: $"Diagnostic '{nameof(PS_E3634A_SCPI_NET)}'", Message: "Not Implemented yet.", Event: EVENTS.IGNORE) });
                passedCollective &= resultDiagnostics.Summary;
                Diagnostics.Only.MessageAppendLine(Label: $"{nameof(PS_E3634A_SCPI_NET)} ID {kvp.Key}:", Message: $"Result: {(resultDiagnostics.Summary ? EVENTS.PASS.ToString() : EVENTS.FAIL.ToString())}");
                foreach (DiagnosticsResult dr in resultDiagnostics.Details) Diagnostics.Only.MessageAppendLine(Label: $"{dr.Label}", Message: $"{dr.Message}, {dr.Event}.");
            }
            return passedCollective ? EVENTS.PASS.ToString() : EVENTS.FAIL.ToString();
        }
        
        static String PS_E3649A() {
			Debug.Assert(M_Prior(Method: "PS_E3634A"));
			Debug.Assert(MC(Method: "PS_E3649A", Description: "Keysight E3649A Power Supplies.", CancelNotPassed: "true"));
			Debug.Assert(M_Next(Method: "NONE"));

            Dictionary<String, PS_E3649A_SCPI_NET> ps_e3649A_scpi_net = TestLib.InstrumentDrivers.Where(kvp => kvp.Value is PS_E3649A_SCPI_NET).ToDictionary(kvp => kvp.Key, kvp => (PS_E3649A_SCPI_NET)kvp.Value);
            if (ps_e3649A_scpi_net.Count() == 0) return EVENTS.IGNORE.ToString();

            (Boolean Summary, List<DiagnosticsResult> Details) resultDiagnostics;
            Boolean passedCollective = true;
            foreach (KeyValuePair<String, PS_E3649A_SCPI_NET> kvp in ps_e3649A_scpi_net) {
                // TODO: resultDiagnostics = kvp.Value.Diagnostics();
                resultDiagnostics = (false, new List<DiagnosticsResult>() { new DiagnosticsResult(Label: $"Diagnostic '{nameof(PS_E3649A_SCPI_NET)}'", Message: "Not Implemented yet.", Event: EVENTS.IGNORE) });
                passedCollective &= resultDiagnostics.Summary;
                Diagnostics.Only.MessageAppendLine(Label: $"{nameof(PS_E3649A_SCPI_NET)} ID {kvp.Key}:", Message: $"Result: {(resultDiagnostics.Summary ? EVENTS.PASS.ToString() : EVENTS.FAIL.ToString())}");
                foreach (DiagnosticsResult dr in resultDiagnostics.Details) Diagnostics.Only.MessageAppendLine(Label: $"{dr.Label}", Message: $"{dr.Message}, {dr.Event}.");
            }
            return passedCollective ? EVENTS.PASS.ToString() : EVENTS.FAIL.ToString();
        }
    }
}
