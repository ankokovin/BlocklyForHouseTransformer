using System;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    /// <summary>
    /// For xml input:
    /// <para>&lt;block type=&quot;hum_get&quot;&gt;</para>
    /// </summary>
    class GetHumidity : Block
    {

        public override string TypeName => TypeLiteralsXml.GetHumidity;
        public override string Interpret(ref XmlToPythonContext context)
        {
            base.Interpret(ref context);
            context.NextNode();
            var result = string.Format(LiteralsPython.FunctionCall, LiteralsPython.HumidityGet, (new Values.HumiditySensor()).Interpret(ref context));
            context.ParentNode();
            return result;
        }
    }
}
