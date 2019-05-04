namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    /// <summary>
    /// For xml input:
    /// <para>&lt;block type=&quot;open_door&quot;&gt;</para>
    /// </summary>
    [Custom_attributes.BodyCommand]
    public class OpenDoor : MethodCallBlock<Values.Door>
    {

        public override string TypeName => TypeLiteralsXml.OpenDoor;

        protected override string FunctionLiteral => LiteralsPython.DoorOpen;
        
    }
}
