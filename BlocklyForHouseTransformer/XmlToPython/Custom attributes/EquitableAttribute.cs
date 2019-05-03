namespace BlocklyForHouse.Transform.XmlToPython.Custom_attributes
{
    /// <summary>
    /// for blocks, that can be checked if they are equal
    /// </summary>
    [System.AttributeUsage(System.AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    class EquitableAttribute : FinderAttribute
    {
        public EquitableAttribute(string typename)
            :base(typename)
        {}
    }
}
