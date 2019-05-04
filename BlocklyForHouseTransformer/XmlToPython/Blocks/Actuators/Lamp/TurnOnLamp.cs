using System;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    /// <summary>
    /// For xml input:
    /// <para>&lt;block type=&quot;on_lamp&quot;&gt;</para>
    /// </summary>
    [Custom_attributes.BodyCommand]
    class TurnOnLamp : MethodCallBlock<Values.Lamp>
    {

        public override string TypeName => TypeLiteralsXml.TurnOnLamp;

        protected override string FunctionLiteral => LiteralsPython.LampOn;
        
    }
}
