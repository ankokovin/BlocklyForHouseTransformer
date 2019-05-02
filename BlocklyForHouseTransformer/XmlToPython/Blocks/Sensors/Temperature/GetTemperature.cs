using System;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    /// <summary>
    /// <para>&lt;block type=&quot;tem_get&quot;&gt;</para>
    /// </summary>
    class GetTemperature : Block
    {
        public override string Interpret(ref XmlToPythonContext context)
        {
            base.Interpret(ref context);
            context.NextNode();
            var result = string.Format(LiteralsPython.Call, LiteralsPython.TemperatureGet, (new Values.TemperatureSensor()).Interpret(ref context));

            context.ParentNode();
            return result;
        }
    }
}
