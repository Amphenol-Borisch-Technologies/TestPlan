namespace ABT.Test.TestPlans.Diagnostics.InstrumentDrivers {
    using ABT.Test.TestExecutive.TestLib;
    using ABT.Test.TestExecutive.TestLib.InstrumentDrivers.Generic;
    using ABT.Test.TestExecutive.TestLib.InstrumentDrivers.Multifunction;
    using ABT.Test.TestExecutive.TestLib.InstrumentDrivers.MultiMeters;
    using ABT.Test.TestExecutive.TestLib.InstrumentDrivers.Oscilloscopes;
    using ABT.Test.TestExecutive.TestLib.InstrumentDrivers.PowerSupplies;

    internal static class IA { // Instrument Aliases.
        internal static MSMU_34980A_SCPI_NET MSMU = ((MSMU_34980A_SCPI_NET)(TestLib.InstrumentDrivers["MSMU1_34980A"]));
        internal static PS_E3649A_SCPI_NET P12V_N12V = ((PS_E3649A_SCPI_NET)(TestLib.InstrumentDrivers["PS1ε2_E3649A"]));
        internal static PS_E3634A_SCPI_NET P28V = ((PS_E3634A_SCPI_NET)(TestLib.InstrumentDrivers["PS3_E3634A"]));
        internal static MSO_3014_IVI_COM MSO = ((MSO_3014_IVI_COM)(TestLib.InstrumentDrivers["MSO1_3014"]));
        internal static MM_34401A_SCPI_NET MM = ((MM_34401A_SCPI_NET)(TestLib.InstrumentDrivers["MM1_34401A_SCPI_NET"]));
        internal static SCPI_NET WG = ((SCPI_NET)(TestLib.InstrumentDrivers["WG1_33120A"]));
    }
}
