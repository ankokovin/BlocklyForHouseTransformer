namespace BlocklyForHouse.Transform.XmlToPython.Values
{
    /// <summary>
    /// <para>&lt;value type=&quot;il_sensor&quot;&gt;</para>
    /// </summary>
    public class IlluminanceSensor : Value
    {
        /// <summary>
        /// Interpret context as <see cref="IlluminanceSensor"/>
        /// </summary>
        /// <param name="context">Context to interpret</param>
        /// <returns>Python code</returns>
        public override string Interpret(ref XmlToPythonContext context)
        {
            base.Interpret(ref context);
            context.NextNode();
            var result = (new Blocks.IlluminanceSensor()).Interpret(ref context);

            context.ParentNode();
            return result;
        }
    }
}

