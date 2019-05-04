using System;
using System.Collections.Generic;
using System.Text;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    /// <summary>
    /// <para>&lt;block type=&quot;temperature&quot;&gt;</para>
    /// </summary>
    class Temperature : Block
    {

        public override string TypeName => TypeLiteralsXml.Temperature;
        public override string Interpret(ref XmlToPythonContext context)
        {
            base.Interpret(ref context);
            context.NextNode();
            
            var result =  string.Format(LiteralsPython.Call, LiteralsPython.Temperature, (new Values.Temperature()).Interpret(ref context));

            context.ParentNode();
            return result;
        }
    }
}
