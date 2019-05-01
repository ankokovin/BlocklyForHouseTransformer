namespace BlocklyForHouse.Transform.XmlToPython.Values
{
    public abstract class Value : AbstractExpression
    {
        public override string Interpret(XmlToPythonContext context)
        {
            System.Diagnostics.Debug.Assert(context.currentNode.Name == "value");
            return null;
        }
    }
}
