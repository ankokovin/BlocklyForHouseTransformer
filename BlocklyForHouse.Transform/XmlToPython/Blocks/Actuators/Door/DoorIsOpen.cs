namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    /// <summary>
    /// For xml input:
    /// <para>&lt;block type=&quot;door_is_open&quot;&gt;</para>
    /// </summary>
    [Custom_attributes.Boolean]
    public class DoorIsOpen : MethodCallBlock<Values.Door>
    {

        public override string TypeName => TypeLiteralsXml.DoorIsOpen;

        protected override string FunctionLiteral => LiteralsPython.DoorIsOpen;

    }
}
