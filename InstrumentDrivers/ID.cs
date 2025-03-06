namespace ABT.Test.TestPlans.Diagnostics.InstrumentDrivers {
    using ABT.Test.TestLib.InstrumentDrivers.Generic;
    using ABT.Test.TestLib.InstrumentDrivers.Multifunction;
    using ABT.Test.TestLib.InstrumentDrivers.Oscilloscopes;
    using ABT.Test.TestLib.InstrumentDrivers.PowerSupplies;
    
    internal static class ID {
        internal static MSMU_34980A_SCPI_NET MSMU = ((MSMU_34980A_SCPI_NET)(TestLib.Data.InstrumentDrivers["MSMU1_34980A"]));
        internal static PS_E3649A_SCPI_NET P12V_N12V = ((PS_E3649A_SCPI_NET)(TestLib.Data.InstrumentDrivers["PS1ε2_E3649A"]));
        internal static PS_E3634A_SCPI_NET P28V = ((PS_E3634A_SCPI_NET)(TestLib.Data.InstrumentDrivers["PS3_E3634A"]));
        internal static MSO_3014_IVI_COM MSO = ((MSO_3014_IVI_COM)(TestLib.Data.InstrumentDrivers["MSO1_3014"]));
        internal static SCPI_NET WG = ((SCPI_NET)(TestLib.Data.InstrumentDrivers["WG1_33120A"]));
    }
}
