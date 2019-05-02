namespace BlocklyForHouse.Transform.XmlToPython.Values
{
    /// <summary>
    /// <para>&lt;value type=&quot;humidity&quot;&gt;</para>
    /// </summary>
    public class Humidity : Value
    {
        /// <summary>
        /// Interpret context as <see cref="Humidity"/>
        /// </summary>
        /// <param name="context">Context to interpret</param>
        /// <returns>Python code</returns>
        public override string Interpret(ref XmlToPythonContext context)
        {
            base.Interpret(ref context);
            context.NextNode();
            var result = (new Blocks.Humidity()).Interpret(ref context);

            context.ParentNode();
            return result;
        }
    }
}

