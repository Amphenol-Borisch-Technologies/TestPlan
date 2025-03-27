namespace ABT.Test.TestPlans.Diagnostics.TestPlan.InstrumentsTestPlan {
    using ABT.Test.TestLib;
    using ABT.Test.TestLib.Configuration;
    using ABT.Test.TestLib.InstrumentDrivers.Generic;
    using ABT.Test.TestLib.InstrumentDrivers.Multifunction;
    using ABT.Test.TestLib.InstrumentDrivers.MultiMeters;
    using ABT.Test.TestLib.InstrumentDrivers.Oscilloscopes;
    using ABT.Test.TestLib.InstrumentDrivers.PowerSupplies;
    using ABT.Test.TestPlans.Diagnostics.InstrumentDrivers;
    using System;
    using System.Diagnostics;
    using System.Windows.Forms;

    internal class SwitchingUnits {
        internal static String MSMU_34980A() {
			if (Data.testSequence.IsOperation) Debug.Assert(TestIndices.TestOperation.Assert(NamespaceTrunk: "InstrumentsTestPlan", ProductionTest: "true", Description: "Manufacturer\'s self-tests + ABT tests of TestPlanDefinition\'s InstrumentsTestPlan.", TestGroups: "SwitchingUnits|PowerSupplies|DigitalMultiMeters|Oscilloscopes|WaveformGenerators"));
			Debug.Assert(TestIndices.TestGroup.Assert(Classname: "SwitchingUnits", Description: "Keysight 34980As.", CancelNotPassed: "false", Independent: "true", Methods: "MSMU_34980A"));
			Debug.Assert(((MethodCustom)TestIndices.Method).Assert(Name: "MSMU_34980A", Description: "Keysight 34980A Multifunction Switch/Measurement Units.", CancelNotPassed: "false", Parameters: "FRTD_34921A_Low°C=15.5|FRTD_34921A_High°C=29.5|ResistanceRelay_34921A_ClosedΩ=3|ResistanceRelay_34921A_OpenedΩ=1E9|ResistanceRelay_34932A_ClosedΩ=3|Current_34921A_LowADC=0.075|Current_34921A_HighADC=0.125|ResistanceRelay_34932A_OpenedΩ=1E9|ResistanceRelay_34938A_ClosedΩ=3|ResistanceRelay_34938A_OpenedΩ=1E9|ResistanceRelay_34939A_ClosedΩ=3|ResistanceRelay_34939A_OpenedΩ=1E9|AccuracyDAC_34952A_VDC=0.1"));

            TestIndices.Method.Event = TestMethods.DiagnosticsT<MSMU_34980A_SCPI_NET>(((MethodCustom)TestIndices.Method).Parameters);
            return TestIndices.Method.LogFetchAndClear();
        }
    }

    internal class PowerSupplies {
        internal static String PS_E3634A() {
			Debug.Assert(TestIndices.TestGroup.Assert(Classname: "PowerSupplies", Description: "Keysight E3634As & E3649As.", CancelNotPassed: "false", Independent: "true", Methods: "PS_E3634A|PS_E3649A"));
			Debug.Assert(((MethodCustom)TestIndices.Method).Assert(Name: "PS_E3634A", Description: "Keysight E3634A Power Supplies.", CancelNotPassed: "false", Parameters: "Accuracy_E3634A_VDC=0.1"));

            TestIndices.Method.Event = TestMethods.DiagnosticsT<PS_E3634A_SCPI_NET>(((MethodCustom)TestIndices.Method).Parameters);
            return TestIndices.Method.LogFetchAndClear();
        }

        internal static String PS_E3649A() {
			Debug.Assert(((MethodCustom)TestIndices.Method).Assert(Name: "PS_E3649A", Description: "Keysight E3649A Power Supplies.", CancelNotPassed: "false", Parameters: "Accuracy_E3649A_VDC=0.1"));

            TestIndices.Method.Event = TestMethods.DiagnosticsT<PS_E3649A_SCPI_NET>(((MethodCustom)TestIndices.Method).Parameters);
            return TestIndices.Method.LogFetchAndClear();
        }
    }

    internal class DigitalMultiMeters {
        internal static String MM_34401A() {
			Debug.Assert(TestIndices.TestGroup.Assert(Classname: "DigitalMultiMeters", Description: "Keysight 34401As.", CancelNotPassed: "false", Independent: "true", Methods: "MM_34401A"));
			Debug.Assert(((MethodCustom)TestIndices.Method).Assert(Name: "MM_34401A", Description: "Keysight 34401A Digital Multi-Meters.", CancelNotPassed: "false"));

            TestIndices.Method.Event = TestMethods.DiagnosticsT<MM_34401A_SCPI_NET>(((MethodCustom)TestIndices.Method).Parameters);
            return TestIndices.Method.LogFetchAndClear();
        }
    }

    internal class Oscilloscopes {
        internal static String MSO_3014() {
			Debug.Assert(TestIndices.TestGroup.Assert(Classname: "Oscilloscopes", Description: "Tektronix MSO-3014s.", CancelNotPassed: "false", Independent: "true", Methods: "MSO_3014"));
			Debug.Assert(((MethodCustom)TestIndices.Method).Assert(Name: "MSO_3014", Description: "Tektronix MSO-3014 Mixed-Signal Oscilloscopes.", CancelNotPassed: "false"));

            TestIndices.Method.Event = TestMethods.DiagnosticsT<MSO_3014_IVI_COM>(((MethodCustom)TestIndices.Method).Parameters);
            return TestIndices.Method.LogFetchAndClear();
        }
    }

    internal class WaveformGenerators {
        internal static String WG_33120A() {
			Debug.Assert(TestIndices.TestGroup.Assert(Classname: "WaveformGenerators", Description: "Keysight 33120As.", CancelNotPassed: "false", Independent: "true", Methods: "WG_33120A"));
			Debug.Assert(((MethodCustom)TestIndices.Method).Assert(Name: "WG_33120A", Description: "Keysight 33120A 15MHz Function/Arbitrary Waveform Generators.", CancelNotPassed: "false"));

            TestIndices.Method.Event = TestMethods.DiagnosticsT<SCPI_NET>(((MethodCustom)TestIndices.Method).Parameters);
            if (TestIndices.Method.Event != EVENTS.INFORMATION) { // No SCPI_NET instruments defined in TestPlanDefinition.xml.
                IA.WG.Transport.Command.Invoke("APPLy:SQUare 10E+6, 5.0, -2.5");
                _ = MessageBox.Show("Press OK to continue.", "Waveform Generator", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            return TestIndices.Method.LogFetchAndClear();
        }
    }
}
