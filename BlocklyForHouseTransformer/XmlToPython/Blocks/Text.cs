using System;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    /// <summary>
    /// <para>&lt;block type=&quot;text&quot;&gt;</para>
    /// </summary>
    public class Text : Block
    {
        /// <summary>
        /// Interpret context as <see cref="Text"/>
        /// </summary>
        /// <param name="context">Context to interpret</param>
        /// <returns>Python code</returns>
        public override string Interpret(ref XmlToPythonContext context)
        {
            base.Interpret(ref context);
            context.NextNode();
            var result =  '"' + (new Field()).Interpret(ref context)+'"';

            context.ParentNode();
            return result;
        }
    }
}
