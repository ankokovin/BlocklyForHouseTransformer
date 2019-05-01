using System;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    class IlluminanceSensor : Block
    {
        public override string Interpret(ref XmlToPythonContext context)
        {
            base.Interpret(ref context);
            context.NextNode();
            
            var result = string.Format(Literals.Call, Literals.IlluminanceSensorCreate, (new Values.Name()).Interpret(ref context));

            context.ParentNode();
            return result;
        }
    }
}
