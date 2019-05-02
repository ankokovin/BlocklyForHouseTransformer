namespace BlocklyForHouse.Transform.XmlToPython.Values
{
    /// <summary>
    /// <para>&lt;value type=&quot;illuminance&quot;&gt;</para>
    /// </summary>
    public class Illuminance : Value
    {
        /// <summary>
        /// Interpret context as <see cref="Illuminance"/>
        /// </summary>
        /// <param name="context">Context to interpret</param>
        /// <returns>Python code</returns>
        public override string Interpret(ref XmlToPythonContext context)
        {
            base.Interpret(ref context);
            context.NextNode();
            var result = (new Blocks.Illuminance()).Interpret(ref context);
            context.ParentNode();
            return result;
        }
    }
}

