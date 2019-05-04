namespace BlocklyForHouse.Transform.XmlToPython.Custom_attributes
{
    /// <summary>
    /// Attribute for blocks, that return numeric value 
    /// </summary>
    [System.AttributeUsage(System.AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    sealed class NumberAttribute : ComparableAttribute
    {
        public NumberAttribute( )
            :base()
        {}
    }
}
