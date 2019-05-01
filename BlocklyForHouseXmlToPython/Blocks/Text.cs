using System;

namespace BlocklyForHouse.Tranfrom.XmlToPython.Blocks
{
    public class Text : Block
    {
        public override string Interpret(XmlToPythonContext context)
        {
            base.Interpret(context);
            context.currentNode = context.currentNode.FirstChild;
            return '"' + (new Field()).Interpret(context)+'"';
        }
    }
}
