namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    public class Door : Block
    {
        public override string Interpret(XmlToPythonContext context)
        {
            base.Interpret(context);
            context.NextNode();
            return string.Format(Literals.Call,Literals.DoorCreate, (new Values.Name()).Interpret(context));
        }
    }
}
