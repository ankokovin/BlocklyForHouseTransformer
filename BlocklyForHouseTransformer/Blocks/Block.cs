namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    public abstract class Block : AbstractExpression {
        public override string Interpret(ref XmlToPythonContext context)
        {
            System.Diagnostics.Debug.Assert(context.currentNode.Name == "block");
            return null;
        }
    }
}
