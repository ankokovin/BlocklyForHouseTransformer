using System;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    class Humidity : Block
    {
        public override string Interpret(ref XmlToPythonContext context)
        {
            base.Interpret(ref context);
            context.NextNode();
            var result =  string.Format(Literals.Call, Literals.Humidity, (new Field()).Interpret(ref context));
            context.ParentNode();
            return result;
        }
    }
}
