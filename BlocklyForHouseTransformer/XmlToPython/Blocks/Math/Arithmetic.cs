using System.Collections.Generic;
using System.Xml;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks.Math
{
    /// <summary>
    /// <para>&lt;block type=&quot;math_arithmetic&quot;&gt;</para>
    /// </summary>
    public class Arithmetic : Block
    {
        /// <summary>
        /// Interpret context as <see cref="Arithmetic"/>
        /// </summary>
        /// <param name="context">Context to interpret</param>
        /// <returns>Python code</returns>
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
                    case "A":
                        context.NextNode();
                        A = Blocks[context.currentNode.Attributes["type"].Value].Interpret(ref context);
                        break;
                    case "B":
                        context.NextNode();
                        B = Blocks[context.currentNode.Attributes["type"].Value].Interpret(ref context);
                        break;
                    default:
                        throw new System.Exception();
                }
            }
            //TODO: error handling
            var result = "("+A + Operations[OP] + B+")";
            context.ParentNode();
            return result;
        }

        private readonly Dictionary<string, string> Operations = new Dictionary<string, string>
        {
            ["ADD"] = "+",
            ["MINUS"] = "-",
            ["MULTIPLY"] = "*",
            ["DIVIDE"] = "/",
            ["POWER"] = "**",
        };

        private readonly Dictionary<string, Block> Blocks =
            Custom_attributes.FinderAttribute.GetBlocks<Custom_attributes.NumberAttribute>();
    }
}
