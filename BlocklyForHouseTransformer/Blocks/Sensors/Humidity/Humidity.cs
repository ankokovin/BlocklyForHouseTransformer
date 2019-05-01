using System;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    class Humidity : Block
    {
        public override string Interpret(XmlToPythonContext context)
        {
            base.Interpret(context);
            context.NextNode();
            return string.Format(Literals.Call, Literals.Humidity, (new Field()).Interpret(context));

        }
    }
}
