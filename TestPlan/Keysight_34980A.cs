namespace ABT.Test.TestPlans.Diagnostics.TestPlan.Keysight_34980A {
    using ABT.Test.TestExecutive.TestLib;
    using ABT.Test.TestExecutive.TestLib.Configuration;
    using ABT.Test.TestExecutive.TestLib.InstrumentDrivers.Multifunction;
    using System;
    using System.Diagnostics;

    internal class Keysight_34921As {
        internal static String Keysight_34921A() {
            if (TestLib.testSequence.IsOperation) Debug.Assert(TestIndices.TestOperation.Assert(NamespaceTrunk: "Keysight_34980A", ProductionTest: "false", Description: "Keysight 34980A Module Tests.", TestGroups: "Keysight_34921As|Keysight_34932As|Keysight_34938As|Keysight_34939As|Keysight_34952As"));
            Debug.Assert(TestIndices.TestGroup.Assert(Classname: "Keysight_34921As", Description: "Keysight 34921A Modules.", CancelNotPassed: "false", Independent: "true", Methods: "Keysight_34921A"));
            Debug.Assert(((MethodCustom)TestIndices.Method).Assert(Name: "Keysight_34921A", Description: "Keysight 34921A 40-Channel Armature Multiplexer.", CancelNotPassed: "false", Parameters: "ModuleType=34921A|FRTD_34921A_Low°C=15.5|FRTD_34921A_High°C=32.2|ResistanceRelay_34921A_ClosedΩ=3|ResistanceRelay_34921A_OpenedΩ=1E9|Current_34921A_LowADC=0.075|Current_34921A_HighADC=0.125"));

            TestIndices.Method.Event = TestMethods.DiagnosticsT<MSMU_34980A_SCPI_NET>(((MethodCustom)TestIndices.Method).Parameters);
            return TestIndices.Method.LogFetchAndClear();
        }
    }

    internal class Keysight_34932As {

        internal static String Keysight_34932A() {
            Debug.Assert(TestIndices.TestGroup.Assert(Classname: "Keysight_34932As", Description: "Keysight 34932A Modules.", CancelNotPassed: "false", Independent: "true", Methods: "Keysight_34932A"));
            Debug.Assert(((MethodCustom)TestIndices.Method).Assert(Name: "Keysight_34932A", Description: "Keysight 34032A Dual 4x16 Armature Matrix.", CancelNotPassed: "false", Parameters: "ModuleType=34932A|ResistanceRelay_34932A_ClosedΩ=3|ResistanceRelay_34932A_OpenedΩ=1E9"));

            TestIndices.Method.Event = TestMethods.DiagnosticsT<MSMU_34980A_SCPI_NET>(((MethodCustom)TestIndices.Method).Parameters);
            return TestIndices.Method.LogFetchAndClear();
        }
    }

    internal class Keysight_34938As {

        internal static String Keysight_34938A() {
            Debug.Assert(TestIndices.TestGroup.Assert(Classname: "Keysight_34938As", Description: "Keysight 34938A Modules.", CancelNotPassed: "false", Independent: "true", Methods: "Keysight_34938A"));
            Debug.Assert(((MethodCustom)TestIndices.Method).Assert(Name: "Keysight_34938A", Description: "Keysight 34938A 20-Channel 5 Amp Form A General Purpose Switch Module.", CancelNotPassed: "false", Parameters: "ModuleType=34938A|ResistanceRelay_34938A_ClosedΩ=3|ResistanceRelay_34938A_OpenedΩ=1E9"));

            TestIndices.Method.Event = TestMethods.DiagnosticsT<MSMU_34980A_SCPI_NET>(((MethodCustom)TestIndices.Method).Parameters);
            return TestIndices.Method.LogFetchAndClear();
        }
    }

    internal class Keysight_34939As {

        internal static String Keysight_34939A() {
            Debug.Assert(TestIndices.TestGroup.Assert(Classname: "Keysight_34939As", Description: "Keysight 34939A Modules.", CancelNotPassed: "false", Independent: "true", Methods: "Keysight_34939A"));
            Debug.Assert(((MethodCustom)TestIndices.Method).Assert(Name: "Keysight_34939A", Description: "Keysight 34939A 64-Channel 1 Amp Form A General Purpose Switch Module.", CancelNotPassed: "false", Parameters: "ModuleType=34939A|ResistanceRelay_34939A_ClosedΩ=3|ResistanceRelay_34939A_OpenedΩ=1E9"));

            TestIndices.Method.Event = TestMethods.DiagnosticsT<MSMU_34980A_SCPI_NET>(((MethodCustom)TestIndices.Method).Parameters);
            return TestIndices.Method.LogFetchAndClear();
        }
    }

    internal class Keysight_34952As {

        internal static String Keysight_34952A() {
            Debug.Assert(TestIndices.TestGroup.Assert(Classname: "Keysight_34952As", Description: "Keysight 34952A Modules.", CancelNotPassed: "false", Independent: "true", Methods: "Keysight_34952A"));
            Debug.Assert(((MethodCustom)TestIndices.Method).Assert(Name: "Keysight_34952A", Description: "Keysight 34952A Multifunction Module.", CancelNotPassed: "false", Parameters: "ModuleType=34952A|AccuracyDAC_34952A_VDC=0.1"));

            TestIndices.Method.Event = TestMethods.DiagnosticsT<MSMU_34980A_SCPI_NET>(((MethodCustom)TestIndices.Method).Parameters);
            return TestIndices.Method.LogFetchAndClear();
        }
    }
}
