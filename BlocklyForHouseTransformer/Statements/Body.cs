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
                result += (Blocks[item.Attributes["type"].Value]).Interpret(context);
            }
            return result;
        }


        private Dictionary<string, Blocks.Block> blocks;

        private Dictionary<string, Blocks.Block> Blocks
        {
            get
            {
                if (blocks == null)
                    blocks = Custom_attributes.BodyCommandAttribute.GetBlocks();
                return blocks;
            }
        }
    }

}
