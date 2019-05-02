using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlocklyForHouse.Transform.Tests
{
    public partial class XmlToPyTests
    {
        [TestClass]
        public class HasEmpties
        {
            [TestMethod]
            public void AllEmpty()
            {
                
                //arrange
                string inputPath = @"HasEmpties\Inputs\AllEmpty.xml";
                string expected = string.Format(LiteralsPython.Import, LiteralsPython.PackageName) + '\n';
                string name = "None";
                expected += '\n';
                expected += LiteralsPython.Event + "\n" + BlocklyTransformer.AddSpaces(1) + LiteralsPython.EventStart;
                expected += LiteralsPython.EmptyEvent;
                expected += "\n\n";
                expected += LiteralsPython.Body + "\n";
                expected += BlocklyTransformer.AddSpaces(1) + LiteralsPython.EmptyBody;
                expected += '\n';
                expected += string.Format(LiteralsPython.AddScript, name);

                //act
                var actual = TestOne(ReadXmlInput(inputPath));

                //assert
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
