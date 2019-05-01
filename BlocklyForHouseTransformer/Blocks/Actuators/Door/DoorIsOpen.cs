namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    [Custom_attributes.EventStarterAttribute("door_is_open")]
    public class DoorIsOpen : Block
    {
        public override string Interpret(XmlToPythonContext context)
        {
            base.Interpret(context);
            context.NextNode();
            return (new Values.Door().Interpret(context)) + "."+Literals.DoorIsOpen+"()";
        }
    }
}
