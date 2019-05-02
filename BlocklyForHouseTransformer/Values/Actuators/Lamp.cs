namespace BlocklyForHouse.Transform.XmlToPython.Values
{
    /// <summary>
    /// <para>&lt;value type=&quot;lamp&quot;&gt;</para>
    /// </summary>
    public class Lamp : Value
    {
        /// <summary>
        /// Interpret context as <see cref="Lamp"/>
        /// </summary>
        /// <param name="context">Context to interpret</param>
        /// <returns>Python code</returns>
        public override string Interpret(ref XmlToPythonContext context)
        {
            base.Interpret(ref context);
            context.NextNode();
            var result = (new Blocks.Lamp()).Interpret(ref context);

            context.ParentNode();
            return result;
        }
    }
}

