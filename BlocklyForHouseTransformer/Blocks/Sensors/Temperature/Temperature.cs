using System;
using System.Collections.Generic;
using System.Text;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    class Temperature : Block
    {
        public override string Interpret(XmlToPythonContext context)
        {
            base.Interpret(context);
            context.NextNode();
            return "temperature(" + new Values.Temperature().Interpret(context) + ")";
        }
    }
}
