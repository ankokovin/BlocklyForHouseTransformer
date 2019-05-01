using System.Xml;

namespace BlocklyForHouse.Tranfrom.XmlToPython.Blocks
{
    public class Script : Block
    {
        public override string Interpret(XmlToPythonContext context)
        {
            base.Interpret(context);
            var node = context.currentNode;
            string result = Literals.ScriptPythonLiteral.Import;
            string ev = string.Empty;
            string body = string.Empty;
            string name = "None";
            foreach (XmlNode item in node.ChildNodes)
            {
                context.currentNode = item;
                switch (item.Attributes["name"].Value)
                {
                    case "NAME":
                        name = (new Values.Name()).Interpret(context);
                        break;
                    case "EVENT":
                        ev = (new Values.Event()).Interpret(context);
                        break;
                    case "BODY":
                        body = (new Statements.Body()).Interpret(context);
                        break;
                    
                }
            }
            result += Literals.ScriptPythonLiteral.Event;
            if (string.IsNullOrEmpty(ev))
                result += Literals.ScriptPythonLiteral.EmptyEvent;
            else
                result += ev;

            result += Literals.ScriptPythonLiteral.Body;
            if (string.IsNullOrEmpty(body))
                result += Literals.ScriptPythonLiteral.EmptyBody;
            else
                result += body;

            result += Literals.ScriptPythonLiteral.Addition_start + name + Literals.ScriptPythonLiteral.Addition_end;

            return result;
        }
    }
}
