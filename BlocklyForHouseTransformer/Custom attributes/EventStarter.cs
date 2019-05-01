using System.Text;

namespace BlocklyForHouse.Transform.XmlToPython.Custom_attributes
{

    [System.AttributeUsage(System.AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    sealed class EventStarterAttribute : FinderAttribute
    {
        public EventStarterAttribute(string typename)
        {
            TypeName = typename;
        }        
    }

    
}
