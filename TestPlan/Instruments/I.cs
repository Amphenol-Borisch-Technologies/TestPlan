using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Threading;
using static ABT.Test.TestExecutive.Instruments.Instruments;

namespace ABT.Test.UUT.Instruments {
    internal enum FREQUENCY { off, KHz445, KHz535, KHz625 }
    internal enum LOAD_CURRENT { off, A0_015, A3_5, A4_375, A4_675, A6_0, A7_0, A8_75, A11_67, A12_0, A14_5 }
    internal enum PS_BIAS { PRI, SEC } // Add PRE if/when needed.
    internal enum STIMULUS { off, V1_A0_2, V12_5_A0_2, V18_A0_2, V18_W15, V18_W100, V18_W120, V18_W150, V28_W15, V28_W52_5, V28_W100, V28_W120, V36_W15, V36_W100 }
    internal enum SVIs { BIAS_PRI, BIAS_SEC, SYNC, VIN, VOUT } // Add PRE_BIAS, if/when needed.

    internal static class I {
    //    internal static Boolean Are(STATES PRI_BIAS, STATES SEC_BIAS, STIMULUS VIN, LOAD_CURRENT VOUT, FREQUENCY SYNC) { // NOTE:  Add STATES PRE_BIAS, if/when needed.
    //        return BIAS.Is(PS_BIAS.PRI, PRI_BIAS)
    //            && BIAS.Is(PS_BIAS.SEC, SEC_BIAS)
    //            && I.VIN.Is(VIN)
    //            && I.VOUT.Is(VOUT)
    //            && I.SYNC.Is(SYNC); // Add BIAS_Is(PS_BIAS.PRE, PRE_BIAS) if/when needed.
    //    }

    //    internal static Boolean Are(STIMULUS VIN, LOAD_CURRENT VOUT, FREQUENCY SYNC) {
    //    //  Add Debug.Assert(BIAS.Is(PS_BIAS.PRE, STATES.off)); if/when needed.
    //        Debug.Assert(BIAS.Is(PS_BIAS.PRI, STATES.off));
    //        Debug.Assert(BIAS.Is(PS_BIAS.SEC, STATES.off));
    //        return I.VIN.Is(VIN)
    //            && I.VOUT.Is(VOUT)
    //            && I.SYNC.Is(SYNC);
    //    }

    //    internal static void Set(STATES PRI_BIAS, STATES SEC_BIAS, STIMULUS VIN, LOAD_CURRENT VOUT, FREQUENCY SYNC) { // Add STATES PRE_BIAS, if/when needed.
    //        if (VOUT != LOAD_CURRENT.off) I.VOUT.Set(VOUT); // Apply Electronic Load first, remove last.
    //    //  Add BIAS_Set(PS_BIAS.PRE, PRE_BIAS); if/when needed.
    //        BIAS.Set(PS_BIAS.PRI, PRI_BIAS);
    //        BIAS.Set(PS_BIAS.SEC, SEC_BIAS); 
    //        I.VIN.Set(VIN);
    //        I.SYNC.Set(SYNC);
    //        I.VOUT.Set(VOUT);
    //    }

    //    internal static void Set(STIMULUS VIN, LOAD_CURRENT VOUT, FREQUENCY SYNC) {
    //    //  Add Debug.Assert(BIAS.Is(PS_BIAS.PRE, STATES.off)); if/when needed.
    //        Debug.Assert(BIAS.Is(PS_BIAS.PRI, STATES.off));
    //        Debug.Assert(BIAS.Is(PS_BIAS.SEC, STATES.off));
    //        I.VIN.Set(VIN);
    //        I.SYNC.Set(SYNC);
    //        I.VOUT.Set(VOUT);
    //    }

    //    internal static Boolean StimuliAreOff() {
    //        // Add BIAS.Is(PS_BIAS.PRE, STATES.off) if/when needed.
    //        return BIAS.Is(PS_BIAS.PRI, STATES.off)
    //            && BIAS.Is(PS_BIAS.SEC, STATES.off)
    //            && SYNC.Is(FREQUENCY.off)
    //            && VIN.Is(STIMULUS.off);
    //    }

