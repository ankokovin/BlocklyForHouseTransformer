using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
namespace BlocklyForHouse.Transform.ConsoleClient
{
    class Program
    {
        const string defaultInputDir = "input.xml";
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                OutputResult(Console.OpenStandardOutput(), Parse(ReadInput()));
            }
            else if (args.Length == 1)
            {
                if (ValidFileInput(args[0]))
                {
                    OutputResult(Console.OpenStandardOutput(), Parse(ReadInput(args[0])));
                }
                else if (ValidFileOutput(args[0]))
                {
                    AssureDirectory(args[0]);
                    using (Stream s = new FileStream(args[0], FileMode.Create))
                    {
                        OutputResult(s, Parse(ReadInput()));
                    }
                }
                else if (args[0].StartsWith("-"))
                {
                    ManualCommands(args[0]);
                }
            }
            else if (args.Length == 2)
            {
                if (!ValidFileInput(args[0]) || !ValidFileOutput(args[1]))
                    throw new Exception("Unexpected paramenters");
                AssureDirectory(args[1]);
                using (Stream s = new FileStream(args[1], FileMode.Create))
                {
                    OutputResult(s, Parse(ReadInput(args[0])));
                }
            }
        }

        static void ManualCommands(string input)
        {
            Debug.Assert(input.StartsWith("-"));
            if (input == "-help"){
                Help();
            }
        }

        static void Help()
        {
            Console.WriteLine("ConsoleClient [input.xml] [output.py|txt]\n" +
                "ConsoleClient -help");
        }

        static bool ValidFileInput(string s) => s.EndsWith(".xml");
        static bool ValidFileOutput(string s) => s.EndsWith(".py") || s.EndsWith(".txt");

        static string ReadInput(string inputPath = defaultInputDir)
        {
            string text = string.Empty;
            try
            {
                using (StreamReader sr = new StreamReader(inputPath))
                {
                    text = sr.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                throw e;
            }
            return text;
        }

        static void OutputResult(Stream stream, IEnumerable<string> s)
        {
            using (StreamWriter sw = new StreamWriter(stream))
            {
                foreach (var i in s)
                    sw.Write(i);
            }
        }

        static IEnumerable<string> Parse(string xml)
        {
            var transformer = new BlocklyTransformer();
            return transformer.XmlToPython(xml);
        }


        static void AssureDirectory(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }
    }
}
