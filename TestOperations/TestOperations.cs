﻿namespace ABT.Test.TestPlans.Diagnostics.TestOperations.SCPI_VISA_Instruments {
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Windows.Forms;
    using ABT.Test.TestLib;
    using ABT.Test.TestLib.InstrumentDrivers;
    using ABT.Test.TestLib.InstrumentDrivers.Generic;
    using ABT.Test.TestLib.InstrumentDrivers.Interfaces;
    using ABT.Test.TestLib.InstrumentDrivers.Multifunction;
    using ABT.Test.TestLib.InstrumentDrivers.MultiMeters;
    using ABT.Test.TestLib.InstrumentDrivers.Oscilloscopes;
    using ABT.Test.TestLib.InstrumentDrivers.PowerSupplies;
    using ABT.Test.TestLib.Configuration;
    using ABT.Test.TestPlans.Diagnostics.InstrumentsDrivers;
    using Agilent.CommandExpert.ScpiNet.AgSCPI99_1_0;
    using static ABT.Test.TestLib.Data;
    using static ABT.Test.TestLib.Configuration.Assertions;

    internal class TestMethods {
        public static Dictionary<String, Object> InstrumentDriversSystem = GetInstrumentDriversSystemDefinition();

        internal static String MSMU_34980A() {
			if (Data.testSequence.IsOperation) Debug.Assert(TestOperation(NamespaceTrunk: "SCPI_VISA_Instruments", ProductionTest: "true", Description: "Diagnostics of instruments exclusively defined in configuration file SystemDefinition.xml.", TestGroups: "TestMethods"));
			Debug.Assert(TestGroupPrior(Classname: NONE));
			Debug.Assert(TestGroup(Classname: "TestMethods", Description: "Comprised of manufacturer provided instrument self-tests + optional ABT diagnostics.", CancelNotPassed: "false", Independent: "true", Methods: "MSMU_34980A|PS_E3634A|PS_E3649A|MM_34401A|MSO_3014"));
			Debug.Assert(TestGroupNext(Classname: NONE));
			Debug.Assert(MethodPrior(Name: NONE));
			Debug.Assert(MethodCustom(Name: "MSMU_34980A", Description: "Keysight 34980A Multifunction Switch/Measurement Units.", CancelNotPassed: "false"));
			Debug.Assert(MethodNext(Name: "PS_E3634A"));

            TestIndices.Method.Event =  DiagnosticsT<MSMU_34980A_SCPI_NET>();
            return TestIndices.Method.LogFetchAndClear();
        }

        internal static String PS_E3634A() {
			Debug.Assert(MethodPrior(Name: "MSMU_34980A"));
			Debug.Assert(MethodCustom(Name: "PS_E3634A", Description: "Keysight E3634A Power Supplies.", CancelNotPassed: "false"));
			Debug.Assert(MethodNext(Name: "PS_E3649A"));

            TestIndices.Method.Event =  DiagnosticsT<PS_E3634A_SCPI_NET>();
            return TestIndices.Method.LogFetchAndClear();
        }

        internal static String PS_E3649A() {
			Debug.Assert(MethodPrior(Name: "PS_E3634A"));
			Debug.Assert(MethodCustom(Name: "PS_E3649A", Description: "Keysight E3649A Power Supplies.", CancelNotPassed: "false"));
			Debug.Assert(MethodNext(Name: "MM_34401A"));

            TestIndices.Method.Event =  DiagnosticsT<PS_E3649A_SCPI_NET>();
            return TestIndices.Method.LogFetchAndClear();
        }

        
        internal static String MM_34401A() {
			Debug.Assert(MethodPrior(Name: "PS_E3649A"));
			Debug.Assert(MethodCustom(Name: "MM_34401A", Description: "Keysight 34401A Digital Multi-Meters.", CancelNotPassed: "false"));
			Debug.Assert(MethodNext(Name: "MSO_3014"));
            Debug.Assert(MethodNext(Name: "MSO_3014"));

            TestIndices.Method.Event = DiagnosticsT<MM_34401A_SCPI_NET>();
            return TestIndices.Method.LogFetchAndClear();
        }

        internal static String MSO_3014() {
			Debug.Assert(MethodPrior(Name: "MM_34401A"));
			Debug.Assert(MethodCustom(Name: "MSO_3014", Description: "Tektronix MSO-3014 Mixed-Signal Oscilloscopes.", CancelNotPassed: "false"));
			Debug.Assert(MethodNext(Name: NONE));

            TestIndices.Method.Event =  DiagnosticsT<MSO_3014_IVI_COM>();
            return TestIndices.Method.LogFetchAndClear();
        }

        internal static String WG1_33120A() {
			if (Data.testSequence.IsOperation) Debug.Assert(TestOperation(NamespaceTrunk: "SCPI_VISA_Instruments", ProductionTest: "true", Description: "Diagnostics of instruments exclusively defined in configuration file SystemDefinition.xml.", TestGroups: "TestMethods"));
			Debug.Assert(TestGroupPrior(Classname: NONE));
			Debug.Assert(TestGroup(Classname: "TestMethods", Description: "Comprised of manufacturer provided instrument self-tests + optional ABT diagnostics.", CancelNotPassed: "false", Independent: "true", Methods: "WG1_33120A"));
			Debug.Assert(TestGroupNext(Classname: NONE));
			Debug.Assert(MethodPrior(Name: NONE));
			Debug.Assert(MethodCustom(Name: "WG1_33120A", Description: "Keysight 33120A 15MHz Function/Arbitray Waveform Generator", CancelNotPassed: "false"));
			Debug.Assert(MethodNext(Name: NONE));

            TestIndices.Method.Event =  DiagnosticsT<SCPI_NET>();
            ID.WG.Transport.Command.Invoke("APPLy:SQUare 10E+6, 5.0, -2.5");
            _ = MessageBox.Show("Press OK to continue.", "Waveform Generator", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            return TestIndices.Method.LogFetchAndClear();
        }

        private static EVENTS DiagnosticsT<T>() where T : IDiagnostics {
            Dictionary<String, T> instrumentDriversT = InstrumentDriversSystem.Where(kvp => kvp.Value is T).ToDictionary(kvp => kvp.Key, kvp => (T)kvp.Value);
            if (instrumentDriversT.Count() == 0) {
                TestIndices.Method.Log.AppendLine($"No instruments of type '{typeof(T).Name}' defined in '{SystemDefinitionXML}'.");
                return EVENTS.INFORMATION;
            }

            (Boolean Summary, List<DiagnosticsResult> Details) resultDiagnostics;
            Boolean passedCollective = true;
            foreach (KeyValuePair<String, T> kvp in instrumentDriversT) {
                resultDiagnostics = kvp.Value.Diagnostics();
                passedCollective &= resultDiagnostics.Summary;
                TestIndices.Method.Log.AppendLine($"ID '{kvp.Key}', Driver '{typeof(T).Name}', Result '{(resultDiagnostics.Summary ? EVENTS.PASS.ToString() : EVENTS.FAIL.ToString())}'.");
                foreach (DiagnosticsResult dr in resultDiagnostics.Details) TestIndices.Method.Log.AppendLine($"{dr.Label}{dr.Message}, Result '{dr.Event}'.");
            }
            return passedCollective ? EVENTS.PASS : EVENTS.FAIL;
        }
    }
}

namespace ABT.Test.TestPlans.Diagnostics.TestOperations.Miscellaneous {
    using System;
    using System.Diagnostics;
    using ABT.Test.TestLib;
    using ABT.Test.TestLib.Configuration;
    using static ABT.Test.TestLib.Data;
    using static ABT.Test.TestLib.Configuration.Assertions;
    
    internal class MoreMethods {
        
        internal static String MoreMSMU_34980A() {
			if (Data.testSequence.IsOperation) Debug.Assert(TestOperation(NamespaceTrunk: "Miscellaneous", ProductionTest: "true", Description: "Miscellaneous items, including instruments that aren\'t both SCPI & VISA instruments.", TestGroups: "MoreMethods"));
			Debug.Assert(TestGroupPrior(Classname: NONE));
			Debug.Assert(TestGroup(Classname: "MoreMethods", Description: "Diagnostics.", CancelNotPassed: "false", Independent: "true", Methods: "MoreMSMU_34980A|MorePS_E3634A|MorePS_E3649A|MoreMM_34401A|MoreMSO_3014"));
			Debug.Assert(TestGroupNext(Classname: NONE));
			Debug.Assert(MethodPrior(Name: NONE));
			Debug.Assert(MethodInterval(Name: "MoreMSMU_34980A", Description: "Keysight 34980A Multifunction Switch/Measurement Units.", CancelNotPassed: "false", LowComparator: "GToE", Low: "5", High: "10", HighComparator: "LT", FractionalDigits: "2", UnitPrefix: "NONE", Units: "NONE", UnitSuffix: "NONE"));
			Debug.Assert(MethodNext(Name: "MorePS_E3634A"));
			return Double.NaN.ToString();
        }
        
        internal static String MorePS_E3634A() {
			Debug.Assert(MethodPrior(Name: "MoreMSMU_34980A"));
			Debug.Assert(MethodCustom(Name: "MorePS_E3634A", Description: "Keysight E3634A Power Supplies.", CancelNotPassed: "false"));
			Debug.Assert(MethodNext(Name: "MorePS_E3649A"));
			TestIndices.Method.Event = EVENTS.UNSET;
			return String.Empty;
        }
        
        internal static String MorePS_E3649A() {
			Debug.Assert(MethodPrior(Name: "MorePS_E3634A"));
			Debug.Assert(MethodCustom(Name: "MorePS_E3649A", Description: "Keysight E3649A Power Supplies.", CancelNotPassed: "false", Parameters: "Key1=Value1|Key2=Value2|Key3=Value3"));
			Debug.Assert(MethodNext(Name: "MoreMM_34401A"));
			TestIndices.Method.Event = EVENTS.UNSET;
			return String.Empty;
        }
        
        internal static String MoreMM_34401A() {
			Debug.Assert(MethodPrior(Name: "MorePS_E3649A"));
			Debug.Assert(MethodProcess(Name: "MoreMM_34401A", Description: "Keysight 34401A Digital Multi-Meters.", CancelNotPassed: "false", Folder: "C:\\Test", File: "Temp.exe", Parameters: "", Expected: "0"));
			Debug.Assert(MethodNext(Name: "MoreMSO_3014"));
			return "-1";
        }
        
        internal static String MoreMSO_3014() {
			Debug.Assert(MethodPrior(Name: "MoreMM_34401A"));
			Debug.Assert(MethodTextual(Name: "MoreMSO_3014", Description: "Tektronix MSO-3014 Mixed-Signal Oscilloscopes.", CancelNotPassed: "false", Text: "Hi There!"));
			Debug.Assert(MethodNext(Name: NONE));
			return String.Empty;
        }
    }
}
