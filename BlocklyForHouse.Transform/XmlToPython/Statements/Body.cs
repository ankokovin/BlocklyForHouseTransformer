using System;
using System.Collections.Generic;
using System.Xml;

namespace BlocklyForHouse.Transform.XmlToPython.Statements
{
    /// <summary>
    /// <see cref="Statement"/> for actions inside <see cref="Blocks.Script"/>
    /// <para>&lt;statement type=&quot;body&quot;&gt;</para>
    /// </summary>
    public class Body : Statement
    {
        /// <summary>
        /// Interpret context as <see cref="Body"/>
        /// </summary>
        /// <param name="context">Context to interpret</param>
        /// <returns>Python code</returns>
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

        /// <summary>
        /// Blocks, which could be used as actions inside <see cref="Body"/>
        /// </summary>
        private Dictionary<string, Blocks.Block> Blocks
        {
            get
            {
                if (blocks == null)
                    blocks = Custom_attributes.XmlTypeAttribute
                        .GetBlocks<Custom_attributes.BodyCommandAttribute>();
                return blocks;
            }
        }
    }

}
