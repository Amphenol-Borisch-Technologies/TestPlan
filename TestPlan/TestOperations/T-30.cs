using System;
using System.Diagnostics;
using ABT.Test.Exec;
using ABT.Test.Exec.AppConfig;

namespace ABT.Test.UUT.TestOperations {
    internal static partial class TestMeasurements {
        // NOTE:  Invocable test methods in this class, defined as TestMeasurement IDs in App.config, require signatures like "internal static String MethodName()".

        #region GroupID 4.2
        internal static String TM_01_00() {
            Debug.Assert(
                TestPlan.Only.IsOperation(
                OperationID: "T-30",
                Description: "FilePro T-30 Functional Test.",
                Revision: "1.0",
                GroupsIDs: "4.2|4.4.1|4.4.2|4.5|4.6|4.7|4.8|4.9|4.10"));
            Debug.Assert(TestPlan.Only.IsGroup(
                GroupID: "4.2",
                Description: "Preliminary Electrical Test.",
                MeasurementIDs: "TM_01_00",
                Selectable: false,
                CancelNotPassed: true));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_00_00",
                IDNext: "TM_02_00",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }
        #endregion GroupID 4.2

        #region GroupID 4.4.1
        internal static String TM_02_00() {
            Debug.Assert(TestPlan.Only.IsGroup(
                GroupID: "4.4.1",
                Description: "UUT Remote Update Firmware Operation.",
                MeasurementIDs: "TM_02_00",
                Selectable: false,
                CancelNotPassed: true));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_01_00",
                IDNext: "TM_03_00",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }
        #endregion GroupID 4.4.1

        #region GroupID 4.4.2
        internal static String TM_03_00() {
            Debug.Assert(TestPlan.Only.IsGroup(
                GroupID: "4.4.2",
                Description: "UUT Remote Update Firmware Operation.",
                MeasurementIDs: "TM_03_00|TM_03_01",
                Selectable: false,
                CancelNotPassed: true));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_02_00",
                IDNext: "TM_03_01",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_03_01() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.4.2"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_03_00",
                IDNext: "TM_04_00",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }
        #endregion GroupID 4.4.2

        #region GroupID 4.5
        internal static String TM_04_00() {
            Debug.Assert(TestPlan.Only.IsGroup(
                GroupID: "4.5",
                Description: "IIU Test.",
                MeasurementIDs: "TM_04_00|TM_04_01|TM_04_02|TM_04_03|TM_04_04|TM_04_05|TM_04_06|TM_04_07",
                Selectable: false,
                CancelNotPassed: true));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_03_01",
                IDNext: "TM_04_01",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_04_01() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.5"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_04_00",
                IDNext: "TM_04_02",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_04_02() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.5"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_04_01",
                IDNext: "TM_04_03",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_04_03() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.5"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_04_02",
                IDNext: "TM_04_04",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_04_04() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.5"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_04_03",
                IDNext: "TM_04_05",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_04_05() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.5"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_04_04",
                IDNext: "TM_04_06",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_04_06() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.5"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_04_05",
                IDNext: "TM_04_07",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_04_07() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.5"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_04_06",
                IDNext: "TM_05_00",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }
        #endregion GroupID 4.5

