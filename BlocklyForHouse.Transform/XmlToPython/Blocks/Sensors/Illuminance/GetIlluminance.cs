using System;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    /// <summary>
    /// For xml input:
    /// <para>&lt;block type=&quot;il_get&quot;&gt;</para>
    /// /// </summary>
    class GetIlluminance : FunctionCallBlock<Values.IlluminanceSensor>
    {

        public override string TypeName => TypeLiteralsXml.GetIlluminance;

        protected override string FunctionLiteral => LiteralsPython.IlluminanceGet;

    }
}
