using System;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    /// <summary>
    /// <para>&lt;block type=&quot;tem_get&quot;&gt;</para>
    /// </summary>
    class GetTemperature : FunctionCallBlock<Values.TemperatureSensor>
    {

        public override string TypeName => TypeLiteralsXml.GetTemperature;

        protected override string FunctionLiteral => LiteralsPython.TemperatureGet;

    }
}
