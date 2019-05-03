using System;
using System.Collections.Generic;
using System.Reflection;

namespace BlocklyForHouse.Transform.XmlToPython.Values
{
    /// <summary>
    /// <para>&lt;value type=&quot;event&quot;&gt;</para>
    /// <para>used inside <see cref="Blocks.Script"/></para>
    /// </summary>
    public class Event : Value
    {
        /// <summary>
        /// Interpret context as <see cref="Event"/>
        /// </summary>
        /// <param name="context">Context to interpret</param>
        /// <returns>Python code</returns>
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
                    eventStarters = Custom_attributes.FinderAttribute
                        .GetBlocks<Custom_attributes.BoolneanAttribute>();
                }
                return eventStarters;
            }
        }
    }
}
