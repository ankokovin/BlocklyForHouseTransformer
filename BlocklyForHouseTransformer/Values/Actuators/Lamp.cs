namespace BlocklyForHouse.Transform.XmlToPython.Values
{
    public class Lamp : Value
    {
        public override string Interpret(ref XmlToPythonContext context)
        {
            base.Interpret(ref context);
            context.NextNode();
            var result = (new Blocks.Lamp()).Interpret(ref context);

            context.ParentNode();
            return result;
        }
    }
}

