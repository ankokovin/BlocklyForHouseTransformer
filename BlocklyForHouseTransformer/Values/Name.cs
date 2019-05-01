using System;

namespace BlocklyForHouse.Transform.XmlToPython.Values
{
    public class Name : Value
    {
        public override string Interpret(XmlToPythonContext context)
        {
            base.Interpret(context);
            context.NextNode();
            return (new Blocks.Text()).Interpret(context);
        }
    }
}

