using ABT.Test.TestLib;
using System.Diagnostics;

namespace ABT.Test.TestPlans.Diagnostics.TestOperations.SCPI_VISA_Instruments {
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
    using static ABT.Test.TestLib.TestConfiguration.Assertions;
    using static ABT.Test.TestLib.InstrumentDrivers.Multifunction.MSMU_34980A_SCPI_NET;

    internal class TestMethods {
        static String MM_34401A() {
			if (TestLib.testSequence.IsOperation) Debug.Assert(TestOperation(NamespaceTrunk: "SCPI_VISA_Instruments", Description: "Diagnostics, SCPI VISA Instruments.", TestGroups: "TestMethods"));
			Debug.Assert(TestGroupPrior(Classname: "NONE"));
			Debug.Assert(TestGroup(Classname: "TestMethods", Description: "Diagnostics.", CancelNotPassed: "false", Independent: "true", Methods: "MM_34401A|MSO_3014|PS_E3634A|PS_E3649A|MSMU_34980A"));
			Debug.Assert(TestGroupNext(Classname: "NONE"));
			Debug.Assert(MethodPrior(Name: "NONE"));
			Debug.Assert(MethodCustom(Name: "MM_34401A", Description: "Keysight 34401A Digital Multi-Meters.", CancelNotPassed: "false"));
			Debug.Assert(MethodNext(Name: "MSO_3014"));

            Dictionary<String, MM_34401A_SCPI_NET> mm_34401a_scpi_net = TestLib.InstrumentDrivers.Where(kvp => kvp.Value is MM_34401A_SCPI_NET).ToDictionary(kvp => kvp.Key, kvp => (MM_34401A_SCPI_NET)kvp.Value);
            if (mm_34401a_scpi_net.Count() == 0) return EVENTS.INFORMATION.ToString();

            (Boolean Summary, List<DiagnosticsResult> Details) resultDiagnostics;
            Boolean passedCollective = true;
            foreach (KeyValuePair<String, MM_34401A_SCPI_NET> kvp in mm_34401a_scpi_net) {
                // TODO: resultDiagnostics = kvp.Value.Diagnostics();
                resultDiagnostics = (false, new List<DiagnosticsResult>() { new DiagnosticsResult(Label: $"Diagnostic '{nameof(MM_34401A_SCPI_NET)}'", Message: "Not Implemented yet.", Event: EVENTS.INFORMATION) });
                passedCollective &= resultDiagnostics.Summary;
                Diagnostics.Only.MessageAppendLine(Label: $"{nameof(MM_34401A_SCPI_NET)} ID {kvp.Key}:", Message: $"Result: {(resultDiagnostics.Summary ? EVENTS.PASS.ToString() : EVENTS.FAIL.ToString())}");
                foreach (DiagnosticsResult dr in resultDiagnostics.Details) Diagnostics.Only.MessageAppendLine(Label: $"{dr.Label}", Message: $"{dr.Message}, {dr.Event}.");
            }
            return passedCollective ? EVENTS.PASS.ToString() : EVENTS.FAIL.ToString();
        }
        
        static String MSO_3014() {
			Debug.Assert(MethodPrior(Name: "MM_34401A"));
			Debug.Assert(MethodCustom(Name: "MSO_3014", Description: "Tektronix MSO-3014 Mixed-Signal Oscilloscopes.", CancelNotPassed: "false"));
			Debug.Assert(MethodNext(Name: "PS_E3634A"));

            Dictionary<String, MSO_3014_IVI_COM> mso_3014_ivi_com = TestLib.InstrumentDrivers.Where(kvp => kvp.Value is MSO_3014_IVI_COM).ToDictionary(kvp => kvp.Key, kvp => (MSO_3014_IVI_COM)kvp.Value);
            if (mso_3014_ivi_com.Count() == 0) return EVENTS.INFORMATION.ToString();

            (Boolean Summary, List<DiagnosticsResult> Details) resultDiagnostics;
            Boolean passedCollective = true;
            foreach (KeyValuePair<String, MSO_3014_IVI_COM> kvp in mso_3014_ivi_com) {
                // TODO: resultDiagnostics = kvp.Value.Diagnostics();
                resultDiagnostics = (false, new List<DiagnosticsResult>() { new DiagnosticsResult(Label: $"Diagnostic '{nameof(MSO_3014_IVI_COM)}'", Message: "Not Implemented yet.", Event: EVENTS.INFORMATION) });
                passedCollective &= resultDiagnostics.Summary;
                Diagnostics.Only.MessageAppendLine(Label: $"{nameof(MSO_3014_IVI_COM)} ID {kvp.Key}:", Message: $"Result: {(resultDiagnostics.Summary ? EVENTS.PASS.ToString() : EVENTS.FAIL.ToString())}");
                foreach (DiagnosticsResult dr in resultDiagnostics.Details) Diagnostics.Only.MessageAppendLine(Label: $"{dr.Label}", Message: $"{dr.Message}, {dr.Event}.");
            }
            return passedCollective ? EVENTS.PASS.ToString() : EVENTS.FAIL.ToString();
        }

