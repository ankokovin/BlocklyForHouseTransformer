namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    [Custom_attributes.BodyCommand("open_door")]
    public class OpenDoor : Block
    {
        public override string Interpret(ref XmlToPythonContext context)
        {
            base.Interpret(ref context);
            context.NextNode();
            var result = (new Values.Door().Interpret(ref context)) + "."+Literals.DoorOpen+"()";
            context.ParentNode();
            context.NextCheck();
            return result;
        }
    }
}