    //    internal static void StimuliSetOff() {
    //        BIAS.Set(PS_BIAS.PRI,STATES.off);
    //        BIAS.Set(PS_BIAS.SEC,STATES.off);
    //        VIN.Set(STIMULUS.off);
    //        SYNC.Set(FREQUENCY.off);
    //    }

    //    internal static class BIAS {
    //        internal static Boolean Is(PS_BIAS BIAS, STATES State) { return SCPI99.Is(TestExecutor.Only.SVIs[Biases[BIAS]], State); }

    //        internal static Double Get(PS_BIAS BIAS, PS_DC DC) {
    //            (SwitchedNet BIAS_OUT_P, SwitchedNet PS_BIAS) = BIAS_RouteGet(BIAS);
    //            Debug.Assert(Switches.Routes.Are(BIAS_OUT_P, PS_BIAS, SWITCHED_STATE.CONNECTED));
    //            return PS_E3610xB.Get(TestExecutor.Only.SVIs[Biases[BIAS]], DC);
    //       }

    //        internal static void Set(PS_BIAS BIAS, STATES State) {
    //            (SwitchedNet BIAS_OUT_P, SwitchedNet PS_BIAS) = BIAS_RouteGet(BIAS);
    //            if (Is(BIAS, State)) return; // Don't reapply unnecessarily; might cause transient stimulus during reapplication.
    //            if (State == STATES.off) SCPI99.Set(TestExecutor.Only.SVIs[Biases[BIAS]], STATES.off);
    //            else {
    //                Fan.Set(STATES.ON);
    //                Switches.Routes.Set(BIAS_OUT_P, PS_BIAS, SWITCHED_STATE.CONNECTED);
    //                PS_E3610xB.Set(TestExecutor.Only.SVIs[Biases[BIAS]], STATES.ON, VoltsDC: 6.25, AmpsDC: 0.20, SENSE_MODE.EXTernal, DelaySecondsCurrentProtection: 0.5, DelaySecondsSettling: 0.5);
    //            }
    //        }

    //        private static (SwitchedNet, SwitchedNet) BIAS_RouteGet(PS_BIAS bias) {
    //            switch (bias) {
    //            //  Add case PS_BIAS.PRE:  return (Nets.PRE_BIAS_OUT_P, Nets.PRE_BIAS_PS); if/when needed.
    //                case PS_BIAS.PRI:  return (Nets.PRI_BIAS_OUT_P, Nets.PRI_BIAS_PS);
    //                case PS_BIAS.SEC:  return (Nets.SEC_BIAS_OUT_P, Nets.SEC_BIAS_PS);
    //                default:  throw new NotImplementedException(TestExecutive.NotImplementedMessageEnum(typeof(BIAS)));
    //            }
    //        }

    //        private static readonly Dictionary<PS_BIAS, SCPI_VISA_Instrument.Alias> Biases = new Dictionary<PS_BIAS, SCPI_VISA_Instrument.Alias> {
    //        //  Add { PS_BIAS.PRE, IA.PRE_BIAS }, if/when needed.
    //            { PS_BIAS.PRI, IA.PRI_BIAS },
    //            { PS_BIAS.SEC, IA.SEC_BIAS }
    //        };
    //    }

    //    internal static class MM {
    //        internal static Double GetPowerBusVDC(SwitchedNet switchedNet) {
    //            DisConnect();
    //            switch (switchedNet) {

