namespace BlocklyForHouse.Transform.XmlToPython.Values
{
    /// <summary>
    /// <para>&lt;value type=&quot;temperature&quot;&gt;</para>
    /// </summary>
    public class Temperature : Value
    {
        /// <summary>
        /// Interpret context as <see cref="Temperature"/>
        /// </summary>
        /// <param name="context">Context to interpret</param>
        /// <returns>Python code</returns>
        public override string Interpret(ref XmlToPythonContext context)
        {
            base.Interpret(ref context);
            context.NextNode();
            var result = (new Blocks.Temperature()).Interpret(ref context);

            context.ParentNode();
            return result;
        }
    }
}

