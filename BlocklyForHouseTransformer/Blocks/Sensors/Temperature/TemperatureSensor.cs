using System;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    class TemperatureSensor : Block
    {
        public override string Interpret(XmlToPythonContext context)
        {
            base.Interpret(context);
            context.NextNode();
            return "tem_sensor(" + new Values.Name().Interpret(context) + ")";
        }
    }
}
