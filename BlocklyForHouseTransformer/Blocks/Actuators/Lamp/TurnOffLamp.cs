using System;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    [Custom_attributes.BodyCommand("off_lamp")]
    class TurnOffLamp : Block
    {
        public override string Interpret(ref XmlToPythonContext context)
        {
            base.Interpret(ref context);
            context.NextNode();
            var result = (new Values.Lamp().Interpret(ref context)) + "."+Literals.LampOff+"()";
            context.ParentNode();
            context.NextCheck();
            return result;
        }
    }
}
