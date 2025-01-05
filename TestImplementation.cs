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
    using static ABT.Test.TestLib.TestConfiguration.Assertions;
    
    
    internal class TestMeasurements {
        
        internal static string MSMU_34980A() {
			Debug.Assert(TestOperation(NamespaceTrunk: "SCPI_VISA_Instruments", Description: "Diagnostics, SCPI VISA Instruments.", TestGroups: "TestMeasurements|MoreMeasurements"));
			Debug.Assert(TestGroupPrior(Class: "NONE"));
			Debug.Assert(TestGroup(Class: "TestMeasurements", Description: "Diagnostics Measurements.", CancelNotPassed: "false", Independent: "true", Methods: "MSMU_34980A|MM_34401A|MSO_3014|PS_E3634A|PS_E3649A"));
			Debug.Assert(TestGroupNext(Class: "MoreMeasurements"));
			Debug.Assert( MethodPrior ( Name :  "NONE"));
			Debug.Assert(MethodCustom(Name: "MSMU_34980A", Description: "Keysight 34980A Multifunction Switch/Measurement Units.", CancelNotPassed: "false"));
			Debug.Assert(MethodNext(Name: "MM_34401A"));
			return "EVENTS.UNSET";
        }
        
        internal static string MM_34401A() {
			Debug.Assert(MethodPrior(Name: "MSMU_34980A"));
			Debug.Assert(MethodCustom(Name: "MM_34401A", Description: "Keysight 34401A Digital Multi-Meters.", CancelNotPassed: "false"));
			Debug.Assert(MethodNext(Name: "MSO_3014"));
			return "EVENTS.UNSET";
        }
        
        internal static string MSO_3014() {
			Debug.Assert(MethodPrior(Name: "MM_34401A"));
			Debug.Assert(MethodCustom(Name: "MSO_3014", Description: "Tektronix MSO-3014 Mixed-Signal Oscilloscopes.", CancelNotPassed: "false"));
			Debug.Assert(MethodNext(Name: "PS_E3634A"));
			return "EVENTS.UNSET";
        }
        
        internal static string PS_E3634A() {
			Debug.Assert(MethodPrior(Name: "MSO_3014"));
			Debug.Assert(MethodCustom(Name: "PS_E3634A", Description: "Keysight E3634A Power Supplies.", CancelNotPassed: "false"));
			Debug.Assert(MethodNext(Name: "PS_E3649A"));
			return "EVENTS.UNSET";
        }
        
        internal static string PS_E3649A() {
			Debug.Assert(MethodPrior(Name: "PS_E3634A"));
			Debug.Assert(MethodCustom(Name: "PS_E3649A", Description: "Keysight E3649A Power Supplies.", CancelNotPassed: "false"));
			Debug.Assert(MethodNext(Name: "NONE"));
			return "EVENTS.UNSET";
        }
    }
    
    internal class MoreMeasurements {
        
        internal static string MoreMSMU_34980A() {
			Debug.Assert(TestGroupPrior(Class: "TestMeasurements"));
			Debug.Assert(TestGroup(Class: "MoreMeasurements", Description: "Diagnostics Measurements.", CancelNotPassed: "false", Independent: "true", Methods: "MoreMSMU_34980A|MoreMM_34401A|MoreMSO_3014|MorePS_E3634A|MorePS_E3649A"));
			Debug.Assert(TestGroupNext(Class: "NONE"));
			Debug.Assert( MethodPrior ( Name :  "NONE"));
			Debug.Assert(MethodCustom(Name: "MoreMSMU_34980A", Description: "Keysight 34980A Multifunction Switch/Measurement Units.", CancelNotPassed: "false"));
			Debug.Assert(MethodNext(Name: "MoreMM_34401A"));
			return "EVENTS.UNSET";
        }
        
        internal static string MoreMM_34401A() {
			Debug.Assert(MethodPrior(Name: "MoreMSMU_34980A"));
			Debug.Assert(MethodCustom(Name: "MoreMM_34401A", Description: "Keysight 34401A Digital Multi-Meters.", CancelNotPassed: "false"));
			Debug.Assert(MethodNext(Name: "MoreMSO_3014"));
			return "EVENTS.UNSET";
        }
        
        internal static string MoreMSO_3014() {
			Debug.Assert(MethodPrior(Name: "MoreMM_34401A"));
			Debug.Assert(MethodCustom(Name: "MoreMSO_3014", Description: "Tektronix MSO-3014 Mixed-Signal Oscilloscopes.", CancelNotPassed: "false"));
			Debug.Assert(MethodNext(Name: "MorePS_E3634A"));
			return "EVENTS.UNSET";
        }
        
        internal static string MorePS_E3634A() {
			Debug.Assert(MethodPrior(Name: "MoreMSO_3014"));
			Debug.Assert(MethodCustom(Name: "MorePS_E3634A", Description: "Keysight E3634A Power Supplies.", CancelNotPassed: "false"));
			Debug.Assert(MethodNext(Name: "MorePS_E3649A"));
			return "EVENTS.UNSET";
        }
        
        internal static string MorePS_E3649A() {
			Debug.Assert(MethodPrior(Name: "MorePS_E3634A"));
			Debug.Assert(MethodCustom(Name: "MorePS_E3649A", Description: "Keysight E3649A Power Supplies.", CancelNotPassed: "false"));
			Debug.Assert(MethodNext(Name: "NONE"));
			return "EVENTS.UNSET";
        }
    }
}
namespace ABT.Test.TestPlans.Diagnostics.TestOperations.Miscellaneous {
    using System;
    using System.Diagnostics;
    using static ABT.Test.TestLib.TestConfiguration.Assertions;
    
    
    internal class USB_ERB24 {
        
        internal static string USB_ERB24_SelfTest() {
			Debug.Assert(TestOperation(NamespaceTrunk: "Miscellaneous", Description: "Miscellaneous items, including instruments that aren\'t both SCPI & VISA instruments.", TestGroups: "USB_ERB24"));
			Debug.Assert(TestGroupPrior(Class: "NONE"));
			Debug.Assert(TestGroup(Class: "USB_ERB24", Description: "USB_ERB24 Relays.", CancelNotPassed: "false", Independent: "true", Methods: "USB_ERB24_SelfTest"));
			Debug.Assert(TestGroupNext(Class: "NONE"));
			Debug.Assert( MethodPrior ( Name :  "NONE"));
			Debug.Assert(MethodCustom(Name: "USB_ERB24_SelfTest", Description: "USB_ERB24 Diagnostics.", CancelNotPassed: "false"));
			Debug.Assert(MethodNext(Name: "NONE"));
			return "EVENTS.UNSET";
        }
    }
}
