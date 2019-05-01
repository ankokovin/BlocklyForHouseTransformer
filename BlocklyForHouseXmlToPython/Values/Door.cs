namespace BlocklyForHouse.Tranfrom.XmlToPython.Values
{
    public class Door : Value
    {
        public override string Interpret(XmlToPythonContext context)
        {
            base.Interpret(context);
            context.currentNode = context.currentNode.FirstChild;
            return (new Blocks.Door()).Interpret(context);
        }
    }
}