        #region GroupID 4.6
        internal static String TM_05_00() {
            Debug.Assert(TestPlan.Only.IsGroup(
                GroupID: "4.6",
                Description: "UUT Test Command.",
                MeasurementIDs: "TM_05_00|TM_05_01|TM_05_02|TM_05_03|TM_05_04|TM_05_05|TM_05_06|TM_05_07|TM_05_08|" +
                "TM_05_09|TM_05_10|TM_05_11|TM_05_12|TM_05_13|TM_05_14|TM_05_15|TM_05_16|TM_05_17|TM_05_18|TM_05_19|" +
                "TM_05_20|TM_05_21|TM_05_22|TM_05_23|TM_05_24|TM_05_25|TM_05_26|TM_05_27|TM_05_28|TM_05_29|TM_05_30|" +
                "TM_05_31|TM_05_32|TM_05_33|TM_05_34|TM_05_35|TM_05_36|TM_05_37|TM_05_38|TM_05_39|TM_05_40|TM_05_41|" +
                "TM_05_42|TM_05_43|TM_05_44|TM_05_45|TM_05_46|TM_05_47|TM_05_48|TM_05_49|TM_05_50|TM_05_51|TM_05_52|" +
                "TM_05_53|TM_05_54|TM_05_55|TM_05_56|TM_05_57|TM_05_58|TM_05_59|TM_05_60|TM_05_61|TM_05_62|TM_05_63|" +
                "TM_05_64|TM_05_65|TM_05_66|TM_05_67|TM_05_68|TM_05_69|TM_05_70|TM_05_71|TM_05_72|TM_05_73|TM_05_74|" +
                "TM_05_75|TM_05_76|TM_05_77|TM_05_78|TM_05_79|TM_05_80|TM_05_81|TM_05_82|TM_05_83|TM_05_84|TM_05_85|" +
                "TM_05_86|TM_05_87|TM_05_88|TM_05_89|TM_05_90|TM_05_91|TM_05_92|TM_05_93|TM_05_94|TM_05_95|TM_05_96|" +
                "TM_05_97|TM_05_98|TM_05_99",
                Selectable: false,
                CancelNotPassed: true));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_04_07",
                IDNext: "TM_05_01",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_01() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_00",
                IDNext: "TM_05_02",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_02() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_01",
                IDNext: "TM_05_03",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_03() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_02",
                IDNext: "TM_05_04",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_04() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_03",
                IDNext: "TM_05_05",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_05() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_04",
                IDNext: "TM_05_06",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_06() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_05",
                IDNext: "TM_05_07",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_07() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_06",
                IDNext: "TM_05_08",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_08() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_07",
                IDNext: "TM_05_09",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_09() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_08",
                IDNext: "TM_05_10",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_10() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_09",
                IDNext: "TM_05_11",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_11() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_10",
                IDNext: "TM_05_12",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_12() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_11",
                IDNext: "TM_05_13",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_13() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_12",
                IDNext: "TM_05_14",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_14() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_13",
                IDNext: "TM_05_15",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_15() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_14",
                IDNext: "TM_05_16",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_16() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_15",
                IDNext: "TM_05_17",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_17() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_16",
                IDNext: "TM_05_18",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_18() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_17",
                IDNext: "TM_05_19",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_19() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_18",
                IDNext: "TM_05_20",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_20() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_19",
                IDNext: "TM_05_21",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_21() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_20",
                IDNext: "TM_05_22",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_22() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_21",
                IDNext: "TM_05_23",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_23() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_22",
                IDNext: "TM_05_24",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_24() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_23",
                IDNext: "TM_05_25",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_25() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_24",
                IDNext: "TM_05_26",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_26() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_25",
                IDNext: "TM_05_27",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_27() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_26",
                IDNext: "TM_05_28",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_28() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_27",
                IDNext: "TM_05_29",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_29() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_28",
                IDNext: "TM_05_30",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_30() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_29",
                IDNext: "TM_05_11",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_31() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_30",
                IDNext: "TM_05_32",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_32() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_31",
                IDNext: "TM_05_33",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_33() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_32",
                IDNext: "TM_05_34",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_34() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_33",
                IDNext: "TM_05_35",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_35() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_34",
                IDNext: "TM_05_36",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_36() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_35",
                IDNext: "TM_05_37",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_37() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_36",
                IDNext: "TM_05_38",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_38() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_37",
                IDNext: "TM_05_39",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_39() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_38",
                IDNext: "TM_05_40",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_40() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_39",
                IDNext: "TM_05_41",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_41() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_40",
                IDNext: "TM_05_42",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_42() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_41",
                IDNext: "TM_05_43",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_43() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_42",
                IDNext: "TM_05_44",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_44() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_43",
                IDNext: "TM_05_45",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_45() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_44",
                IDNext: "TM_05_46",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_46() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_45",
                IDNext: "TM_05_47",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_47() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_46",
                IDNext: "TM_05_48",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_48() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_47",
                IDNext: "TM_05_49",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_49() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_48",
                IDNext: "TM_05_50",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_50() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_49",
                IDNext: "TM_05_51",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_51() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_50",
                IDNext: "TM_05_52",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_52() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_51",
                IDNext: "TM_05_53",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_53() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_52",
                IDNext: "TM_05_54",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_54() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_53",
                IDNext: "TM_05_55",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_55() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_54",
                IDNext: "TM_05_56",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_56() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_55",
                IDNext: "TM_05_57",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_57() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_56",
                IDNext: "TM_05_58",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_58() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_57",
                IDNext: "TM_05_59",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_59() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_58",
                IDNext: "TM_05_60",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_60() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_59",
                IDNext: "TM_05_61",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_61() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_60",
                IDNext: "TM_05_62",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_62() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_61",
                IDNext: "TM_05_63",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_63() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_62",
                IDNext: "TM_05_64",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_64() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_63",
                IDNext: "TM_05_65",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_65() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_64",
                IDNext: "TM_05_66",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_66() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_65",
                IDNext: "TM_05_67",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_67() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_66",
                IDNext: "TM_05_68",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_68() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_67",
                IDNext: "TM_05_69",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_69() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_68",
                IDNext: "TM_05_70",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_70() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_69",
                IDNext: "TM_05_71",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_71() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_70",
                IDNext: "TM_05_72",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_72() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_71",
                IDNext: "TM_05_73",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_73() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_72",
                IDNext: "TM_05_74",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_74() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_73",
                IDNext: "TM_05_75",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_75() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_74",
                IDNext: "TM_05_76",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_76() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_75",
                IDNext: "TM_05_77",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_77() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_76",
                IDNext: "TM_05_78",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_78() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_77",
                IDNext: "TM_05_79",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_79() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_78",
                IDNext: "TM_05_80",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_80() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_79",
                IDNext: "TM_05_81",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_81() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_80",
                IDNext: "TM_05_82",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_82() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_81",
                IDNext: "TM_05_83",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_83() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_82",
                IDNext: "TM_05_84",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_84() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_83",
                IDNext: "TM_05_85",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_85() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_84",
                IDNext: "TM_05_86",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_86() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_85",
                IDNext: "TM_05_87",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_87() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_86",
                IDNext: "TM_05_88",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_88() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_87",
                IDNext: "TM_05_89",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_89() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_88",
                IDNext: "TM_05_90",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_90() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_89",
                IDNext: "TM_05_91",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_91() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_90",
                IDNext: "TM_05_92",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_92() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_91",
                IDNext: "TM_05_93",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_93() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_92",
                IDNext: "TM_05_94",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_94() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_93",
                IDNext: "TM_05_95",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_95() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_94",
                IDNext: "TM_05_96",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_96() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_95",
                IDNext: "TM_05_97",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_97() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_96",
                IDNext: "TM_05_98",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_98() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_97",
                IDNext: "TM_05_99",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_05_99() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.6"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_98",
                IDNext: "TM_06_00",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }
        #endregion GroupID 4.6

