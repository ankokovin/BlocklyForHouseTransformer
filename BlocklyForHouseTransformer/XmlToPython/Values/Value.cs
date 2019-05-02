namespace BlocklyForHouse.Transform.XmlToPython.Values
{
    /// <summary>
    /// <para>&lt;value type=&quot;...&quot;&gt;</para>
    /// </summary>
    public abstract class Value : AbstractExpression
    {
        /// <summary>
        /// Interpret context as <see cref="Value"/>
        /// </summary>
        /// <param name="context">Context to interpret</param>
        /// <returns>Python code</returns>
        public override string Interpret(ref XmlToPythonContext context)
        {
            System.Diagnostics.Debug.Assert(context.currentNode.Name == "value");
            return null;
        }
    }
}
