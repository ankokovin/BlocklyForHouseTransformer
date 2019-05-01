using System;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    [Custom_attributes.EventStarter("lamp_is_on")]
    class LampIsOn : Block
    {
        public override string Interpret(XmlToPythonContext context)
        {
            base.Interpret(context);
            context.currentNode = context.currentNode.FirstChild;
            return '\t' + (new Values.Lamp().Interpret(context)) + ".is_open()\n";
        }
    }
}
