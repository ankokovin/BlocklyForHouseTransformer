namespace BlocklyForHouse.Transform.XmlToPython.Values
{
    public class Illuminance : Value
    {
        public override string Interpret(XmlToPythonContext context)
        {
            base.Interpret(context);
            context.currentNode = context.currentNode.FirstChild;
            return (new Blocks.Illuminance()).Interpret(context);
        }
    }
}

