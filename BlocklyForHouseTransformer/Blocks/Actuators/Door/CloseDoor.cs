namespace BlocklyForHouse.Tranfrom.XmlToPython.Blocks
{
    public class CloseDoor : Block
    {
        public override string Interpret(XmlToPythonContext context)
        {
            base.Interpret(context);
            context.currentNode = context.currentNode.FirstChild;
            return '\t'+(new Values.Door().Interpret(context)) + ".close()\n";
        }
    }
}
