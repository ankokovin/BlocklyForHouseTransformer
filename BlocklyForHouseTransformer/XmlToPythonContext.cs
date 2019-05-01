using System.Xml;

namespace BlocklyForHouse.Transform.XmlToPython
{
    public class XmlToPythonContext
    {
        public XmlNode currentNode;
        public int tabCount;
        public XmlToPythonContext(string text)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(text);
            currentNode = xmlDocument.DocumentElement;
            tabCount = 0;
        }


        public void NextNode()
        {
            currentNode = currentNode.FirstChild;
        }

        public void ParentNode()
        {
            currentNode = currentNode.ParentNode;
        }

        public void NextCheck()
        {
            if (currentNode.ChildNodes.Count > 1 && currentNode.ChildNodes[1].Name == "next")
                currentNode = currentNode.ChildNodes[1].FirstChild;
        }
    }


}
