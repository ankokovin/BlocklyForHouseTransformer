using System;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    public class Text : Block
    {
        public override string Interpret(ref XmlToPythonContext context)
        {
            base.Interpret(ref context);
            context.NextNode();
            var result =  '"' + (new Field()).Interpret(ref context)+'"';

            context.ParentNode();
            return result;
        }
    }
}
