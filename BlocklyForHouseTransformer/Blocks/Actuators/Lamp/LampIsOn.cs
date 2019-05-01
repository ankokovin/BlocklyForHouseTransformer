using System;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    [Custom_attributes.EventStarter("lamp_is_on")]
    class LampIsOn : Block
    {
        public override string Interpret(XmlToPythonContext context)
        {
            base.Interpret(context);
            throw new NotImplementedException();
        }
    }
}
