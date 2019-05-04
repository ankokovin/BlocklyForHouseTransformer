namespace BlocklyForHouse.Transform.XmlToPython
{
    /// <summary>
    /// abstraction of expressions inside xml input
    /// </summary>
    public abstract class AbstractExpression
    {
        /// <summary>
        /// Interpret some context
        /// </summary>
        /// <param name="context">Context to interpret</param>
        /// <returns>Code in Python</returns>
        public abstract string Interpret(ref XmlToPythonContext context);
    }
}
