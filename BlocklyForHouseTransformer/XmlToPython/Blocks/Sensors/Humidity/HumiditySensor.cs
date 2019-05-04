using System;
using System.Collections.Generic;
using System.Text;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    /// <summary>
    /// For xml input:
    /// <para>&lt;block type=&quot;hum_sensor&quot;&gt;</para>
    /// </summary>
    class HumiditySensor : Block
    {

        public override string TypeName => TypeLiteralsXml.HumiditySensor;
        public override string Interpret(ref XmlToPythonContext context)
        {
            base.Interpret(ref context);
            context.NextNode();
            var result = string.Format(LiteralsPython.Call, LiteralsPython.HumiditySensorCreate, (new Values.Name()).Interpret(ref context));
            context.ParentNode();
            return result;
        }
    }
}
