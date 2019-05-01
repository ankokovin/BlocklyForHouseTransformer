namespace BlocklyForHouse.Tranfrom.XmlToPython
{
    public abstract class AbstractExpression
    {
        public abstract string Interpret(XmlToPythonContext context);
    }
}
