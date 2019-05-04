namespace BlocklyForHouse.Transform.XmlToPython.Values
{
    /// <summary>
    /// <para>&lt;value type=&quot;hum_sensor&quot;&gt;</para>
    /// </summary>
    public class HumiditySensor : Value
    {
        /// <summary>
        /// Interpret context as <see cref="HumiditySensor"/>
        /// </summary>
        /// <param name="context">Context to interpret</param>
        /// <returns>Python code</returns>
        public override string Interpret(ref XmlToPythonContext context)
        {
            base.Interpret(ref context);
            context.NextNode();
            var result = (new Blocks.HumiditySensor()).Interpret(ref context);

            context.ParentNode();
            return result;
        }
    }
}

