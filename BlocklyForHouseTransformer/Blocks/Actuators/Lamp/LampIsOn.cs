using System;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    [Custom_attributes.EventStarter("lamp_is_on")]
    class LampIsOn : Block
    {
        public override string Interpret(XmlToPythonContext context)
        {
            base.Interpret(context);
            context.NextNode();
            return (new Values.Lamp().Interpret(context)) + "."+Literals.LampIsOn+"()\n";
        }
    }
}
