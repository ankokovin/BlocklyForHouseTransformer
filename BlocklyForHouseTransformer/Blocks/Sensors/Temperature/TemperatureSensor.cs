using System;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    class TemperatureSensor : Block
    {
        public override string Interpret(ref XmlToPythonContext context)
        {
            base.Interpret(ref context);
            context.NextNode();
            var result = string.Format(Literals.Call, Literals.TemperatureSensorCreate, (new Values.Name()).Interpret(ref context));

            context.ParentNode();
            return result;
        }
    }
}
