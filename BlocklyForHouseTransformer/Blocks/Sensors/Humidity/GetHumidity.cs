using System;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    class GetHumidity : Block
    {
        public override string Interpret(XmlToPythonContext context)
        {
            base.Interpret(context);
            context.NextNode();
            return string.Format(Literals.Call, Literals.HumidityGet, (new Values.HumiditySensor()).Interpret(context));
        }
    }
}