        #region GroupID 4.7
        internal static String TM_06_00() {
            Debug.Assert(TestPlan.Only.IsGroup(
                GroupID: "4.7",
                Description: "CPOW Test.",
                MeasurementIDs: "TM_06_00|TM_06_01|TM_06_02|TM_06_03|TM_06_04|TM_06_05|TM_06_06|TM_06_07|TM_06_08",
                Selectable: false,
                CancelNotPassed: true));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_05_99",
                IDNext: "TM_06_01",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_06_01() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.7"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_06_00",
                IDNext: "TM_06_02",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_06_02() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.7"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_06_01",
                IDNext: "TM_06_03",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_06_03() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.7"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_06_02",
                IDNext: "TM_06_04",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_06_04() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.7"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_06_03",
                IDNext: "TM_06_05",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_06_05() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.7"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_06_04",
                IDNext: "TM_06_06",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_06_06() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.7"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_06_05",
                IDNext: "TM_06_07",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_06_07() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.7"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_06_06",
                IDNext: "TM_06_08",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_06_08() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.7"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_06_07",
                IDNext: "TM_07_00",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }
        #endregion GroupID 4.7

        #region GroupID 4.8
        internal static String TM_07_00() {
            Debug.Assert(TestPlan.Only.IsGroup(
                GroupID: "4.8",
                Description: "UUT Memory Write32 Command.",
                MeasurementIDs: "TM_07_00|TM_07_01|TM_07_02|TM_07_03",
                Selectable: false,
                CancelNotPassed: true));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_06_08",
                IDNext: "TM_07_01",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_07_01() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.8"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_07_00",
                IDNext: "TM_07_02",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_07_02() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.8"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_07_01",
                IDNext: "TM_07_03",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_07_03() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.8"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_07_02",
                IDNext: "TM_08_00",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }
        #endregion GroupID 4.8

        #region GroupID 4.9
        internal static String TM_08_00() {
            Debug.Assert(TestPlan.Only.IsGroup(
                GroupID: "4.9",
                Description: "UUT Ambient Temperature Command.",
                MeasurementIDs: "TM_07_00|TM_07_01",
                Selectable: false,
                CancelNotPassed: true));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_07_03",
                IDNext: "TM_08_01",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }

        internal static String TM_08_01() {
            Debug.Assert(TestPlan.Only.IsGroup(GroupID: "4.8"));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_08_00",
                IDNext: "TM_09_00",
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }
        #endregion GroupID 4.9

        #region GroupID 4.10
        internal static String TM_09_00() {
            Debug.Assert(TestPlan.Only.IsGroup(
                GroupID: "4.10",
                Description: "UUT Remote Update Firmware Operation.",
                MeasurementIDs: "TM_09_00",
                Selectable: false,
                CancelNotPassed: true));
            Debug.Assert(TestPlan.Only.IsMeasurement(
                Description: "Description.",
                IDPrior: "TM_08_01",
                IDNext: TestPlan.NONE,
                ClassName: nameof(MeasurementCustom),
                CancelNotPassed: true,
                Arguments: "NotApplicable"));
            Debug.Assert(TestPlan.Only.ReInitialized());
            TestPlan.Only.MeasurementPresent.TestEvent = String.Equals(String.Empty, String.Empty) ? TestEvents.PASS : TestEvents.FAIL;
            return String.Empty;
        }
        #endregion GroupID 4.10
    }
}
