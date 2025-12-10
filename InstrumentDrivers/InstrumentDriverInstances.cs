namespace ABT.Test.TestPlans.Diagnostics.InstrumentDrivers {
    using ABT.Test.TestExecutive.TestLib;
    using ABT.Test.TestExecutive.TestLib.InstrumentDrivers.Multifunction;
    using ABT.Test.TestExecutive.TestLib.InstrumentDrivers.Oscilloscopes;
    using ABT.Test.TestExecutive.TestLib.InstrumentDrivers.PowerSupplies;
    using System;

    internal class InstrumentDriverInstances {
        internal MSMU_34980A_SCPI_NET MSMU = ((MSMU_34980A_SCPI_NET)(TestLib.InstrumentDrivers["MSMU1_34980A"]));
        internal MSO_3014_VISA_NET MSO = ((MSO_3014_VISA_NET)(TestLib.InstrumentDrivers["MSO1_3014"]));
        internal PS_E3634A_SCPI_NET P28V = ((PS_E3634A_SCPI_NET)(TestLib.InstrumentDrivers["PS3_E3634A"]));
        internal PS_E3649A_SCPI_NET P12V_N12V = ((PS_E3649A_SCPI_NET)(TestLib.InstrumentDrivers["PS1ε2_E3649A"]));
        //internal MM_34401A_SCPI_NET MM = ((MM_34401A_SCPI_NET)(TestLib.InstrumentDrivers["MM1_34401A_SCPI_NET"]));
        //internal SCPI_NET WG = ((SCPI_NET)(TestLib.InstrumentDrivers["WG1_33120A"]));
    }

    internal static class ID {
        internal static readonly Lazy<InstrumentDriverInstances> I = new Lazy<InstrumentDriverInstances>(() => new InstrumentDriverInstances());
    }
}
