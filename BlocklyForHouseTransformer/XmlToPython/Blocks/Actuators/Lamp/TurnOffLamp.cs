using System;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    /// <summary>
    /// For xml input:
    /// <para>&lt;block type=&quot;off_lamp&quot;&gt;</para>
    /// /// </summary>
    [Custom_attributes.BodyCommand]
    class TurnOffLamp : MethodCallBlock<Values.Lamp>
    {

        public override string TypeName => TypeLiteralsXml.TurnOffLamp;

        protected override string FunctionLiteral => LiteralsPython.LampOff;

        protected override bool NeedNextCheck => true;
    }
}
