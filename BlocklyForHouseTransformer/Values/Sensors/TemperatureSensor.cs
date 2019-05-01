namespace BlocklyForHouse.Transform.XmlToPython.Values
{
    public class TemperatureSensor : Value
    {
        public override string Interpret(XmlToPythonContext context)
        {
            base.Interpret(context);
            context.NextNode();
            return (new Blocks.TemperatureSensor()).Interpret(context);
        }
    }
}