    //                // VIN_RTN ≡ PRI_RTN.
    //                case SwitchedNet sn when sn == Nets.P3V3_PRI:
    //                    Switches.Routes.Set(Nets.MM_P, Nets.P3V3_PRI, SWITCHED_STATE.CONNECTED);
    //                    Switches.Routes.Set(Nets.MM_N, Nets.VIN_RTN, SWITCHED_STATE.CONNECTED);
    //                    break;
    //                case SwitchedNet sn when sn == Nets.PRI_BIAS:
    //                    Switches.Routes.Set(Nets.MM_P, Nets.PRI_BIAS, SWITCHED_STATE.CONNECTED);
    //                    Switches.Routes.Set(Nets.MM_N, Nets.VIN_RTN, SWITCHED_STATE.CONNECTED);
    //                    break;
    //                case SwitchedNet sn when sn == Nets.VIN:
    //                    Switches.Routes.Set(Nets.MM_P, Nets.VIN, SWITCHED_STATE.CONNECTED);
    //                    Switches.Routes.Set(Nets.MM_N, Nets.VIN_RTN, SWITCHED_STATE.CONNECTED);
    //                    break;

    //                // VOUT_RTN ≡ SEC_RTN.
    //                case SwitchedNet sn when sn == Nets.P3V3_SEC:
    //                    Switches.Routes.Set(Nets.MM_P, Nets.P3V3_SEC, SWITCHED_STATE.CONNECTED);
    //                    Switches.Routes.Set(Nets.MM_N, Nets.VOUT_RTN, SWITCHED_STATE.CONNECTED);
    //                    break;
    //                case SwitchedNet sn when sn == Nets.SEC_BIAS:
    //                    Switches.Routes.Set(Nets.MM_P, Nets.SEC_BIAS, SWITCHED_STATE.CONNECTED);
    //                    Switches.Routes.Set(Nets.MM_N, Nets.VOUT_RTN, SWITCHED_STATE.CONNECTED);
    //                    break;
    //                case SwitchedNet sn when sn == Nets.VOUT:
    //                    Switches.Routes.Set(Nets.MM_P, Nets.VOUT, SWITCHED_STATE.CONNECTED);
    //                    Switches.Routes.Set(Nets.MM_N, Nets.VOUT_RTN, SWITCHED_STATE.CONNECTED);
    //                    break;
    //                default:  throw new NotImplementedException($"Cannot accomodate SwitchedNet '{switchedNet.ID}', aliased as '{switchedNet.Alias}'.");
    //            }
    //            Double vdc = MM_34461A.Get(TestExecutor.Only.SVIs[IA.MM], PROPERTY.VoltageDC);
    //            DisConnect();
    //            return vdc;
    //        }

    //        internal static void DisConnect() {
    //            UE24.Set(UE.B0, C.S.NC);
    //            UE24.Set(UE.B1, new HashSet<R>() {R.C01, R.C02, R.C06, R.C07, R.C08, R.C09, R.C10, R.C11}, C.S.NC); // Exclude Fan, CTL_1_3 & CTL_4_6 UE.B1 relays R.C3, R.C4 & R.C5 respectively.
    //        }
    //    }

    //    internal static class VIN {
    //        internal static Boolean Is(STIMULUS Stimulus) {
    //            if (Stimulus == STIMULUS.off) return PS_E36234A.Is(TestExecutor.Only.SVIs[IA.VIN], STATES.off, CHANNEL.C1);
    //            return PS_E36234A.Is(TestExecutor.Only.SVIs[IA.VIN], STATES.ON, CHANNEL.C1)
    //                && PS_E36234A.VoltageAmplitudeIs(TestExecutor.Only.SVIs[IA.VIN], Stimuli[Stimulus].VoltsDC, Delta: 0.01, CHANNEL.C1)
    //                && PS_E36234A.CurrentAmplitudeIs(TestExecutor.Only.SVIs[IA.VIN], Stimuli[Stimulus].AmpsDC, Delta: 0.01, CHANNEL.C1)
    //                && PS_E36234A.SlewRatesAre(TestExecutor.Only.SVIs[IA.VIN], Stimuli[Stimulus].SlewRateRising, Stimuli[Stimulus].SlewRateFalling, CHANNEL.C1);
    //        }

    //        internal static Double Get(PS_DC UPS) { return PS_E36234A.Get(TestExecutor.Only.SVIs[IA.VIN], UPS, CHANNEL.C1, SENSE_MODE.EXTernal); }

