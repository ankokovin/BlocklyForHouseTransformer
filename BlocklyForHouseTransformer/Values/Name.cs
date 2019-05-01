using System;

namespace BlocklyForHouse.Transform.XmlToPython.Values
{
    public class Name : Value
    {
        public override string Interpret(ref XmlToPythonContext context)
        {
            base.Interpret(ref context);
            context.NextNode();
            var result = (new Blocks.Text()).Interpret(ref context);
            context.ParentNode();
            return result;
        }
    }
}

