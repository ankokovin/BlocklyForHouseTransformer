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
            //TODO work with args
            if (args.Length == 0)
            {
                OutputResult(Console.OpenStandardOutput(), Parse(ReadInput()));
            }
            else if (args.Length == 1)
            {
                if (ValidFileInput(args[0]))
                {
                    OutputResult(Console.OpenStandardOutput(), Parse(ReadInput(args[0])));
                }else if (ValidFileOutput(args[0]))
                {
                    using (Stream s = new FileStream(args[0], FileMode.Create))
                    {
                        OutputResult(s, Parse(ReadInput()));
                    }
                }
                else if (args[0].StartsWith("--"))
                {
                    
                }
            }else if (args.Length == 2)
            {
                if (!ValidFileInput(args[0]) || !ValidFileOutput(args[1]))
                    throw new Exception("Unexpected paramenters");
                using (Stream s = new FileStream(args[1], FileMode.Create))
                {
                    OutputResult(s, Parse(ReadInput(args[0])));
                }
            }
        }

        static void ManualCommands(string input)
        {
            Debug.Assert(input.StartsWith("--"));

        }

        static void Help()
        {
            Console.WriteLine("ConsoleClient [input.xml] [output.py|txt]" +
                "ConsoleClient --help");
        }

        static bool ValidFileInput(string s) => s.EndsWith(".xml");
        static bool ValidFileOutput(string s) => s.EndsWith(".py") || s.EndsWith(".txt");

        static string ReadInput(string inputPath= defaultInputDir)
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
    }
}
