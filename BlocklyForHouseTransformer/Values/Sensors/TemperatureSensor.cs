namespace BlocklyForHouse.Transform.XmlToPython.Values
{
    public class TemperatureSensor : Value
    {
        public override string Interpret(ref XmlToPythonContext context)
        {
            base.Interpret(ref context);
            context.NextNode();
            var result =  (new Blocks.TemperatureSensor()).Interpret(ref context);
            context.ParentNode();
            return result;
        }
    }
}

