namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    /// <summary>
    /// For xml input:
    /// <para>&lt;block type=&quot;close_door&quot;&gt;</para>
    /// </summary>
    [Custom_attributes.BodyCommand("close_door")]
    public class CloseDoor : Block
    {
        /// <summary>
        /// Interpret context as <see cref="CloseDoor"/>
        /// </summary>
        /// <param name="context">Context to interpret</param>
        /// <returns>Python code</returns>
        public override string Interpret(ref XmlToPythonContext context)
        {
            base.Interpret(ref context);
            context.NextNode();
            var result = (new Values.Door().Interpret(ref context)) + "."+Literals.DoorClose+"()";
            context.ParentNode();
            context.NextCheck();
            return result;
        }
    }
}
