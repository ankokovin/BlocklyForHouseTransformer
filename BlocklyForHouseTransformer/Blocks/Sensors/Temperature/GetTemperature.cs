using System;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    class GetTemperature : Block
    {
        public override string Interpret(XmlToPythonContext context)
        {
            base.Interpret(context);
            context.NextNode();
            return "tem_get(" + (new Values.TemperatureSensor()).Interpret(context)+")";
        }
    }
}
