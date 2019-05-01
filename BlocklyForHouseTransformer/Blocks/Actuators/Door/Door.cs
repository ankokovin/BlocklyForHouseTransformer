namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    public class Door : Block
    {
        public override string Interpret(ref XmlToPythonContext context)
        {
            base.Interpret(ref context);
            context.NextNode();
            var result = string.Format(Literals.Call,Literals.DoorCreate, (new Values.Name()).Interpret(ref context));
            context.ParentNode();
            return result;
        }
    }
}
