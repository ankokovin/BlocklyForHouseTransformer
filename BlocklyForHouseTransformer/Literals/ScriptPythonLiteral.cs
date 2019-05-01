namespace BlocklyForHouse.Transform.XmlToPython.Literals
{
    public static class ScriptPythonLiteral
    {
        public static string Library = "BlocklyForHousePython";
        public static string Import = "import " + Library+'\n';
        public static string Event = "def event():\n\treturn";
        public static string EmptyEvent = "\tresult False" + '\n';
        public static string Body = "def body():" + '\n';
        public static string EmptyBody = "\tpass" + '\n';
        public static string Addition_start = "add_script(";
        public static string Addition_end = ",event,body)" + '\n';
    }
}
