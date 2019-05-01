using System;
using System.Collections.Generic;
using System.Reflection;

namespace BlocklyForHouse.Transform.XmlToPython.Values
{
    public class Event : Value
    {
        public override string Interpret(ref XmlToPythonContext context)
        {
            base.Interpret(ref context);
            context.NextNode();
            var result =  EventStarters[context.currentNode.Attributes["type"].Value].Interpret(ref context);

            context.ParentNode();
            return result;
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
