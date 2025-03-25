using ABT.Test.TestLib;
using ABT.Test.TestLib.Configuration;
using ABT.Test.TestLib.InstrumentDrivers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ABT.Test.TestPlans.Diagnostics.TestPlan {

    internal static class TestMethods {
        internal static EVENTS DiagnosticsT<T>(List<Parameter> Parameters) where T : IDiagnostics {
            Dictionary<String, T> instrumentDriversT = Data.InstrumentDrivers.Where(kvp => kvp.Value is T).ToDictionary(kvp => kvp.Key, kvp => (T)kvp.Value);
            if (instrumentDriversT.Count() == 0) {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine($"No instruments of type '{typeof(T).Name}' found:");
                stringBuilder.AppendLine($"Check '{Data.TestExecDefinitionXML}' for missing:");
                stringBuilder.AppendLine($" - Element:   '{nameof(InstrumentTestExec)}'.");
                stringBuilder.AppendLine($" - Attribute: '{nameof(InstrumentTestExec.NameSpacedClassName)}' = '{typeof(T).Name}'.");
                stringBuilder.AppendLine(String.Empty);
                stringBuilder.AppendLine($"Check '{Data.TestPlanDefinitionXML}' for:");
                stringBuilder.AppendLine($" - Element:   '{nameof(TestSpace)}'.");
                stringBuilder.AppendLine($" - Attribute: '{nameof(TestSpace.Simulate)}' = '{true}'.");
                TestIndices.Method.Log.Append(stringBuilder.ToString());
                return EVENTS.INFORMATION;
            }

            (Boolean Summary, List<DiagnosticsResult> Details) resultDiagnostics;
            Boolean passedCollective = true;
            foreach (KeyValuePair<String, T> kvp in instrumentDriversT) {
                resultDiagnostics = kvp.Value.Diagnostics(Parameters);
                passedCollective &= resultDiagnostics.Summary;
                TestIndices.Method.Log.AppendLine($"ID '{kvp.Key}', Driver '{typeof(T).Name}', Result '{(resultDiagnostics.Summary ? EVENTS.PASS.ToString() : EVENTS.FAIL.ToString())}'.");
                foreach (DiagnosticsResult dr in resultDiagnostics.Details) TestIndices.Method.Log.AppendLine($"{dr.Label}{dr.Message}, Result '{dr.Event}'.");
            }
            return passedCollective ? EVENTS.PASS : EVENTS.FAIL;
        }
    }
}
