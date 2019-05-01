namespace BlocklyForHouse.Transform.XmlToPython.Values
{
    public class Illuminance : Value
    {
        public override string Interpret(ref XmlToPythonContext context)
        {
            base.Interpret(ref context);
            context.NextNode();
            var result = (new Blocks.Illuminance()).Interpret(ref context);
            context.ParentNode();
            return result;
        }
    }
}

