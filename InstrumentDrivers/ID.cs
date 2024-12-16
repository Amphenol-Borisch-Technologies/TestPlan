using ABT.Test.TestLib.InstrumentDrivers.Multifunction;
using ABT.Test.TestLib.InstrumentDrivers.PowerSupplies;

namespace ABT.Test.TestPlans.Diagnostics.InstrumentsDrivers {
    internal static class ID {
        internal static PS_E3634A_SCPI_NET   V28_IN = ((PS_E3634A_SCPI_NET)TestLib.TestLib.InstrumentDrivers["PS3_E3634A"]);
        internal static PS_E3649A_SCPI_NET   SEAL   = ((PS_E3649A_SCPI_NET)TestLib.TestLib.InstrumentDrivers["PS1ε2_E3649A"]);
     // internal static MSO_3014_IVI_COM     MSO    = ((MSO_3014_IVI_COM)TestLib.TestLib.InstrumentDrivers["MSO1_3014"]);
        internal static MSMU_34980A_SCPI_NET MSMU   = ((MSMU_34980A_SCPI_NET)TestLib.TestLib.InstrumentDrivers["MSMU1_34980A"]);
     // internal static MM_34401A_SCPI_NET   MM     = ((MM_34401A_SCPI_NET)TestLib.TestLib.InstrumentDrivers["MM1_34401A"]);
    }
}
