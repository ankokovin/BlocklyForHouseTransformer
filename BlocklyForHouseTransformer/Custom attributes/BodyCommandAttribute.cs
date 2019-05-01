using System;

namespace BlocklyForHouse.Transform.XmlToPython.Custom_attributes
{
    [System.AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    sealed class BodyCommandAttribute : FinderAttribute
    {
        
        public BodyCommandAttribute(string typeName)
        {
            this.TypeName = typeName;
            
        }
        
    }
}
