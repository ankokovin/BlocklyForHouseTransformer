namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    public class Door : Block
    {
        public override string Interpret(XmlToPythonContext context)
        {
            base.Interpret(context);
            context.currentNode = context.currentNode.FirstChild;
            return "door(" + (new Values.Name()).Interpret(context)+")";
        }
    }
}
