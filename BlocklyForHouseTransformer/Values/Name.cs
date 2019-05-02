using System;

namespace BlocklyForHouse.Transform.XmlToPython.Values
{
    /// <summary>
    /// <para>&lt;value type=&quot;name&quot;&gt;</para>
    /// </summary>
    public class Name : Value
    {
        /// <summary>
        /// Interpret context as <see cref="Name"/>
        /// </summary>
        /// <param name="context">Context to interpret</param>
        /// <returns>Python code</returns>
        public override string Interpret(ref XmlToPythonContext context)
        {
            base.Interpret(ref context);
            context.NextNode();
            var result = (new Blocks.Text()).Interpret(ref context);
            context.ParentNode();
            return result;
        }
    }
}

