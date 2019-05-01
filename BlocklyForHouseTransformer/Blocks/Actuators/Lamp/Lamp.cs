using System;
using System.Collections.Generic;
using System.Text;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    class Lamp : Block
    {
        public override string Interpret(ref XmlToPythonContext context)
        {
            base.Interpret(ref context);
            context.NextNode();
            var result = string.Format(Literals.Call, Literals.LampCreate, (new Values.Name()).Interpret(ref context));
            context.ParentNode();
            return result;
        }
    }
}
