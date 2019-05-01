using System;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    [Custom_attributes.BodyCommand("off_lamp")]
    class TurnOffLamp : Block
    {
        public override string Interpret(XmlToPythonContext context)
        {
            base.Interpret(context);
            context.currentNode = context.currentNode.FirstChild;
            return '\t' + (new Values.Lamp().Interpret(context)) + ".off()\n";
        }
    }
}
