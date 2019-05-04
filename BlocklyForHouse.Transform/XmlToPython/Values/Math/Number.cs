using System;
using System.Collections.Generic;
using System.Text;

namespace BlocklyForHouse.Transform.XmlToPython.Values
{
    class Number : Value
    {
        public override string Interpret(ref XmlToPythonContext context)
        {
            base.Interpret(ref context);
            //TODO: create finder attribute for numbers, that are not just math_number
            context.NextNode();
            var result = (new Blocks.Math.Number()).Interpret(ref context);
            context.ParentNode();
            return result;
        }
    }
}
