using System;
using System.Collections.Generic;
using System.Text;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    /// <summary>
    /// For xml input:
    /// <para>&lt;block type=&quot;hum_sensor&quot;&gt;</para>
    /// </summary>
    class HumiditySensor : FunctionCallBlock<Values.Name>
    {

        public override string TypeName => TypeLiteralsXml.HumiditySensor;

        protected override string FunctionLiteral => LiteralsPython.HumiditySensorCreate;

    }
}
