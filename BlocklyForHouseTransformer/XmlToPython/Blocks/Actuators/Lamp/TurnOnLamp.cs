using System;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    /// <summary>
    /// For xml input:
    /// <para>&lt;block type=&quot;on_lamp&quot;&gt;</para>
    /// </summary>
    [Custom_attributes.BodyCommand]
    class TurnOnLamp : Block
    {

        public override string TypeName => TypeLiteralsXml.TurnOnLamp;
        public override string Interpret(ref XmlToPythonContext context)
        {
            base.Interpret(ref context);
            context.NextNode();
            var result =  (new Values.Lamp().Interpret(ref context)) + "."+LiteralsPython.LampOn+"()";
            context.ParentNode();
            context.NextCheck();
            return result;
        }
    }
}
