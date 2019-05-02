namespace BlocklyForHouse.Transform.XmlToPython.Statements
{
    /// <summary>
    /// <para>&lt;statement type=&quot;...&quot;&gt;</para>
    /// </summary>
    public abstract class Statement : AbstractExpression
    {
        /// <summary>
        /// Interpret context as <see cref="Statement"/>
        /// </summary>
        /// <param name="context">Context to interpret</param>
        /// <returns>Python code</returns>
        public override string Interpret(ref XmlToPythonContext context)
        {
            System.Diagnostics.Debug.Assert(context.currentNode.Name == "statement");
            return null;
        }
    }
}
