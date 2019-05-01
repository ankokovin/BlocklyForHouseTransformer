using System;
using System.Collections.Generic;

namespace BlocklyForHouse.Tranfrom.XmlToPython.Values
{
    public class Event : Value
    {
        public override string Interpret(XmlToPythonContext context)
        {
            base.Interpret(context);
            context.currentNode = context.currentNode.FirstChild;
            return EventStarters[context.currentNode.Attributes["type"].Value].Interpret(context);
        }

        private Dictionary<string, Blocks.Block> EventStarters = new Dictionary<string, Blocks.Block>
        {
            ["door_is_open"] = new Blocks.DoorIsOpen(),
        };
        
    }
}
