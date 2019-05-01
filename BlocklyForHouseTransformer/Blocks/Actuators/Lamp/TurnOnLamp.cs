using System;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    [Custom_attributes.BodyCommand("on_lamp")]
    class TurnOnLamp : Block
    {
        public override string Interpret(XmlToPythonContext context)
        {
            base.Interpret(context);
            context.currentNode = context.currentNode.FirstChild;
            return '\t' + (new Values.Lamp().Interpret(context)) + ".on()\n";
        }
    }
}
