using System;
using System.Collections.Generic;
using System.Text;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    /// <summary>
    /// For xml input:
    /// <para>&lt;block type=&quot;lamp&quot;&gt;</para>
    /// </summary>
    class Lamp : FunctionCallBlock<Values.Name>
    {

        public override string TypeName => TypeLiteralsXml.Door;

        protected override string FunctionLiteral => LiteralsPython.LampCreate;
    }
}
