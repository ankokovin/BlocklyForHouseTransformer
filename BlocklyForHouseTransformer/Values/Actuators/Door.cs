namespace BlocklyForHouse.Transform.XmlToPython.Values
{
    public class Door : Value
    {
        public override string Interpret(ref XmlToPythonContext context)
        {
            base.Interpret(ref context);
            context.NextNode();
            var result = (new Blocks.Door()).Interpret(ref context);

            context.ParentNode();
            return result;
        }
    }
}

