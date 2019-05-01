using System;
using System.Collections.Generic;
using System.Xml;

namespace BlocklyForHouse.Transform.XmlToPython.Statements
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
                context.currentNode = item;
                result += (blocks[item.Attributes["type"].Value]).Interpret(context);
            }
            return result;
        }


        private readonly Dictionary<string, Blocks.Block> blocks = new Dictionary<string, Blocks.Block>
        {
            ["close_door"] = new Blocks.CloseDoor(),
        };
    }

}
