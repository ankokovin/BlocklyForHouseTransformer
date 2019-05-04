using System;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    /// <summary>
    /// For xml input:
    /// <para>&lt;block type=&quot;hum_get&quot;&gt;</para>
    /// </summary>
    class GetHumidity : FunctionCallBlock<Values.HumiditySensor>
    {

        public override string TypeName => TypeLiteralsXml.GetHumidity;

        protected override string FunctionLiteral => LiteralsPython.HumidityGet;
    }
}