    //        internal static void Set(STIMULUS Stimulus) {
    //            if (Is(Stimulus)) return; // Don't reapply unnecessarily; might interrupt stimulus during reapplication.
    //            if (Stimulus == STIMULUS.off) {
    //                SCPI99.Set(TestExecutor.Only.SVIs[IA.VIN], STATES.off);
    //                Thread.Sleep(millisecondsTimeout: 500);
    //            } else {
    //                Fan.Set(STATES.ON);
    //                PS_E36234A.SlewRatesSet(TestExecutor.Only.SVIs[IA.VIN], Stimuli[Stimulus].SlewRateRising, Stimuli[Stimulus].SlewRateFalling, CHANNEL.C1);
    //                PS_E36234A.Set(TestExecutor.Only.SVIs[IA.VIN], STATES.ON, Stimuli[Stimulus].VoltsDC, Stimuli[Stimulus].AmpsDC, VoltageProtectionAmplitude: 50, CHANNEL.C1, SENSE_MODE.EXTernal, DelaySecondsCurrentProtection: 0.5, DelaySecondsSettling: 0.5);
    //            }
    //        }

    //        internal static void Set(PS_DC DC, Double Amplitude) {
    //            Fan.Set(STATES.ON);
    //            PS_E36234A.Set(TestExecutor.Only.SVIs[IA.VIN], DC, Amplitude, CHANNEL.C1, SENSE_MODE.EXTernal);
    //        }

    //        internal static readonly Dictionary<STIMULUS, Stimulus> Stimuli = new Dictionary<STIMULUS, Stimulus> {
    //            { STIMULUS.off,        new Stimulus(voltsDC: 0,    ampsDC: 0,      slewRateRising: 1000, slewRateFalling: 1000) },
    //            { STIMULUS.V1_A0_2,    new Stimulus(voltsDC: 1.0,  ampsDC: 0.20,   slewRateRising: 1000, slewRateFalling: 1000) },
    //            { STIMULUS.V12_5_A0_2, new Stimulus(voltsDC: 12.5, ampsDC: 0.20,   slewRateRising: 1000, slewRateFalling: 1000) },
    //            { STIMULUS.V18_A0_2,   new Stimulus(voltsDC: 18.0, ampsDC: 0.20,   slewRateRising: 1000, slewRateFalling: 1000) },
    //            { STIMULUS.V18_W15,    new Stimulus(voltsDC: 18.0, ampsDC: 0.833,  slewRateRising: 1000, slewRateFalling: 1000) },
    //            { STIMULUS.V18_W100,   new Stimulus(voltsDC: 18.0, ampsDC: 5.556,  slewRateRising: 1000, slewRateFalling: 1000) },
    //            { STIMULUS.V18_W120,   new Stimulus(voltsDC: 18.0, ampsDC: 6.667,  slewRateRising: 1000, slewRateFalling: 1000) },
    //            { STIMULUS.V18_W150,   new Stimulus(voltsDC: 18.0, ampsDC: 8.333,  slewRateRising: 1000, slewRateFalling: 1000) },
    //            { STIMULUS.V28_W15,    new Stimulus(voltsDC: 28.0, ampsDC: 0.536,  slewRateRising: 1000, slewRateFalling: 1000) },
    //            { STIMULUS.V28_W52_5,  new Stimulus(voltsDC: 28.0, ampsDC: 1.875,  slewRateRising: 1000, slewRateFalling: 1000) },
    //            { STIMULUS.V28_W100,   new Stimulus(voltsDC: 28.0, ampsDC: 3.571,  slewRateRising: 1000, slewRateFalling: 1000) },
    //            { STIMULUS.V28_W120,   new Stimulus(voltsDC: 28.0, ampsDC: 4.286,  slewRateRising: 1000, slewRateFalling: 1000) },
    //            { STIMULUS.V36_W15,    new Stimulus(voltsDC: 36.0, ampsDC: 0.417,  slewRateRising: 1000, slewRateFalling: 1000) },
    //            { STIMULUS.V36_W100,   new Stimulus(voltsDC: 36.0, ampsDC: 2.778,  slewRateRising: 1000, slewRateFalling: 1000) }
    //        };

