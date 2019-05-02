namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    /// <summary>
    /// For xml input:
    /// <para>&lt;block type=&quot;open_door&quot;&gt;</para>
    /// </summary>
    [Custom_attributes.BodyCommand("open_door")]
    public class OpenDoor : Block
    {
        /// <summary>
        /// Interpret context as <see cref="OpenDoor"/>
        /// </summary>
        /// <param name="context">Context to interpret</param>
        /// <returns>Python code</returns>
        public override string Interpret(ref XmlToPythonContext context)
        {
            base.Interpret(ref context);
            context.NextNode();
            var result = (new Values.Door().Interpret(ref context)) + "."+Literals.DoorOpen+"()";
            context.ParentNode();
            context.NextCheck();
            return result;
        }
    }
}
