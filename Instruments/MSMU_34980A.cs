using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using ABT.Test.Lib;
using ABT.Test.Lib.AppConfig;
using ABT.Test.Lib.InstrumentDrivers.Interfaces;
using ABT.Test.Lib.InstrumentDrivers.Multifunction;
using ABT.Test.Lib.InstrumentDrivers.MultiMeters;
using static ABT.Test.Lib.InstrumentDrivers.Multifunction.MSMU_34980A_SCPI_NET;

namespace ABT.Test.Plans.Diagnostics.Instruments {
    internal static partial class TestMeasurements {
        // NOTE:  Invocable test methods in this class, defined as TestMeasurement IDs in App.config, require signatures like "internal static String MethodName()".
        #region GroupID MSMU_34980A
        internal static String MSMU_34980A() {
            Debug.Assert(TestLib.IsGroup(
                GroupID: "MSMU_34980A",
                Description: "Keysight 34980A Diagnostics.",
                MeasurementIDs: "MSMU_34980A",
                Selectable: true,
                CancelNotPassed: false));
            Debug.Assert(TestLib.IsMeasurement(
                Description: "Keysight 34980A Multifunction Switch/Measurement Units.",
                IDPrior: "MM_34401A",
                IDNext: "MSO_3014",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: false,
                Arguments: "Low=0|High=3|FD=3|Units_SI=ohms|Units_SI_Modifier=NotApplicable"));

            return Diagnostics_MSMU_34980A_SCPI_NET();
        }

        [STAThread] public static void Main() {
            foreach (KeyValuePair<String, Object> kvp in TestLib.InstrumentDrivers) if (kvp.Value is IDiagnostics id) id.Diagnostics();
            MSMU_34980A_SCPI_NET msmu = new MSMU_34980A_SCPI_NET(Address: "GPIB0::2::INSTR", Detail: "Agilent 34980A Multifunction Switch/Measure Unit");
            (Boolean Summary, List<DiagnosticsResult> Details) result_34980A = msmu.Diagnostics();
            Int32 i = 0;
        }

        internal static String Diagnostics_MSMU_34980A_SCPI_NET() {
            Dictionary<String, MSMU_34980A_SCPI_NET> msmu_34980a_scpi_net = TestLib.InstrumentDrivers.Where(kvp => kvp.Value is MSMU_34980A_SCPI_NET).ToDictionary(kvp => kvp.Key, kvp => (MSMU_34980A_SCPI_NET)kvp.Value);
            if (msmu_34980a_scpi_net.Count() == 0) return EVENTS.IGNORE.ToString();

            (Boolean Summary, List<DiagnosticsResult> Details) result_34980A;
            DiagnosticParameter_34980A DP = new DiagnosticParameter_34980A(Ω: 3);
            Boolean passed_34980As = true;
            foreach (KeyValuePair<String, MSMU_34980A_SCPI_NET> kvp in msmu_34980a_scpi_net) {
                result_34980A = kvp.Value.Diagnostics(DP);
                passed_34980As &= result_34980A.Summary;
                TestPlan.Only.MessageAppendLine(Label: $"{nameof(MSMU_34980A)} ID {kvp.Key}:", Message: $"Result: {(result_34980A.Summary ? EVENTS.PASS.ToString() : EVENTS.FAIL.ToString())}");
                foreach (DiagnosticsResult dr in result_34980A.Details) TestPlan.Only.MessageAppendLine(Label: $"{dr.Label}", Message: $"{dr.Message}, {dr.Event}.");
            }
            return passed_34980As ? EVENTS.PASS.ToString() : EVENTS.FAIL.ToString();
        }
    }
        #endregion GroupID MSMU_34980A
}

