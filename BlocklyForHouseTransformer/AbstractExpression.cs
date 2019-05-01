namespace BlocklyForHouse.Transform.XmlToPython
{
    public abstract class AbstractExpression
    {
        public abstract string Interpret(ref XmlToPythonContext context);
    }
}
