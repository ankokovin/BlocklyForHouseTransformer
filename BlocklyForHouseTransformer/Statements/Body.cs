using System;
using System.Collections.Generic;
using System.Xml;

namespace BlocklyForHouse.Transform.XmlToPython.Statements
{
    public class Body : Statement
    {
        public override string Interpret(ref XmlToPythonContext context)
        {
            base.Interpret(ref context);
            context.tabCount = 1;
            var result = string.Empty;
            context.NextNode();
            XmlNode prev;
            do
            {
                prev = context.currentNode;
                result += BlocklyTransformer.AddSpaces(context.tabCount)
                + (Blocks[context.currentNode.Attributes["type"].Value]).Interpret(ref context) + '\n';
            } while (prev!=context.currentNode);
            
            return result;
        }


        private Dictionary<string, Blocks.Block> blocks;

        private Dictionary<string, Blocks.Block> Blocks
        {
            get
            {
                if (blocks == null)
                    blocks = Custom_attributes.FinderAttribute.GetBlocks<Custom_attributes.BodyCommandAttribute>();
                return blocks;
            }
        }
    }

}
