using System;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    class GetTemperature : Block
    {
        public override string Interpret(XmlToPythonContext context)
        {
            base.Interpret(context);
            context.NextNode();
            return string.Format(Literals.Call, Literals.TemperatureGet, (new Values.TemperatureSensor()).Interpret(context));

        }
    }
}
