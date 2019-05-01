using System;
using System.Collections.Generic;
using System.Text;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    class HumiditySensor : Block
    {
        public override string Interpret(XmlToPythonContext context)
        {
            base.Interpret(context);
            context.currentNode = context.currentNode.FirstChild;
            return "hum_sensor(" + (new Values.Name()).Interpret(context) + ")";
        }
    }
}
