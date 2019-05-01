namespace BlocklyForHouse.Transform.XmlToPython.Values
{
    public class IlluminanceSensor : Value
    {
        public override string Interpret(ref XmlToPythonContext context)
        {
            base.Interpret(ref context);
            context.NextNode();
            var result = (new Blocks.IlluminanceSensor()).Interpret(ref context);

            context.ParentNode();
            return result;
        }
    }
}

