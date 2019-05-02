using System;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    /// <summary>
    /// For xml input:
    /// <para>&lt;block type=&quot;il_get&quot;&gt;</para>
    /// /// </summary>
    class GetIlluminance : Block
    {
        public override string Interpret(ref XmlToPythonContext context)
        {
            base.Interpret(ref context);
            context.NextNode();
            var result =  string.Format(LiteralsPython.Call, LiteralsPython.IlluminanceGet, (new Values.IlluminanceSensor()).Interpret(ref context));
            context.ParentNode();
            return result;
        }
    }
}
