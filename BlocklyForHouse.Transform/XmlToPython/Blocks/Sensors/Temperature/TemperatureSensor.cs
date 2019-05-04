using System;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    /// <summary>
    /// <para>&lt;block type=&quot;tem_sensor&quot;&gt;</para>
    /// </summary>
    class TemperatureSensor : FunctionCallBlock<Values.Name>
    {

        public override string TypeName => TypeLiteralsXml.TemperatureSensor;

        protected override string FunctionLiteral => LiteralsPython.TemperatureSensorCreate;

    }
}
