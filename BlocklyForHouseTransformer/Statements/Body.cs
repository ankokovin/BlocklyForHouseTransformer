using System;
using System.Xml;

namespace BlocklyForHouse.Tranfrom.XmlToPython.Statements
{
    public class Body : Statement
    {
        public override string Interpret(XmlToPythonContext context)
        {
            base.Interpret(context);
            var result = string.Empty;
            var node = context.currentNode;
            foreach (XmlNode item in node.ChildNodes)
            {
                /* TODO: Необходим способ обнаружения!
                 */
                context.currentNode = item;
                result += (new Blocks.CloseDoor()).Interpret(context);
            }
            return result;
        }
    }

}
