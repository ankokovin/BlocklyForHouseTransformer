namespace BlocklyForHouse.Tranfrom.XmlToPython
{
    public class Field : AbstractExpression
    {
        public override string Interpret(XmlToPythonContext context)
        {
            System.Diagnostics.Debug.Assert(context.currentNode.Name == "field");
            return context.currentNode.InnerText;
        }
    }
}
