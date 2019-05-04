﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace BlocklyForHouse.Transform.XmlToPython.Custom_attributes
{
    /// <summary>
    /// Attribute for blocks, which should be found for detection
    /// </summary>
    abstract class XmlTypeAttribute : Attribute 
    {



        /// <summary>
        /// Find all classes of <see cref="Blocks.Block"/> with some <see cref="XmlTypeAttribute"/> T
        /// </summary>
        /// <typeparam name="T">Attribute, which implements <see cref="XmlTypeAttribute"/></typeparam>
        /// <returns>Dictionary of <see cref="Blocks.Block"/> with keys - <see cref="TypeName"/></returns>
        public static Dictionary<string, Blocks.Block> GetBlocks<T>() where T : XmlTypeAttribute
        {
            var eventStarters = new Dictionary<string, Blocks.Block>();
            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                foreach (var type in assembly.GetTypes())
                {
                    var atr = type.GetCustomAttributes().Where(x => x is T).FirstOrDefault() as T;
                    if (atr != null)
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