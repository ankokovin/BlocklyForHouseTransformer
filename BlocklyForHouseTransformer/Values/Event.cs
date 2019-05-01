using System;
using System.Collections.Generic;
using System.Reflection;

namespace BlocklyForHouse.Transform.XmlToPython.Values
{
    public class Event : Value
    {
        public override string Interpret(XmlToPythonContext context)
        {
            base.Interpret(context);
            context.NextNode();
            return EventStarters[context.currentNode.Attributes["type"].Value].Interpret(context);
        }

        private Dictionary<string, Blocks.Block> eventStarters;

        private Dictionary<string, Blocks.Block> EventStarters
        {
            get
            {
                if (eventStarters == null)
                {
                    eventStarters = Custom_attributes.EventStarterAttribute.GetBlocks();
                }
                return eventStarters;
            }
        }
    }
}
