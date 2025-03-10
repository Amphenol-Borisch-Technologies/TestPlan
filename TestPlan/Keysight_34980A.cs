namespace ABT.Test.TestPlans.Diagnostics.TestPlan.Keysight_34980A {
    using System;
    using System.Diagnostics;
    using ABT.Test.TestLib;
    using ABT.Test.TestLib.Configuration;
    using static ABT.Test.TestLib.Data;
    using static ABT.Test.TestLib.Configuration.Assertions;
    
    
    internal class Keysight_34921As {
        
        internal static String Keysight_34921A() {
			if (Data.testSequence.IsOperation) Debug.Assert(TestOperation(NamespaceTrunk: "Keysight_34980A", ProductionTest: "false", Description: "Keysight 34980A Module Tests.", TestGroups: "Keysight_34921As|Keysight_34932As|Keysight_34938As|Keysight_34952As"));
			Debug.Assert(TestGroup(Classname: "Keysight_34921As", Description: "Keysight 34921A Modules.", CancelNotPassed: "false", Independent: "true", Methods: "Keysight_34921A"));
			Debug.Assert(MethodCustom(Name: "Keysight_34921A", Description: "Keysight 34921A 40-Channel Armature Multiplexer.", CancelNotPassed: "false"));
			TestIndices.Method.Event = EVENTS.UNSET;
			return String.Empty;
        }
    }
    
    internal class Keysight_34932As {
        
        internal static String Keysight_34932A() {
			Debug.Assert(TestGroup(Classname: "Keysight_34932As", Description: "Keysight 34932A Modules.", CancelNotPassed: "false", Independent: "true", Methods: "Keysight_34932A"));
			Debug.Assert(MethodCustom(Name: "Keysight_34932A", Description: "Keysight 34032A Dual 4x16 Armature Matrix.", CancelNotPassed: "false"));
			TestIndices.Method.Event = EVENTS.UNSET;
			return String.Empty;
        }
    }
    
    internal class Keysight_34938As {
        
        internal static String Keysight_34938A() {
			Debug.Assert(TestGroup(Classname: "Keysight_34938As", Description: "Keysight 34938A Modules.", CancelNotPassed: "false", Independent: "true", Methods: "Keysight_34938A"));
			Debug.Assert(MethodCustom(Name: "Keysight_34938A", Description: "Keysight 34938A 20-Channel High-Current GP Switch Module.", CancelNotPassed: "false"));
			TestIndices.Method.Event = EVENTS.UNSET;
			return String.Empty;
        }
    }
    
    internal class Keysight_34952As {
        
        internal static String Keysight_34952A() {
			Debug.Assert(TestGroup(Classname: "Keysight_34952As", Description: "Keysight 34952A Modules.", CancelNotPassed: "false", Independent: "true", Methods: "Keysight_34952A"));
			Debug.Assert(MethodCustom(Name: "Keysight_34952A", Description: "Keysight 34952A Multifunction Module.", CancelNotPassed: "false"));
			TestIndices.Method.Event = EVENTS.UNSET;
			return String.Empty;
        }
    }
}
