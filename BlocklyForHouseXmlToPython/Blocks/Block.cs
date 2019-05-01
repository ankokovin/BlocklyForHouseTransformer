namespace BlocklyForHouse.Tranfrom.XmlToPython.Blocks
{
    public abstract class Block : AbstractExpression {
        public override string Interpret(XmlToPythonContext context)
        {
            System.Diagnostics.Debug.Assert(context.currentNode.Name == "block");
            return null;
        }
    }
}
