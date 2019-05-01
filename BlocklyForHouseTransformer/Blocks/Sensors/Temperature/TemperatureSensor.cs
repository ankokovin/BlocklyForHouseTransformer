using System;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    class TemperatureSensor : Block
    {
        public override string Interpret(XmlToPythonContext context)
        {
            base.Interpret(context);
            context.NextNode();
            return string.Format(Literals.Call, Literals.TemperatureSensorCreate, (new Values.Name()).Interpret(context));
        
        }
    }
}
