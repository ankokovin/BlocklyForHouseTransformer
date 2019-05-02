using System.Linq;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlocklyForHouse.Transform.Tests
{
    [TestClass]
    public partial class XmlToPyTests
    {
       

        public static string TestOne(string xmlInput)
        {
            BlocklyTransformer blocklyTransformer = new BlocklyTransformer();
            var result = blocklyTransformer.XmlToPython(xmlInput);
            Assert.AreEqual(1, result.Count());
            return result.First();
        }

        public static string ReadXmlInput(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                return sr.ReadToEnd();
            }
        }
    }
}
