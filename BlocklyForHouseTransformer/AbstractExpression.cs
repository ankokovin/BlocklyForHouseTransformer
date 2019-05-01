namespace BlocklyForHouse.Transform.XmlToPython
{
    public abstract class AbstractExpression
    {
        public abstract string Interpret(XmlToPythonContext context);
    }
}
