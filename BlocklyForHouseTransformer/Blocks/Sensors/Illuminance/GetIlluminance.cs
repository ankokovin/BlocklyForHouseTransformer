using System;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    class GetIlluminance : Block
    {
        public override string Interpret(XmlToPythonContext context)
        {
            base.Interpret(context);
            context.NextNode();
            return "il_get(" + (new Values.IlluminanceSensor()).Interpret(context) + ")";
        }
    }
}
