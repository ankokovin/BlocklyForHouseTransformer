namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    [Custom_attributes.BodyCommand("open_door")]
    public class OpenDoor : Block
    {
        public override string Interpret(XmlToPythonContext context)
        {
            base.Interpret(context);
            context.NextNode();
            return (new Values.Door().Interpret(context)) + "."+Literals.DoorOpen+"()\n";
        }
    }
}
