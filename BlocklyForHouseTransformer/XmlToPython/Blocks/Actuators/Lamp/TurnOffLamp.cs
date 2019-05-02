using System;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    /// <summary>
    /// For xml input:
    /// <para>&lt;block type=&quot;off_lamp&quot;&gt;</para>
    /// /// </summary>
    [Custom_attributes.BodyCommand("off_lamp")]
    class TurnOffLamp : Block
    {
        public override string Interpret(ref XmlToPythonContext context)
        {
            base.Interpret(ref context);
            context.NextNode();
            var result = (new Values.Lamp().Interpret(ref context)) + "."+LiteralsPython.LampOff+"()";
            context.ParentNode();
            context.NextCheck();
            return result;
        }
    }
}
