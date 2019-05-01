namespace BlocklyForHouse.Transform.XmlToPython.Values
{
    public class Humidity : Value
    {
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