    //        internal class Stimulus {
    //            internal readonly Double VoltsDC;
    //            internal readonly Double AmpsDC;
    //            internal readonly Double SlewRateRising;
    //            internal readonly Double SlewRateFalling;
    //            internal Stimulus(Double voltsDC, Double ampsDC, Double slewRateRising, Double slewRateFalling) { VoltsDC = voltsDC; AmpsDC = ampsDC; SlewRateRising = slewRateRising; SlewRateFalling = slewRateFalling; }
    //        }
    //    }

    //    internal static class VOUT {
    //        internal static readonly Dictionary<LOAD_CURRENT, LoadCurrent> LoadCurrents = new Dictionary<LOAD_CURRENT, LoadCurrent> {
    //            { LOAD_CURRENT.off,     new LoadCurrent(AmpsDC: 0,     SlewRateRising: 5000, SlewRateFalling: 5000) },
    //            { LOAD_CURRENT.A0_015,  new LoadCurrent(AmpsDC: 0.015, SlewRateRising: 5000, SlewRateFalling: 5000) },
    //            { LOAD_CURRENT.A3_5,    new LoadCurrent(AmpsDC: 3.5,   SlewRateRising: 5000, SlewRateFalling: 5000) },
    //            { LOAD_CURRENT.A4_375,  new LoadCurrent(AmpsDC: 4.375, SlewRateRising: 5000, SlewRateFalling: 5000) },
    //            { LOAD_CURRENT.A4_675,  new LoadCurrent(AmpsDC: 4.675, SlewRateRising: 5000, SlewRateFalling: 5000) },
    //            { LOAD_CURRENT.A6_0,    new LoadCurrent(AmpsDC: 6.0,   SlewRateRising: 5000, SlewRateFalling: 5000) },
    //            { LOAD_CURRENT.A7_0,    new LoadCurrent(AmpsDC: 7.0,   SlewRateRising: 5000, SlewRateFalling: 5000) },
    //            { LOAD_CURRENT.A8_75,   new LoadCurrent(AmpsDC: 8.75,  SlewRateRising: 5000, SlewRateFalling: 5000) },
    //            { LOAD_CURRENT.A11_67,  new LoadCurrent(AmpsDC: 11.67, SlewRateRising: 5000, SlewRateFalling: 5000) },
    //            { LOAD_CURRENT.A12_0,   new LoadCurrent(AmpsDC: 12.0,  SlewRateRising: 5000, SlewRateFalling: 5000) },
    //            { LOAD_CURRENT.A14_5,   new LoadCurrent(AmpsDC: 14.5,  SlewRateRising: 5000, SlewRateFalling: 5000) }
    //        };

    //        internal static Boolean Is(LOAD_CURRENT Load) {
    //            if (Load == LOAD_CURRENT.off) return SCPI99.Is(TestExecutor.Only.SVIs[IA.VOUT], STATES.off);
    //            return EL_34143A.Is(TestExecutor.Only.SVIs[IA.VOUT], STATES.ON)
    //                && EL_34143A.Is(TestExecutor.Only.SVIs[IA.VOUT], LoadCurrents[Load].AmpsDC, LOAD_MODE.CURR)
    //                && EL_34143A.SlewRatesAre(TestExecutor.Only.SVIs[IA.VOUT], LoadCurrents[Load].SlewRateRising, LoadCurrents[Load].SlewRateFalling, LOAD_MODE.CURR);
    //        }

    //        internal static Double Get(LOAD_MEASURE LoadMeasure) { return EL_34143A.Get(TestExecutor.Only.SVIs[IA.VOUT], LoadMeasure, SENSE_MODE.EXTernal); }

