using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks.Logic
{
    [Custom_attributes.Boolean]
    class Compare : Block
    {
        
        public override string TypeName => TypeLiteralsXml.Compare;
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
                        context.NextNode();
                        if (OP == "EQ" || OP == "NEQ")
                            A = EqBlocks[context.currentNode.Attributes["type"].Value]
                                .Interpret(ref context);
                        else
                            A = ComBlocks[context.currentNode.Attributes["type"].Value]
                                .Interpret(ref context);
                        break;
                    case "B":
                        context.NextNode();
                        if (OP == "EQ" || OP == "NEQ")
                            B = EqBlocks[context.currentNode.Attributes["type"].Value]
                                .Interpret(ref context);
                        else
                            B = ComBlocks[context.currentNode.Attributes["type"].Value]
                                .Interpret(ref context);
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

        private readonly Dictionary<string, Block> ComBlocks =
            Custom_attributes.XmlTypeAttribute.GetBlocks<Custom_attributes.ComparableAttribute>();
        private readonly Dictionary<string, Block> EqBlocks =
            Custom_attributes.XmlTypeAttribute.GetBlocks<Custom_attributes.EquitableAttribute>();
    }
}
