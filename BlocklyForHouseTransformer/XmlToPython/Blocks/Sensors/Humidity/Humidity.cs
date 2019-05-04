using System;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    /// <summary>
    /// For xml input:
    /// <para>&lt;block type=&quot;humidity&quot;&gt;</para>
    /// </summary>
    class Humidity : FunctionCallBlock<Field>
    {

        public override string TypeName => TypeLiteralsXml.Humidity;

        protected override string FunctionLiteral => LiteralsPython.Humidity;

    }
}