    //        internal static void Set(LOAD_CURRENT Load) {
    //            if (Is(Load)) return; // Don't reapply unnecessarily; might interrupt loading during reapplication.
    //            if (Load == LOAD_CURRENT.off) EL_34143A.Set(TestExecutor.Only.SVIs[IA.VOUT], STATES.off);
    //            else {
    //                Fan.Set(STATES.ON);
    //                EL_34143A.SlewRatesSet(TestExecutor.Only.SVIs[IA.VOUT], LoadCurrents[Load].SlewRateRising, LoadCurrents[Load].SlewRateFalling, LOAD_MODE.CURR);
    //                EL_34143A.Set(TestExecutor.Only.SVIs[IA.VOUT], STATES.ON, LoadCurrents[Load].AmpsDC, LOAD_MODE.CURR, SENSE_MODE.EXTernal);
    //            }
    //        }
            
    //        internal class LoadCurrent {
    //            internal readonly Double AmpsDC;
    //            internal readonly Double SlewRateRising;
    //            internal readonly Double SlewRateFalling;
    //            internal LoadCurrent(Double AmpsDC, Double SlewRateRising, Double SlewRateFalling) {
    //                this.AmpsDC = AmpsDC;
    //                this.SlewRateRising = SlewRateRising;
    //                this.SlewRateFalling = SlewRateFalling;
    //            }
    //        }
    //    }

    //    internal static class SYNC {
    //        private static readonly Dictionary<FREQUENCY, Double> Frequencies = new Dictionary<FREQUENCY, Double> {
    //            { FREQUENCY.off, 0 },
    //            { FREQUENCY.KHz445, 445E3 },
    //            { FREQUENCY.KHz535, 535E3 },
    //            { FREQUENCY.KHz625, 625E3 }
    //        };

    //        internal static Boolean Is(FREQUENCY Hertz) {
    //            if (Hertz == FREQUENCY.off) return WG_33509B.Is(TestExecutor.Only.SVIs[IA.SYNC], STATES.off);
    //            return WG_33509B.Is(TestExecutor.Only.SVIs[IA.SYNC], STATES.ON) && WaveformIs(Hertz);
    //        }

    //        internal static void Set(FREQUENCY Hertz) {
    //            if (Is(Hertz)) return; // Don't reapply unnecessarily; might cause transient stimulus during reapplication.
    //            if (Hertz == FREQUENCY.off) SCPI99.Set(TestExecutor.Only.SVIs[IA.SYNC], STATES.off);
    //            else WG_33509B.WaveformSquareApply(TestExecutor.Only.SVIs[IA.SYNC], Frequencies[Hertz], V_High: 3.3, V_Offset: 1.65);
    //        }

    //        internal static void ModulateFM(STATES state) {
    //            switch (state) {
    //                case STATES.off:
    //                    WG_33509B.ModulateFM_SquareWave(TestExecutor.Only.SVIs[IA.SYNC], HzDeviation: 90000, HzFM: 500, STATES.off);
    //                    return;
    //                case STATES.ON:
    //                    Set(FREQUENCY.KHz535);
    //                    WG_33509B.ModulateFM_SquareWave(TestExecutor.Only.SVIs[IA.SYNC], HzDeviation: 90000, HzFM: 500, STATES.ON);
    //                    return;
    //                default:
    //                    throw new NotImplementedException(TestExecutive.NotImplementedMessageEnum(typeof(STATES)));
    //            }
    //        }

    //        private static Boolean WaveformIs(FREQUENCY Hertz) {
    //            String Waveform = WG_33509B.WaveformGet(TestExecutor.Only.SVIs[IA.SYNC]);
    //            switch (Hertz) {
    //                case FREQUENCY.KHz445:  return Waveform.Equals("SQU +4.450000000000000E+05,+3.3000000000000E+00,+1.6500000000000E+00");
    //                case FREQUENCY.KHz535:  return Waveform.Equals("SQU +5.350000000000000E+05,+3.3000000000000E+00,+1.6500000000000E+00");
    //                case FREQUENCY.KHz625:  return Waveform.Equals("SQU +6.250000000000000E+05,+3.3000000000000E+00,+1.6500000000000E+00");
    //                default:                throw new NotImplementedException(TestExecutive.NotImplementedMessageEnum(typeof(FREQUENCY)));
    //            }
    //        }
    //    }
    }
}
