using System;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    /// <summary>
    /// <para>&lt;block type=&quot;il_sensor&quot;&gt;</para>
    /// </summary>
    class IlluminanceSensor : Block
    {
        public override string Interpret(ref XmlToPythonContext context)
        {
            base.Interpret(ref context);
            context.NextNode();
            
            var result = string.Format(Literals.Call, Literals.IlluminanceSensorCreate, (new Values.Name()).Interpret(ref context));

            context.ParentNode();
            return result;
        }
    }
}
