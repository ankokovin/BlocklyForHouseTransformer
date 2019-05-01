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
            context.NextNode();
            return string.Format(Literals.Call, Literals.LampCreate, (new Values.Name()).Interpret(context));
        }
    }
}
