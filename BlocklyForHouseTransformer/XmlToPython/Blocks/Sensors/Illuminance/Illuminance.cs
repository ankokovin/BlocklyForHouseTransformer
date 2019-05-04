using System;
using System.Collections.Generic;
using System.Text;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    /// <summary>
    /// For xml input:
    /// <para>&lt;block type=&quot;illuminance&quot;&gt;</para>
    /// </summary>
    class Illuminance : FunctionCallBlock<Field>
    {

        public override string TypeName => TypeLiteralsXml.Illuminance;

        protected override string FunctionLiteral => LiteralsPython.Illuminance;

    }
}
