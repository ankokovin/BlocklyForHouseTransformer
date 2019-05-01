namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    [Custom_attributes.BodyCommand("close_door")]
    public class CloseDoor : Block
    {
        public override string Interpret(ref XmlToPythonContext context)
        {
            base.Interpret(ref context);
            context.NextNode();
            var result = (new Values.Door().Interpret(ref context)) + "."+Literals.DoorClose+"()";
            context.ParentNode();
            context.NextCheck();
            return result;
        }
    }
}
