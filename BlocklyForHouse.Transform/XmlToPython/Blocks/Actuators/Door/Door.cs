namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    /// <summary>
    /// For xml input:
    /// <para>&lt;block type=&quot;door&quot;&gt;</para>
    /// </summary>
    public class Door : FunctionCallBlock<Values.Name>
    {
        public override string TypeName => TypeLiteralsXml.Door;

        protected override string FunctionLiteral => LiteralsPython.DoorCreate;

    }
}
