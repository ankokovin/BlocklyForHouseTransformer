namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    [Custom_attributes.EventStarterAttribute("door_is_open")]
    public class DoorIsOpen : Block
    {
        public override string Interpret(ref XmlToPythonContext context)
        {
            base.Interpret(ref context);
            context.NextNode();
            var result = (new Values.Door().Interpret(ref context)) + "."+Literals.DoorIsOpen+"()";
            context.ParentNode();
            return result;
        }
    }
}
