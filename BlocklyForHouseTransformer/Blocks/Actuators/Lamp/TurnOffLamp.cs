using System;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    [Custom_attributes.BodyCommand("off_lamp")]
    class TurnOffLamp : Block
    {
        public override string Interpret(XmlToPythonContext context)
        {
            base.Interpret(context);
            context.NextNode();
            return (new Values.Lamp().Interpret(context)) + "."+Literals.LampOff+"()\n";
        }
    }
}