        static String PS_E3634A() {
			Debug.Assert(MethodPrior(Name: "MSO_3014"));
			Debug.Assert(MethodCustom(Name: "PS_E3634A", Description: "Keysight E3634A Power Supplies.", CancelNotPassed: "false"));
			Debug.Assert(MethodNext(Name: "PS_E3649A"));

            Dictionary<String, PS_E3634A_SCPI_NET> ps_e3634A_scpi_net = TestLib.InstrumentDrivers.Where(kvp => kvp.Value is PS_E3634A_SCPI_NET).ToDictionary(kvp => kvp.Key, kvp => (PS_E3634A_SCPI_NET)kvp.Value);
            if (ps_e3634A_scpi_net.Count() == 0) return EVENTS.INFORMATION.ToString();

            (Boolean Summary, List<DiagnosticsResult> Details) resultDiagnostics;
            Boolean passedCollective = true;
            foreach (KeyValuePair<String, PS_E3634A_SCPI_NET> kvp in ps_e3634A_scpi_net) {
                resultDiagnostics = kvp.Value.Diagnostics();
                passedCollective &= resultDiagnostics.Summary;
                Diagnostics.Only.MessageAppendLine(Label: $"{nameof(PS_E3634A_SCPI_NET)} ID {kvp.Key}:", Message: $"Result: {(resultDiagnostics.Summary ? EVENTS.PASS.ToString() : EVENTS.FAIL.ToString())}");
                foreach (DiagnosticsResult dr in resultDiagnostics.Details) Diagnostics.Only.MessageAppendLine(Label: $"{dr.Label}", Message: $"{dr.Message}, {dr.Event}.");
            }
            return passedCollective ? EVENTS.PASS.ToString() : EVENTS.FAIL.ToString();
        }
        
        static String PS_E3649A() {
			Debug.Assert(MethodPrior(Name: "PS_E3634A"));
			Debug.Assert(MethodCustom(Name: "PS_E3649A", Description: "Keysight E3649A Power Supplies.", CancelNotPassed: "false"));
			Debug.Assert(MethodNext(Name: "MSMU_34980A"));

            Dictionary<String, PS_E3649A_SCPI_NET> ps_e3649A_scpi_net = TestLib.InstrumentDrivers.Where(kvp => kvp.Value is PS_E3649A_SCPI_NET).ToDictionary(kvp => kvp.Key, kvp => (PS_E3649A_SCPI_NET)kvp.Value);
            if (ps_e3649A_scpi_net.Count() == 0) return EVENTS.INFORMATION.ToString();

            (Boolean Summary, List<DiagnosticsResult> Details) resultDiagnostics;
            Boolean passedCollective = true;
            foreach (KeyValuePair<String, PS_E3649A_SCPI_NET> kvp in ps_e3649A_scpi_net) {
                // TODO: resultDiagnostics = kvp.Value.Diagnostics();
                resultDiagnostics = (false, new List<DiagnosticsResult>() { new DiagnosticsResult(Label: $"Diagnostic '{nameof(PS_E3649A_SCPI_NET)}'", Message: "Not Implemented yet.", Event: EVENTS.INFORMATION) });
                passedCollective &= resultDiagnostics.Summary;
                Diagnostics.Only.MessageAppendLine(Label: $"{nameof(PS_E3649A_SCPI_NET)} ID {kvp.Key}:", Message: $"Result: {(resultDiagnostics.Summary ? EVENTS.PASS.ToString() : EVENTS.FAIL.ToString())}");
                foreach (DiagnosticsResult dr in resultDiagnostics.Details) Diagnostics.Only.MessageAppendLine(Label: $"{dr.Label}", Message: $"{dr.Message}, {dr.Event}.");
            }
            return passedCollective ? EVENTS.PASS.ToString() : EVENTS.FAIL.ToString();
        }

