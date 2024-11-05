using System;
using System.Diagnostics;
using System.Text;
using System.Threading.Channels;
using System.Windows.Forms;
using ABT.TestExec.Exec;
using ABT.TestExec.Lib;
using ABT.TestExec.Lib.AppConfig;
using ABT.TestExec.Lib.InstrumentDrivers;
using ABT.TestExec.Lib.InstrumentDrivers.Interfaces;
using ABT.TestExec.Tests.Diagnostics.InstrumentsDrivers;
using Windows.Foundation.Metadata;

namespace ABT.TestExec.Tests.Diagnostics.TestOperations {
    internal static partial class TestMeasurements {
        // NOTE:  Invocable test methods in this class, defined as TestMeasurement IDs in App.config, require signatures like "internal static String MethodName()".
        #region GroupID 34921A
        internal static String MUX_34921A_1() {
            if (TestLib.ConfigTest.IsOperation) {
                Debug.Assert(
                    TestLib.IsOperation(
                    OperationID: "Diagnostics",
                    Description: "Keysight 34980A Diagnostics.",
                    Revision: "0",
                    GroupsIDs: "34921A"));
            }
            Debug.Assert(TestLib.IsGroup(
                GroupID: "34921A",
                Description: "Keysight 34921A Diagnostics..",
                MeasurementIDs: "MUX_34921A_1",
                Selectable: true,
                CancelNotPassed: false));
            Debug.Assert(TestLib.IsMeasurement(
                Description: "34921A Slot 1.",
                IDPrior: TestLib.NONE,
                IDNext: "34921A Slot 2.",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));

            ID.MSMU.ResetClear();
            ID.MSMU.SCPI.ROUTe.OPEN.ALL.Command(null);
            ID.MSMU.SCPI.INSTrument.DMM.INSTalled.Query(out Boolean installed);
            ID.MSMU.SCPI.INSTrument.DMM.STATe.Command(true);
            ID.MSMU.SCPI.INSTrument.DMM.CONNect.Command();
            ID.MSMU.SCPI.SENSe.RESistance.RESolution.Command("MAXimum");
            ID.MSMU.SCPI.ROUTe.CLOSe.Command("@1911,1912");
            Boolean passed = true;
            MeasurementNumeric MN = (MeasurementNumeric)TestLib.MeasurementPresent.ClassObject;


            String channel;
            for (Int32 i = 1; i < 21; i++) {
                channel = $"@1{i:D3}";
                ID.MSMU.SCPI.ROUTe.CLOSe.Command(channel);
                ID.MSMU.SCPI.MEASure.SCALar.RESistance.Query(25D, "MAXimum", out Double[] resistance);
                passed &= (MN.Low <= resistance[0] && resistance[0] <= MN.High);
                TestPlan.Only.MessageAppendLine(Label: $"Channel {channel}: ", Message: $"{Math.Round(resistance[0], MN.FD, MidpointRounding.ToEven)}Ω");
                ID.MSMU.SCPI.ROUTe.OPEN.Command(channel);

            }
            ID.MSMU.SCPI.ROUTe.OPEN.Command("@1911,1912");
            ID.MSMU.SCPI.ROUTe.CLOSe.Command("@1921,1922");
            for (Int32 i = 21; i < 41; i++) {
                channel = $"@1{i:D3}";
                ID.MSMU.SCPI.ROUTe.CLOSe.Command(channel);
                ID.MSMU.SCPI.MEASure.SCALar.RESistance.Query(25D, "MAXimum", out Double[] resistance);
                TestPlan.Only.MessageAppendLine(Label: $"Channel {channel}: ", Message: $"{Math.Round(resistance[0], 4, MidpointRounding.ToEven)}Ω");
                ID.MSMU.SCPI.ROUTe.OPEN.Command(channel);
            }
            return EVENTS.PASS.ToString();
        }
        #endregion GroupID 34921A
    }
}
