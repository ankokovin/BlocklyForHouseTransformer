namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    [Custom_attributes.EventStarterAttribute("door_is_open")]
    public class DoorIsOpen : Block
    {
        public override string Interpret(XmlToPythonContext context)
        {
            base.Interpret(context);
            context.currentNode = context.currentNode.FirstChild;
            return '\t'+(new Values.Door().Interpret(context)) + ".is_open()\n";
        }
    }
}
