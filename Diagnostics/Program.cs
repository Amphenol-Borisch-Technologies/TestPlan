using System;
using System.Linq;
using System.Xml.Linq;



class Program {
    private struct Test {
        internal const String Operation = "TO";
        internal const String Group = "TG";
    }

    private struct Method {
        internal const String Custom = "MC";
        internal const String Interval = "MI";
        internal const String Process = "MP";
        internal const String Textual = "MT";
    }

    static void Main() {
        XDocument doc = XDocument.Load(@"C:\Users\phils\source\repos\ConsoleApp1\ConsoleApp1\TO1.xml");

        var toElement = doc.Element(Test.Operation);
        if (toElement != null) {
            String folder = toElement.Attribute("Folder")?.Value;
            String description = toElement.Attribute("Description")?.Value;
            Console.WriteLine($"Folder: {folder}");
            Console.WriteLine($"Description: {description}");

            var tgs = toElement.Elements(Test.Group);
            foreach (var tg in tgs) {
                String tgClass = tg.Attribute("Class")?.Value;
                String tgDescription = tg.Attribute("Description")?.Value;
                Boolean cancelIfFail = Boolean.Parse(tg.Attribute("CancelIfFail")?.Value ?? "false");
                Boolean ie = Boolean.Parse(tg.Attribute("IE")?.Value ?? "false");
                Console.WriteLine($"\nTG Class: {tgClass}");
                Console.WriteLine($"TG Description: {tgDescription}");
                Console.WriteLine($"Cancel If Fail: {cancelIfFail}");
                Console.WriteLine($"IE: {ie}");

                var methods = tg.Elements();
                foreach (var method in methods) {
                    String methodType = method.Name.LocalName;
                    String methodName = method.Attribute("Method")?.Value;
                    String methodDescription = method.Attribute("Description")?.Value;
                    Boolean methodCancelIfFail = Boolean.Parse(method.Attribute("CancelIfFail")?.Value ?? "false");
                    Console.WriteLine($"\n  Method Type: {methodType}");
                    Console.WriteLine($"  Method: {methodName}");
                    Console.WriteLine($"  Description: {methodDescription}");
                    Console.WriteLine($"  Cancel If Fail: {methodCancelIfFail}");

                    // Process Parameters for MC methods
                    if (String.Equals(methodType, Method.Custom)) {
                        var parameters = method.Elements("Parameter");
                        foreach (var parameter in parameters) {
                            String key = parameter.Attribute("Key")?.Value;
                            String value = parameter.Attribute("Value")?.Value;
                            Console.WriteLine($"    Parameter Key: {key}, Value: {value}");
                        }
                    }

                    // Additional attributes for other methods
                    if (String.Equals(methodType, Method.Process)) {
                        String path = method.Attribute("Path")?.Value;
                        String executable = method.Attribute("Executable")?.Value;
                        String parameters = method.Attribute("Parameters")?.Value;
                        String expected = method.Attribute("Expected")?.Value;
                        Console.WriteLine($"    Path: {path}");
                        Console.WriteLine($"    Executable: {executable}");
                        Console.WriteLine($"    Parameters: {parameters}");
                        Console.WriteLine($"    Expected: {expected}");
                    } else if (String.Equals(methodType, Method.Textual)) {
                        String text = method.Attribute("Text")?.Value;
                        Console.WriteLine($"    Text: {text}");
                    } else if (String.Equals(methodType, Method.Interval)) {
                        Double low = Double.Parse(method.Attribute("Low")?.Value);
                        Double high = Double.Parse(method.Attribute("High")?.Value);
                        Int32 fd = Int32.Parse(method.Attribute("FD")?.Value);
                        String prefix = method.Attribute("Prefix")?.Value;
                        String units = method.Attribute("Units")?.Value;
                        String vaDescriptor = method.Attribute("VA_Descriptor")?.Value;
                        Console.WriteLine($"    Low: {low}");
                        Console.WriteLine($"    High: {high}");
                        Console.WriteLine($"    FD: {fd}");
                        Console.WriteLine($"    Prefix: {prefix}");
                        Console.WriteLine($"    Units: {units}");
                        Console.WriteLine($"    VA Descriptor: {vaDescriptor}");
                    }
                }
            }
        }
    }
}
