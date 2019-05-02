namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    /// <summary>
    /// <para>&lt;block type=&quot;...&quot;&gt;</para>
    /// </summary>
    public abstract class Block : AbstractExpression {
        /// <summary>
        /// Interpret context as <see cref="Block"/>
        /// </summary>
        /// <param name="context">Context to interpret</param>
        /// <returns>Python code</returns>
        public override string Interpret(ref XmlToPythonContext context)
        {
            System.Diagnostics.Debug.Assert(context.currentNode.Name == "block");
            return null;
        }
    }
}
