﻿namespace BlocklyForHouse.Transform.XmlToPython.Values
{
    /// <summary>
    /// <para>&lt;value type=&quot;door&quot;&gt;</para>
    /// </summary>
    public class Door : Value
    {
        /// <summary>
        /// Interpret context as <see cref="Door"/>
        /// </summary>
        /// <param name="context">Context to interpret</param>
        /// <returns>Python code</returns>
        public override string Interpret(ref XmlToPythonContext context)
        {
            base.Interpret(ref context);
            context.NextNode();
            var result = (new Blocks.Door()).Interpret(ref context);

            context.ParentNode();
            return result;
        }
    }
}

