namespace BlocklyForHouse.Transform.XmlToPython.Values
{
    public class IlluminanceSensor : Value
    {
        public override string Interpret(XmlToPythonContext context)
        {
            base.Interpret(context);
            context.NextNode();
            return (new Blocks.IlluminanceSensor()).Interpret(context);
        }
    }
}