        static String MSMU_34980A() {
			Debug.Assert(MethodPrior(Name: "PS_E3649A"));
			Debug.Assert(MethodCustom(Name: "MSMU_34980A", Description: "Keysight 34980A Multifunction Switch/Measurement Units.", CancelNotPassed: "false"));
			Debug.Assert(MethodNext(Name: "NONE"));

            // TODO: foreach (KeyValuePair<String, Object> kvp in TestLib.TestLib.InstrumentDrivers) if (kvp.Value is IDiagnostics id) id.Diagnostics();

            Dictionary<String, MSMU_34980A_SCPI_NET> msmu_34980a_scpi_net = TestLib.InstrumentDrivers.Where(kvp => kvp.Value is MSMU_34980A_SCPI_NET).ToDictionary(kvp => kvp.Key, kvp => (MSMU_34980A_SCPI_NET)kvp.Value);
            if (msmu_34980a_scpi_net.Count() == 0) return EVENTS.INFORMATION.ToString();

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
    }
}    
namespace ABT.Test.TestPlans.Diagnostics.TestOperations.Miscellaneous {
    using System;
    using System.Diagnostics;
    using ABT.Test.TestLib;
    using ABT.Test.TestLib.TestConfiguration;
    using static ABT.Test.TestLib.TestConfiguration.Assertions;
    
    
    internal class MoreMethods {
        
        internal static String MoreMM_34401A() {
			if (TestLib.testSequence.IsOperation) Debug.Assert(TestOperation(NamespaceTrunk: "Miscellaneous", Description: "Miscellaneous items, including instruments that aren\'t both SCPI & VISA instruments.", TestGroups: "MoreMethods"));
			Debug.Assert(TestGroupPrior(Classname: "NONE"));
			Debug.Assert(TestGroup(Classname: "MoreMethods", Description: "Diagnostics.", CancelNotPassed: "false", Independent: "true", Methods: "MoreMM_34401A|MoreMSO_3014|MorePS_E3634A|MorePS_E3649A|MoreMSMU_34980A"));
			Debug.Assert(TestGroupNext(Classname: "NONE"));
			Debug.Assert(MethodPrior(Name: "NONE"));
			Debug.Assert(MethodProcess(Name: "MoreMM_34401A", Description: "Keysight 34401A Digital Multi-Meters.", CancelNotPassed: "false", Folder: "C:\\Test", File: "Temp.exe", Parameters: "", Expected: "0"));
			Debug.Assert(MethodNext(Name: "MoreMSO_3014"));
			return "-1";
        }
        
        internal static String MoreMSO_3014() {
			Debug.Assert(MethodPrior(Name: "MoreMM_34401A"));
			Debug.Assert(MethodTextual(Name: "MoreMSO_3014", Description: "Tektronix MSO-3014 Mixed-Signal Oscilloscopes.", CancelNotPassed: "false", Text: "Hi There!"));
			Debug.Assert(MethodNext(Name: "MorePS_E3634A"));
			return "";
        }
        
        internal static String MorePS_E3634A() {
			Debug.Assert(MethodPrior(Name: "MoreMSO_3014"));
			Debug.Assert(MethodCustom(Name: "MorePS_E3634A", Description: "Keysight E3634A Power Supplies.", CancelNotPassed: "false"));
			Debug.Assert(MethodNext(Name: "MorePS_E3649A"));
			return nameof(EVENTS.UNSET);
        }
        
        internal static String MorePS_E3649A() {
			Debug.Assert(MethodPrior(Name: "MorePS_E3634A"));
			Debug.Assert(MethodCustom(Name: "MorePS_E3649A", Description: "Keysight E3649A Power Supplies.", CancelNotPassed: "false", Parameters: "Key1=Value1|Key2=Value2|Key3=Value3"));
			Debug.Assert(MethodNext(Name: "MoreMSMU_34980A"));
			return nameof(EVENTS.UNSET);
        }
        
        internal static String MoreMSMU_34980A() {
			Debug.Assert(MethodPrior(Name: "MorePS_E3649A"));
			Debug.Assert(MethodInterval(Name: "MoreMSMU_34980A", Description: "Keysight 34980A Multifunction Switch/Measurement Units.", CancelNotPassed: "false", LowComparator: "GToE", Low: "5", High: "10", HighComparator: "LT", FractionalDigits: "2", UnitPrefix: "mega", Units: "Volts", UnitSuffix: "DC"));
			Debug.Assert(MethodNext(Name: "NONE"));
			return "NaN";
        }
    }
}
