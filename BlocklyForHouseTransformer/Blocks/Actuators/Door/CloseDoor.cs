namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    [Custom_attributes.BodyCommand("close_door")]
    public class CloseDoor : Block
    {
        public override string Interpret(XmlToPythonContext context)
        {
            base.Interpret(context);
            context.NextNode();
            return (new Values.Door().Interpret(context)) + "."+Literals.DoorClose+"()\n";
        }
    }
}
