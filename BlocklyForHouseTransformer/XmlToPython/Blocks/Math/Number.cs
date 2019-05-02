using System;
using System.Collections.Generic;
using System.Text;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks.Math
{
    /// <summary>
    /// <para>&lt;block type=&quot;math_number&quot;&gt;</para>
    /// </summary>
    public class Number : Block
    {
        /// <summary>
        /// Interpret context as <see cref="Number"/>
        /// </summary>
        /// <param name="context">Context to interpret</param>
        /// <returns>Python code</returns>
        public override string Interpret(ref XmlToPythonContext context)
        {
            base.Interpret(ref context);
            context.NextNode();
            var result = new Field().Interpret(ref context);
            context.ParentNode();
            return result;
        }
    }
}
