using System;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    [Custom_attributes.BodyCommand("on_lamp")]
    class TurnOnLamp : Block
    {
        public override string Interpret(ref XmlToPythonContext context)
        {
            base.Interpret(ref context);
            context.NextNode();
            var result =  (new Values.Lamp().Interpret(ref context)) + "."+Literals.LampOn+"()";
            context.ParentNode();
            context.NextCheck();
            return result;
        }
    }
}
