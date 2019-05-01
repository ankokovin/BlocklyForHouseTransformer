namespace BlocklyForHouse.Transform.XmlToPython.Values
{
    public class HumiditySensor : Value
    {
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

