using System;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    class Humidity : Block
    {
        public override string Interpret(XmlToPythonContext context)
        {
            base.Interpret(context);
            context.currentNode = context.currentNode.FirstChild;
            return "humidity(" + (new Field()).Interpret(context) + ")";
        }
    }
}
