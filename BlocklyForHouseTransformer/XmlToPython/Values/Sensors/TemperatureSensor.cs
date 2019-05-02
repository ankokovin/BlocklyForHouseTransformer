namespace BlocklyForHouse.Transform.XmlToPython.Values
{
    /// <summary>
    /// <para>&lt;value type=&quot;tem_sensor&quot;&gt;</para>
    /// </summary>
    public class TemperatureSensor : Value
    {
        /// <summary>
        /// Interpret context as <see cref="TemperatureSensor"/>
        /// </summary>
        /// <param name="context">Context to interpret</param>
        /// <returns>Python code</returns>
        public override string Interpret(ref XmlToPythonContext context)
        {
            base.Interpret(ref context);
            context.NextNode();
            var result =  (new Blocks.TemperatureSensor()).Interpret(ref context);
            context.ParentNode();
            return result;
        }
    }
}

