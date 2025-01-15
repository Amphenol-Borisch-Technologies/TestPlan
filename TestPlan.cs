//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ABT.Test.TestPlans.Diagnostics.TestOperations.SCPI_VISA_Instruments {
    using System;
    using System.Diagnostics;
    using ABT.Test.TestLib;
    using ABT.Test.TestLib.TestConfiguration;
    using static ABT.Test.TestLib.TestLib;
    using static ABT.Test.TestLib.TestConfiguration.Assertions;
    
    
    internal class TestMethodsNew {
        
        internal static string MM_34401A() {
			if (TestLib.testSequence.IsOperation) Debug.Assert(TestOperation(NamespaceTrunk: "SCPI_VISA_Instruments", Description: "Diagnostics, SCPI VISA Instruments.", TestGroups: "TestMethods"));
			Debug.Assert(TestGroupPrior(Classname: NONE));
			Debug.Assert(TestGroup(Classname: "TestMethods", Description: "Diagnostics.", CancelNotPassed: "false", Independent: "true", Methods: "MM_34401A|MSO_3014|PS_E3634A|PS_E3649A|MSMU_34980A"));
			Debug.Assert(TestGroupNext(Classname: NONE));
			Debug.Assert(MethodPrior(Name: NONE));
			Debug.Assert(MethodCustom(Name: "MM_34401A", Description: "Keysight 34401A Digital Multi-Meters.", CancelNotPassed: "false"));
			Debug.Assert(MethodNext(Name: "MSO_3014"));
			return nameof(EVENTS.UNSET);
        }
        
        internal static string MSO_3014() {
			Debug.Assert(MethodPrior(Name: "MM_34401A"));
			Debug.Assert(MethodCustom(Name: "MSO_3014", Description: "Tektronix MSO-3014 Mixed-Signal Oscilloscopes.", CancelNotPassed: "false"));
			Debug.Assert(MethodNext(Name: "PS_E3634A"));
			return nameof(EVENTS.UNSET);
        }
        
        internal static string PS_E3634A() {
			Debug.Assert(MethodPrior(Name: "MSO_3014"));
			Debug.Assert(MethodCustom(Name: "PS_E3634A", Description: "Keysight E3634A Power Supplies.", CancelNotPassed: "false"));
			Debug.Assert(MethodNext(Name: "PS_E3649A"));
			return nameof(EVENTS.UNSET);
        }
        
        internal static string PS_E3649A() {
			Debug.Assert(MethodPrior(Name: "PS_E3634A"));
			Debug.Assert(MethodCustom(Name: "PS_E3649A", Description: "Keysight E3649A Power Supplies.", CancelNotPassed: "false"));
			Debug.Assert(MethodNext(Name: "MSMU_34980A"));
			return nameof(EVENTS.UNSET);
        }
        
        internal static string MSMU_34980A() {
			Debug.Assert(MethodPrior(Name: "PS_E3649A"));
			Debug.Assert(MethodCustom(Name: "MSMU_34980A", Description: "Keysight 34980A Multifunction Switch/Measurement Units.", CancelNotPassed: "false"));
			Debug.Assert(MethodNext(Name: NONE));
			return nameof(EVENTS.UNSET);
        }
    }
}
namespace ABT.Test.TestPlans.Diagnostics.TestOperations.Miscellaneous {
    using System;
    using System.Diagnostics;
    using ABT.Test.TestLib;
    using ABT.Test.TestLib.TestConfiguration;
    using static ABT.Test.TestLib.TestLib;
    using static ABT.Test.TestLib.TestConfiguration.Assertions;
    
    
    internal class MoreMethodsNew {
        
        internal static string MoreMM_34401A() {
			if (TestLib.testSequence.IsOperation) Debug.Assert(TestOperation(NamespaceTrunk: "Miscellaneous", Description: "Miscellaneous items, including instruments that aren\'t both SCPI & VISA instruments.", TestGroups: "MoreMethods"));
			Debug.Assert(TestGroupPrior(Classname: NONE));
			Debug.Assert(TestGroup(Classname: "MoreMethods", Description: "Diagnostics.", CancelNotPassed: "false", Independent: "true", Methods: "MoreMM_34401A|MoreMSO_3014|MorePS_E3634A|MorePS_E3649A|MoreMSMU_34980A"));
			Debug.Assert(TestGroupNext(Classname: NONE));
			Debug.Assert(MethodPrior(Name: NONE));
			Debug.Assert(MethodProcess(Name: "MoreMM_34401A", Description: "Keysight 34401A Digital Multi-Meters.", CancelNotPassed: "false", Folder: "C:\\Test", File: "Temp.exe", Parameters: "", Expected: "0"));
			Debug.Assert(MethodNext(Name: "MoreMSO_3014"));
			return "-1";
        }
        
        internal static string MoreMSO_3014() {
			Debug.Assert(MethodPrior(Name: "MoreMM_34401A"));
			Debug.Assert(MethodTextual(Name: "MoreMSO_3014", Description: "Tektronix MSO-3014 Mixed-Signal Oscilloscopes.", CancelNotPassed: "false", Text: "Hi There!"));
			Debug.Assert(MethodNext(Name: "MorePS_E3634A"));
			return "";
        }
        
        internal static string MorePS_E3634A() {
			Debug.Assert(MethodPrior(Name: "MoreMSO_3014"));
			Debug.Assert(MethodCustom(Name: "MorePS_E3634A", Description: "Keysight E3634A Power Supplies.", CancelNotPassed: "false"));
			Debug.Assert(MethodNext(Name: "MorePS_E3649A"));
			return nameof(EVENTS.UNSET);
        }
        
        internal static string MorePS_E3649A() {
			Debug.Assert(MethodPrior(Name: "MorePS_E3634A"));
			Debug.Assert(MethodCustom(Name: "MorePS_E3649A", Description: "Keysight E3649A Power Supplies.", CancelNotPassed: "false", Parameters: "Key1=Value1|Key2=Value2|Key3=Value3"));
			Debug.Assert(MethodNext(Name: "MoreMSMU_34980A"));
			return nameof(EVENTS.UNSET);
        }
        
        internal static string MoreMSMU_34980A() {
			Debug.Assert(MethodPrior(Name: "MorePS_E3649A"));
			Debug.Assert(MethodInterval(Name: "MoreMSMU_34980A", Description: "Keysight 34980A Multifunction Switch/Measurement Units.", CancelNotPassed: "false", LowComparator: "GToE", Low: "5", High: "10", HighComparator: "LT", FractionalDigits: "2", UnitPrefix: "NONE", Units: "NONE", UnitSuffix: "NONE"));
			Debug.Assert(MethodNext(Name: NONE));
			return "NaN";
        }
    }
}
