using System;
using System.IO;
namespace BlocklyForHouse.Transform.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO work with args

            using(StreamReader sr = new StreamReader("C:\\Users\\user\\Documents\\Visual Studio 2017\\Projects\\BlocklyForHouseXmlToPython\\ConsoleClient\\input.xml"))
            {
                string xml = sr.ReadToEnd();
                var transformer = new BlocklyTransformer();
                foreach(var result in transformer.XmlToPython(xml))
                    Console.WriteLine(result);
            }
            Console.Read();
        }
    }
}
