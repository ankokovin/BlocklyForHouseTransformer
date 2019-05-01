using System;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    class GetIlluminance : Block
    {
        public override string Interpret(ref XmlToPythonContext context)
        {
            base.Interpret(ref context);
            context.NextNode();
            var result =  string.Format(Literals.Call, Literals.IlluminanceGet, (new Values.IlluminanceSensor()).Interpret(ref context));
            context.ParentNode();
            return result;
        }
    }
}
