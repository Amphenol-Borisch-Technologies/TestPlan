using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Channels;
using System.Threading.Channels;
using System.Windows.Forms;
using ABT.TestExec.Exec;
using ABT.TestExec.Lib;
using ABT.TestExec.Lib.AppConfig;
using ABT.TestExec.Lib.InstrumentDrivers;
using ABT.TestExec.Lib.InstrumentDrivers.Interfaces;
using ABT.TestExec.Lib.InstrumentDrivers.Multifunction;
using ABT.TestExec.Lib.InstrumentDrivers.MultiMeters;
using ABT.TestExec.Tests.Diagnostics.InstrumentsDrivers;
using Windows.UI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static ABT.TestExec.Lib.InstrumentDrivers.Multifunction.MSMU_34980A_SCPI_NET;

namespace ABT.TestExec.Tests.Diagnostics.TestOperations {
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

        internal static String Diagnostics_MSMU_34980A_SCPI_NET() {
            Dictionary<String, MSMU_34980A_SCPI_NET> msmu_34980a_scpi_net = TestLib.InstrumentDrivers.Where(kvp => kvp.Value is MSMU_34980A_SCPI_NET).ToDictionary(kvp => kvp.Key, kvp => (MSMU_34980A_SCPI_NET)kvp.Value);
            if (msmu_34980a_scpi_net.Count() == 0) return EVENTS.UNSET.ToString();

            Boolean passedIndividual;
            Boolean passedCollective = true;
            foreach (KeyValuePair<String, MSMU_34980A_SCPI_NET> kvp in msmu_34980a_scpi_net) {
                passedIndividual = kvp.Value.SelfTests() is SELF_TEST_RESULTS.PASS;
                passedCollective &= passedIndividual;
                if (passedIndividual) { // Skip extended diagnostics if self-test failed.
                    (Boolean Passed, String Message) diagnosticsExtended = Diagnostics_MSMU_34980A_SCPI_NET_Extended(kvp.Key, kvp.Value);
                    passedCollective &= diagnosticsExtended.Passed;
                    TestPlan.Only.MessageFormat(Label: $"Channel {channel}: ", Message: $"{Math.Round(resistance[0], MN.FD, MidpointRounding.ToEven)}Ω");
                }
            }
            TestPlan.Only.MessageAppendLine(Label: $"Channel {channel}: ", Message: $"{Math.Round(resistance[0], MN.FD, MidpointRounding.ToEven)}Ω");
            return passedCollective ? EVENTS.PASS.ToString() : EVENTS.FAIL.ToString();
        }

        internal static (Boolean Passed, String Message) Diagnostics_MSMU_34980A_SCPI_NET_Extended(String ID, MSMU_34980A_SCPI_NET msmu) {
            msmu.SCPI.INSTrument.DMM.INSTalled.Query(out Boolean installed);
            if (!installed) {
                _ = MessageBox.Show("No internal DMM, skipping Extended Diagnostics.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return (true, String.Empty);
            }

            foreach (SLOTS slot in Enum.GetValues(typeof(SLOTS))) {
                switch(msmu.SystemType(slot)) {
                    case "34921A":
                        msmu.Diagnostics_34921A(slot);
                        break;
                    case "34922A":
                        break;
                    case "34932A":
                        break;
                    case "34938A":
                        break;
                    case "34939A":
                        break;
                    case "34952A":
                        break;
                    default:
                        throw new NotImplementedException(
                            $"Diagnostics test for module '{msmu.SystemType(slot)}' unimplemented!{Environment.NewLine}{Environment.NewLine}" +
                            $"ID:      '{ID}'.{Environment.NewLine}" +
                            $"Address: '{msmu.Address}'.{Environment.NewLine}" +
                            $"Detail:  '{msmu.Detail}'.{Environment.NewLine}");
                }
            }
            return (false, String.Empty);
        }
    }
        #endregion GroupID MSMU_34980A
}

