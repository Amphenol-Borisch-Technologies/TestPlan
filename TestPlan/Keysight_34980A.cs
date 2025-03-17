namespace ABT.Test.TestPlans.Diagnostics.TestPlan.Keysight_34980A {
    using System;
    using System.Diagnostics;
    using ABT.Test.TestLib;
    using ABT.Test.TestLib.Configuration;
    using ABT.Test.TestLib.InstrumentDrivers.Multifunction;
    using static ABT.Test.TestLib.Configuration.Assertions;
    using static ABT.Test.TestPlans.Diagnostics.TestPlan.InstrumentsTestPlan.TestMethods;

    internal class Keysight_34921As {
        internal static String Keysight_34921A() {
			if (Data.testSequence.IsOperation) Debug.Assert(TestOperation(NamespaceTrunk: "Keysight_34980A", ProductionTest: "false", Description: "Keysight 34980A Module Tests.", TestGroups: "Keysight_34921As|Keysight_34932As|Keysight_34938As|Keysight_34952As"));
			Debug.Assert(TestGroup(Classname: "Keysight_34921As", Description: "Keysight 34921A Modules.", CancelNotPassed: "false", Independent: "true", Methods: "Keysight_34921A"));
			Debug.Assert(MethodCustom(Name: "Keysight_34921A", Description: "Keysight 34921A 40-Channel Armature Multiplexer.", CancelNotPassed: "false"));

            TestIndices.Method.Event = DiagnosticsT<MSMU_34980A_SCPI_NET>(((MethodCustom)TestIndices.Method).Parameters);
            return TestIndices.Method.LogFetchAndClear();
        }
    }
    
    internal class Keysight_34932As {
        
        internal static String Keysight_34932A() {
			Debug.Assert(TestGroup(Classname: "Keysight_34932As", Description: "Keysight 34932A Modules.", CancelNotPassed: "false", Independent: "true", Methods: "Keysight_34932A"));
			Debug.Assert(MethodCustom(Name: "Keysight_34932A", Description: "Keysight 34032A Dual 4x16 Armature Matrix.", CancelNotPassed: "false"));

            TestIndices.Method.Event = DiagnosticsT<MSMU_34980A_SCPI_NET>(((MethodCustom)TestIndices.Method).Parameters);
            return TestIndices.Method.LogFetchAndClear();
        }
    }
    
    internal class Keysight_34938As {
        
        internal static String Keysight_34938A() {
			Debug.Assert(TestGroup(Classname: "Keysight_34938As", Description: "Keysight 34938A Modules.", CancelNotPassed: "false", Independent: "true", Methods: "Keysight_34938A"));
			Debug.Assert(MethodCustom(Name: "Keysight_34938A", Description: "Keysight 34938A 20-Channel 5 Amp Form A General Purpose Switch Module.", CancelNotPassed: "false"));

            TestIndices.Method.Event = DiagnosticsT<MSMU_34980A_SCPI_NET>(((MethodCustom)TestIndices.Method).Parameters);
            return TestIndices.Method.LogFetchAndClear();
        }
    }
    
    internal class Keysight_34939As {
        
        internal static String Keysight_34939A() {
			Debug.Assert(TestGroup(Classname: "Keysight_34930As", Description: "Keysight 34939A Modules.", CancelNotPassed: "false", Independent: "true", Methods: "Keysight_34939A"));
			Debug.Assert(MethodCustom(Name: "Keysight_34939A", Description: "Keysight 34939A 64-Channel 1 Amp Form A General Purpose Switch Module.", CancelNotPassed: "false"));

            TestIndices.Method.Event = DiagnosticsT<MSMU_34980A_SCPI_NET>(((MethodCustom)TestIndices.Method).Parameters);
            return TestIndices.Method.LogFetchAndClear();
        }
    }
    
    internal class Keysight_34952As {
        
        internal static String Keysight_34952A() {
			Debug.Assert(TestGroup(Classname: "Keysight_34952As", Description: "Keysight 34952A Modules.", CancelNotPassed: "false", Independent: "true", Methods: "Keysight_34952A"));
			Debug.Assert(MethodCustom(Name: "Keysight_34952A", Description: "Keysight 34952A Multifunction Module.", CancelNotPassed: "false"));

            TestIndices.Method.Event = DiagnosticsT<MSMU_34980A_SCPI_NET>(((MethodCustom)TestIndices.Method).Parameters);
            return TestIndices.Method.LogFetchAndClear();
        }
    }
}
