using System;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    class GetTemperature : Block
    {
        public override string Interpret(ref XmlToPythonContext context)
        {
            base.Interpret(ref context);
            context.NextNode();
            var result = string.Format(Literals.Call, Literals.TemperatureGet, (new Values.TemperatureSensor()).Interpret(ref context));

            context.ParentNode();
            return result;
        }
    }
}
