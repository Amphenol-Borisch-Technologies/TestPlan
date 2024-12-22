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
    using static ABT.Test.TestLib.TestSpec.Assertions;
    
    
    internal class TestMeasurements {
        
        static string MSMU_34980A() {
			Debug.Assert(TO(NamespaceLeaf: "SCPI_VISA_Instruments", Description: "Diagnostics, SCPI VISA Instruments.", TestGroups: "TestMeasurements"));
			Debug.Assert(TG_Prior(Class: "NONE"));
			Debug.Assert(TG(Class: "TestMeasurements", Description: "Diagnostics Measurements.", CancelIfFail: "true", Independent: "true", Methods: "MSMU_34980A|MM_34401A|MSO_3014|PS_E3634A|PS_E3649A"));
			Debug.Assert(TG_Next(Class: "NONE"));
			Debug.Assert(M_Prior(Method: "NONE"));
			Debug.Assert(MC(Method: "MSMU_34980A", Description: "Keysight 34980A Multifunction Switch/Measurement Units.", CancelIfFail: "true"));
			Debug.Assert(M_Next(Method: "MM_34401A"));
			return String.Empty;
        }
        
        static string MM_34401A() {
			Debug.Assert(M_Prior(Method: "MSMU_34980A"));
			Debug.Assert(MC(Method: "MM_34401A", Description: "Keysight 34401A Digital Multi-Meters.", CancelIfFail: "true"));
			Debug.Assert(M_Next(Method: "MSO_3014"));
			return String.Empty;
        }
        
        static string MSO_3014() {
			Debug.Assert(M_Prior(Method: "MM_34401A"));
			Debug.Assert(MC(Method: "MSO_3014", Description: "Tektronix MSO-3014 Mixed-Signal Oscilloscopes.", CancelIfFail: "true"));
			Debug.Assert(M_Next(Method: "PS_E3634A"));
			return String.Empty;
        }
        
        static string PS_E3634A() {
			Debug.Assert(M_Prior(Method: "MSO_3014"));
			Debug.Assert(MC(Method: "PS_E3634A", Description: "Keysight E3634A Power Supplies.", CancelIfFail: "true"));
			Debug.Assert(M_Next(Method: "PS_E3649A"));
			return String.Empty;
        }
        
        static string PS_E3649A() {
			Debug.Assert(M_Prior(Method: "PS_E3634A"));
			Debug.Assert(MC(Method: "PS_E3649A", Description: "Keysight E3649A Power Supplies.", CancelIfFail: "true"));
			Debug.Assert(M_Next(Method: "NONE"));
			return String.Empty;
        }
    }
}
namespace ABT.Test.TestPlans.Diagnostics.TestOperations.Miscellaneous {
    using System;
    using System.Diagnostics;
    using static ABT.Test.TestLib.TestSpec.Assertions;
    
    
    internal class USB_ERB24 {
        
        static string USB_ERB24_SelfTest() {
			Debug.Assert(TO(NamespaceLeaf: "Miscellaneous", Description: "Miscellaneous items, including instruments that aren\'t both SCPI & VISA instruments.", TestGroups: "USB_ERB24"));
			Debug.Assert(TG_Prior(Class: "NONE"));
			Debug.Assert(TG(Class: "USB_ERB24", Description: "USB_ERB24 Relays.", CancelIfFail: "true", Independent: "true", Methods: "USB_ERB24_SelfTest"));
			Debug.Assert(TG_Next(Class: "NONE"));
			Debug.Assert(M_Prior(Method: "NONE"));
			Debug.Assert(MC(Method: "USB_ERB24_SelfTest", Description: "USB_ERB24 Diagnostics.", CancelIfFail: "true"));
			Debug.Assert(M_Next(Method: "NONE"));
			return String.Empty;
        }
    }
}
