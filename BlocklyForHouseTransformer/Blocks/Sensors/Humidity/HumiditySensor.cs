using System;
using System.Collections.Generic;
using System.Text;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    class HumiditySensor : Block
    {
        public override string Interpret(ref XmlToPythonContext context)
        {
            base.Interpret(ref context);
            context.NextNode();
            var result = string.Format(Literals.Call, Literals.HumiditySensorCreate, (new Values.Name()).Interpret(ref context));
            context.ParentNode();
            return result;
        }
    }
}
