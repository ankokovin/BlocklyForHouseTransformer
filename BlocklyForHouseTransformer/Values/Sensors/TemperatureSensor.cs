namespace BlocklyForHouse.Transform.XmlToPython.Values
{
    public class TemperatureSensor : Value
    {
        public override string Interpret(XmlToPythonContext context)
        {
            base.Interpret(context);
            context.currentNode = context.currentNode.FirstChild;
            return (new Blocks.TemperatureSensor()).Interpret(context);
        }
    }
}

