namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    /// <summary>
    /// For xml input:
    /// <para>&lt;block type=&quot;close_door&quot;&gt;</para>
    /// </summary>
    [Custom_attributes.BodyCommand]
    public class CloseDoor : MethodCallBlock<Values.Door>
    {
        public override string TypeName => TypeLiteralsXml.CloseDoor;

        protected override string FunctionLiteral => LiteralsPython.DoorClose;

        protected override bool NeedNextCheck => true;
    }
}
