using System;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    class GetHumidity : Block
    {
        public override string Interpret(XmlToPythonContext context)
        {
            base.Interpret(context);
            context.currentNode = context.currentNode.FirstChild;
            return "hum_get(" + (new Values.HumiditySensor()).Interpret(context) + ")";
        }
    }
}
