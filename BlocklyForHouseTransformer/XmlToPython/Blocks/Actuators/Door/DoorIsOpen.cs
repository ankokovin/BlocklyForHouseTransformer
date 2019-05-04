namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    /// <summary>
    /// For xml input:
    /// <para>&lt;block type=&quot;door_is_open&quot;&gt;</para>
    /// </summary>
    [Custom_attributes.Boolean]
    public class DoorIsOpen : Block
    {

        public override string TypeName => TypeLiteralsXml.DoorIsOpen;
        /// <summary>
        /// Interpret context as <see cref="DoorIsOpen"/>
        /// </summary>
        /// <param name="context">Context to interpret</param>
        /// <returns>Python code</returns>
        public override string Interpret(ref XmlToPythonContext context)
        {
            base.Interpret(ref context);
            context.NextNode();
            var result = (new Values.Door().Interpret(ref context)) + "."+LiteralsPython.DoorIsOpen+"()";
            context.ParentNode();
            return result;
        }
    }
}
