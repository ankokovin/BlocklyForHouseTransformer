using System;
using System.Collections.Generic;
using System.Text;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    class Lamp : Block
    {
        public override string Interpret(XmlToPythonContext context)
        {
            base.Interpret(context);
            context.currentNode = context.currentNode.FirstChild;
            return "lamp(" + (new Values.Name()).Interpret(context) + ")";
        }
    }
}
