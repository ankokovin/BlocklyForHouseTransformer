using System;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    class IlluminanceSensor : Block
    {
        public override string Interpret(XmlToPythonContext context)
        {
            base.Interpret(context);
            context.NextNode();
            return "il_sensor(" + (new Values.Name()).Interpret(context) + ")";
        }
    }
}
