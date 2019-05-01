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
            /* TODO: механизм проверки, какой тип ноды, чтобы перебрать и найти его
             * Возможно Dictionary
             * foreach (var block in getEventStarters())
            {
                
            }*/
            return (new Blocks.DoorIsOpen().Interpret(context));
        }

        private IEnumerable<Blocks.Block> getEventStarters()
        {
            //TODO: строить список через рефлексию?
            yield return  new Blocks.DoorIsOpen();
        }
    }
}
