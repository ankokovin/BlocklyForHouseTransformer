using System;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    /// <summary>
    /// For xml input:
    /// <para>&lt;block type=&quot;lamp_is_on&quot;&gt;</para>
    /// </summary>
    [Custom_attributes.BoolneanAttribute("lamp_is_on")]
    class LampIsOn : Block
    {
        public override string Interpret(ref XmlToPythonContext context)
        {
            base.Interpret(ref context);
            context.NextNode();
            var result = (new Values.Lamp().Interpret(ref context)) + "."+LiteralsPython.LampIsOn+"()\n";
            context.ParentNode();
            return result;
        }
    }
}
