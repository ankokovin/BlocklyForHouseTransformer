using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Xml;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    /// <summary>
    /// <para>&lt;block type=&quot;temperature&quot;&gt;</para>
    /// </summary>
    [Custom_attributes.Comparable]
    class Temperature : Block
    {

        public override string TypeName => TypeLiteralsXml.Temperature;
        public override string Interpret(ref XmlToPythonContext context)
        {
            base.Interpret(ref context);


            string value = string.Empty, unit = string.Empty;
            var nodes = context.currentNode.ChildNodes;
            foreach (XmlNode node in nodes)
            {
                context.currentNode = node;
                switch (node.Name)
                {
                    case "field":
                        unit = new Field().Interpret(ref context);
                        if (!Enum.GetNames(typeof(TemperatureUnit)).Contains(unit))
                            throw new Exception("Unknown unit of temperature:"+ unit);
                        break;
                    case "value":
                        value = new Values.Number().Interpret(ref context);
                        break;
                    default:
                        throw new Exception("unexpected xml node name");
                }
            }


            var result =  string.Format(LiteralsPython.FunctionCall, LiteralsPython.Temperature, value+",\""+unit+"\"");
            
            return result;
        }
    }
}
