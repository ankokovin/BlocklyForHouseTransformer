using System;

namespace BlocklyForHouse.Transform.XmlToPython.Custom_attributes
{
    /// <summary>
    /// Attribute for blocks, used as commands inside the body of <see cref="Blocks.Script"/>
    /// <para>Block classes are caught in <see cref="Statements.Body"/> with <see cref="FinderAttribute.GetBlocks"/></para>
    /// </summary>
    [System.AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    sealed class BodyCommandAttribute : FinderAttribute
    {
        
        public BodyCommandAttribute(string typeName)
            :base(typeName)
        {}
        
    }
}
