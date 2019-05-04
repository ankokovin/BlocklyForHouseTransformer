namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    /// <summary>
    /// For xml input:
    /// <para>&lt;block type=&quot;door&quot;&gt;</para>
    /// </summary>
    public class Door : Block
    {
        public override string TypeName => TypeLiteralsXml.Door;

        /// <summary>
        /// Interpret context as <see cref="Door"/>
        /// </summary>
        /// <param name="context">Context to interpret</param>
        /// <returns>Python code</returns>
        public override string Interpret(ref XmlToPythonContext context)
        {
            base.Interpret(ref context);
            context.NextNode();
            var result = string.Format(LiteralsPython.Call,LiteralsPython.DoorCreate, (new Values.Name()).Interpret(ref context));
            context.ParentNode();
            return result;
        }
    }
}
