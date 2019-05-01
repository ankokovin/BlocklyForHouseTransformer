namespace BlocklyForHouse.Transform.XmlToPython.Values
{
    public class Lamp : Value
    {
        public override string Interpret(XmlToPythonContext context)
        {
            base.Interpret(context);
            context.NextNode();
            throw new System.NotImplementedException();
        }
    }
}

