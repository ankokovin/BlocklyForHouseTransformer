using System;
using System.Collections.Generic;
using System.Text;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    /// <summary>
    /// For xml input:
    /// <para>&lt;block type=&quot;illuminance&quot;&gt;</para>
    /// </summary>
    class Illuminance : Block
    {
        public override string Interpret(ref XmlToPythonContext context)
        {
            base.Interpret(ref context);
            context.NextNode();
            var result = string.Format(Literals.Call, Literals.Illuminance, (new Field()).Interpret(ref context));
            context.ParentNode();
            return result;
        }
    }
}
