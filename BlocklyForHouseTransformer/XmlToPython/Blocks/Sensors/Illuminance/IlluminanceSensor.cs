using System;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    /// <summary>
    /// <para>&lt;block type=&quot;il_sensor&quot;&gt;</para>
    /// </summary>
    class IlluminanceSensor : FunctionCallBlock<Values.Name>
    {

        public override string TypeName => TypeLiteralsXml.IlluminanceSensor;

        protected override string FunctionLiteral => LiteralsPython.IlluminanceSensorCreate;

    }
}
