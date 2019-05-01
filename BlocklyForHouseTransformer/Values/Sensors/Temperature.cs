namespace BlocklyForHouse.Transform.XmlToPython.Values
{
    public class Temperature : Value
    {
        public override string Interpret(XmlToPythonContext context)
        {
            base.Interpret(context);
            context.NextNode();
            return (new Blocks.Temperature()).Interpret(context);
        }
    }
}

