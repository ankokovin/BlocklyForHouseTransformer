using System;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    /// <summary>
    /// <para>&lt;block type=&quot;tem_sensor&quot;&gt;</para>
    /// </summary>
    class TemperatureSensor : Block
    {

        public override string TypeName => TypeLiteralsXml.TemperatureSensor;
        public override string Interpret(ref XmlToPythonContext context)
        {
            base.Interpret(ref context);
            context.NextNode();
            var result = string.Format(LiteralsPython.FunctionCall, LiteralsPython.TemperatureSensorCreate, (new Values.Name()).Interpret(ref context));

            context.ParentNode();
            return result;
        }
    }
}
