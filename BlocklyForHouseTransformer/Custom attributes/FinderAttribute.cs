using System;
using System.Collections.Generic;
using System.Reflection;

namespace BlocklyForHouse.Transform.XmlToPython.Custom_attributes
{
    abstract class FinderAttribute : Attribute
    {
        public string TypeName;
        public static Dictionary<string, Blocks.Block> GetBlocks<T>() where T : FinderAttribute
        {
            var eventStarters = new Dictionary<string, Blocks.Block>();
            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                foreach (var type in assembly.GetTypes())
                {

                    if (type.GetCustomAttribute(
                        MethodBase.GetCurrentMethod().DeclaringType, false) is T atr)
                    {
                        if (!type.IsSubclassOf(typeof(Blocks.Block)))
                            throw new Exception(MethodBase.GetCurrentMethod().DeclaringType + " on class, which is not subclass of Block");
                        eventStarters.Add(atr.TypeName, Activator.CreateInstance(type) as Blocks.Block);
                    }
                }

            }
            return eventStarters;
        }
    }
}
