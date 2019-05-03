using System.Text;

namespace BlocklyForHouse.Transform.XmlToPython.Custom_attributes
{
    /// <summary>
    /// Attribute for blocks, that return boolean value 
    /// <para>used as triggers for <see cref="Blocks.Script"/></para>
    /// <para>Block classes are caught in <see cref="Values.Event"/> with <see cref="FinderAttribute.GetBlocks"/></para>
    /// </summary>
    [System.AttributeUsage(System.AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    sealed class BoolneanAttribute : FinderAttribute
    {
        public BoolneanAttribute(string typename)
        {
            TypeName = typename;
        }        
    }


}
