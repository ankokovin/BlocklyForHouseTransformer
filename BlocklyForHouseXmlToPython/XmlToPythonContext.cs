﻿using System.Xml;

namespace BlocklyForHouse.Tranfrom.XmlToPython
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
        }
    }
}
