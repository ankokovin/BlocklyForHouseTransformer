using System;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    public class Text : Block
    {
        public override string Interpret(XmlToPythonContext context)
        {
            base.Interpret(context);
            context.NextNode();
            return '"' + (new Field()).Interpret(context)+'"';
        }
    }
}
