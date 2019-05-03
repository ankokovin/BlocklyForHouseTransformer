using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks.Logic
{
    [Custom_attributes.BoolneanAttribute("logic_compare")]
    class Compare : Block
    {
        public override string Interpret(ref XmlToPythonContext context)
        {
            base.Interpret(ref context);
            var nodes = context.currentNode.ChildNodes;
            string OP = string.Empty;
            string A = string.Empty;
            string B = string.Empty;
            foreach (XmlNode n in nodes)
            {
                context.currentNode = n;
                switch (n.Attributes["name"].Value)
                {
                    case "OP":
                        OP = new Field().Interpret(ref context);
                        break;

                    //TODO: add attribute for comparables
                    case "A":
                        A = new Math.Number().Interpret(ref context);
                        break;
                    case "B":
                        B = new Math.Number().Interpret(ref context);
                        break;
                    default:
                        throw new System.Exception();
                }
            }
            //TODO: error handling
            var result = "(" + A + Operations[OP] + B + ")";
            context.ParentNode();
            return result;
        }

        private readonly Dictionary<string, string> Operations = new Dictionary<string, string>
        {
            ["EQ"] = "==",
            ["NEQ"] = "!=",
            ["LT"] = "<",
            ["LTE"] = "<=",
            ["GT"] = ">",
            ["GTE"] = ">=",
        };
    }
}
