using System;

namespace BlocklyForHouse.Tranfrom.XmlToPython.Values
{
    public class Name : Value
    {
        public override string Interpret(XmlToPythonContext context)
        {
            base.Interpret(context);
            context.currentNode = context.currentNode.FirstChild;
            return (new Blocks.Text()).Interpret(context);
        }
    }
}

