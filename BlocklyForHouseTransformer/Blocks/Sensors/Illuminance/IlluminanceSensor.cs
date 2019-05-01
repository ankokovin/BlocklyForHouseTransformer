using System;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    class IlluminanceSensor : Block
    {
        public override string Interpret(XmlToPythonContext context)
        {
            base.Interpret(context);
            context.NextNode();
            
            return string.Format(Literals.Call, Literals.IlluminanceSensorCreate, (new Values.Name()).Interpret(context));

        }
    }
}
