namespace BlocklyForHouse.Transform.XmlToPython
{
    /// <summary>
    /// <para>&lt;field&gt;</para>
    /// </summary>
    public class Field : AbstractExpression
    {
        /// <summary>
        /// Interpret context as <see cref="Field"/>
        /// </summary>
        /// <param name="context">Context to interpret</param>
        /// <returns>Python code</returns>
        public override string Interpret(ref XmlToPythonContext context)
        {
            System.Diagnostics.Debug.Assert(context.currentNode.Name == "field");
            return context.currentNode.InnerText;
        }
    }
}
