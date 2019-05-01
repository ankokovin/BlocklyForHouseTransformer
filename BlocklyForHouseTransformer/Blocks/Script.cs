using System.Xml;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    public class Script : Block
    {
        public override string Interpret(XmlToPythonContext context)
        {
            base.Interpret(context);
            var node = context.currentNode;
            string result = string.Format(Literals.Import,Literals.PackageName)+'\n';
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

            result += '\n';
            result += Literals.Event+"\n"+BlocklyTransformer.AddSpaces(1)+Literals.EventStart;
            if (string.IsNullOrEmpty(ev))
                result += Literals.EmptyEvent;
            else
                result += ev;

            result += '\n';
            result += Literals.Body + "\n";
            if (string.IsNullOrEmpty(body))
                result += BlocklyTransformer.AddSpaces(1) + Literals.EmptyBody;
            else
                result += body;

            result += '\n';
            result += string.Format(Literals.AddScript, name);

            return result;
        }
    }
}
