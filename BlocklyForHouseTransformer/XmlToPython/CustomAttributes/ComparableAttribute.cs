namespace BlocklyForHouse.Transform.XmlToPython.Custom_attributes
{
    /// <summary>
    /// for blocks, that can be compared
    /// </summary>
    [System.AttributeUsage(System.AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    class ComparableAttribute : EquitableAttribute
    {
        public ComparableAttribute( )
            :base()
        {}
    }
}
