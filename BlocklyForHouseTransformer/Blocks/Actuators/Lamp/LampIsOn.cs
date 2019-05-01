using System;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    [Custom_attributes.EventStarter("lamp_is_on")]
    class LampIsOn : Block
    {
        public override string Interpret(ref XmlToPythonContext context)
        {
            base.Interpret(ref context);
            context.NextNode();
            var result = (new Values.Lamp().Interpret(ref context)) + "."+Literals.LampIsOn+"()\n";
            context.ParentNode();
            return result;
        }
    }
}
