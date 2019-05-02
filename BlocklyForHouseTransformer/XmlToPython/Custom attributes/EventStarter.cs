using System.Text;

namespace BlocklyForHouse.Transform.XmlToPython.Custom_attributes
{
    /// <summary>
    /// Attribute for blocks, used as triggers for <see cref="Blocks.Script"/>
    /// <para>Block classes are caught in <see cref="Values.Event"/> with <see cref="FinderAttribute.GetBlocks"/></para>
    /// </summary>
    [System.AttributeUsage(System.AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    sealed class EventStarterAttribute : FinderAttribute
    {
        public EventStarterAttribute(string typename)
        {
            TypeName = typename;
        }        
    }

    
}
