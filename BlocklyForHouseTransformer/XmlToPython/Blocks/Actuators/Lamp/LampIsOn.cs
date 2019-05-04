using System;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    /// <summary>
    /// For xml input:
    /// <para>&lt;block type=&quot;lamp_is_on&quot;&gt;</para>
    /// </summary>
    [Custom_attributes.Boolean]
    class LampIsOn : MethodCallBlock<Values.Lamp>
    {

        public override string TypeName => TypeLiteralsXml.LampIsOn;

        protected override string FunctionLiteral => LiteralsPython.LampIsOn;

        protected override bool NeedNextCheck => false;
    }
}
