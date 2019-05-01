using System.Collections.Generic;
using System.Xml;

namespace BlocklyForHouse.Tranfrom
{
    public class BlocklyTransformer
    {
        public IEnumerable<string> XmlToPython(string text)
        {
            var context = new XmlToPython.XmlToPythonContext(text);
            var doc = context.currentNode;
            foreach (XmlNode child in doc.ChildNodes)
            {
                context.currentNode = child;
                yield return (new XmlToPython.Blocks.Script().Interpret(context));
            }
        }
    }
}
