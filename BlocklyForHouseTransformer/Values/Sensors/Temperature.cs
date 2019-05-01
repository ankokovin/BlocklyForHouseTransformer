namespace BlocklyForHouse.Transform.XmlToPython.Values
{
    public class Temperature : Value
    {
        public override string Interpret(ref XmlToPythonContext context)
        {
            base.Interpret(ref context);
            context.NextNode();
            var result = (new Blocks.Temperature()).Interpret(ref context);

            context.ParentNode();
            return result;
        }
    }
}

