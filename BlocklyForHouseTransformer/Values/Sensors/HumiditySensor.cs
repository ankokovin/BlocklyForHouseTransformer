namespace BlocklyForHouse.Transform.XmlToPython.Values
{
    public class HumiditySensor : Value
    {
        public override string Interpret(XmlToPythonContext context)
        {
            base.Interpret(context);
            context.NextNode();
            return (new Blocks.HumiditySensor()).Interpret(context);
        }
    }
}

