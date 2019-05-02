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
                string inputPath = @"C:\Users\user\Documents\Visual Studio 2017\Projects\BlocklyForHouseTransformer\BlocklyForHouse.Transform.Tests\HasEmpties\Inputs\AllEmpty.xml";
                string expected = string.Format(Literals.Import, Literals.PackageName) + '\n';
                string name = "None";
                expected += '\n';
                expected += Literals.Event + "\n" + BlocklyTransformer.AddSpaces(1) + Literals.EventStart;
                expected += Literals.EmptyEvent;
                expected += "\n\n";
                expected += Literals.Body + "\n";
                expected += BlocklyTransformer.AddSpaces(1) + Literals.EmptyBody;
                expected += '\n';
                expected += string.Format(Literals.AddScript, name);

                //act
                var actual = TestOne(ReadXmlInput(inputPath));

                //assert
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
