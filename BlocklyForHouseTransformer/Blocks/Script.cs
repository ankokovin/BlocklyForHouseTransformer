using System.Xml;

namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    /// <summary>
    /// <para>&lt;block type=&quot;script&quot;&gt;</para>
    /// </summary>
    public class Script : Block
    {
        /// <summary>
        /// Interpret context as <see cref="Script"/>
        /// </summary>
        /// <param name="context">Context to interpret</param>
        /// <returns>Python code</returns>
        public override string Interpret(ref XmlToPythonContext context)
        {
            base.Interpret(ref context);
            var node = context.currentNode;
            //add imports
            string result = string.Format(Literals.Import,Literals.PackageName)+'\n';
            string ev = string.Empty;
            string body = string.Empty;
            string name = "None";
            foreach (XmlNode item in node.ChildNodes)
            {
                context.currentNode = item;
                switch (item.Attributes["name"].Value)
                {
                    //name of script
                    case "NAME":
                        name = (new Values.Name()).Interpret(ref context);
                        break;
                    //event of script
                    case "EVENT":
                        ev = (new Values.Event()).Interpret(ref context);
                        break;
                    //body of script
                    case "BODY":
                        body = (new Statements.Body()).Interpret(ref context);
                        break;
                    
                }
            }
            //declare event of script
            result += '\n';
            result += Literals.Event+"\n"+BlocklyTransformer.AddSpaces(1)+Literals.EventStart;
            if (string.IsNullOrEmpty(ev))
                result += Literals.EmptyEvent;
            else
                result += ev;

            //declare body of script
            result += "\n\n";
            result += Literals.Body + "\n";
            if (string.IsNullOrEmpty(body))
                result += BlocklyTransformer.AddSpaces(1) + Literals.EmptyBody;
            else
                result += body;

            //declare script with name, event and body
            result += '\n';
            result += string.Format(Literals.AddScript, name);

            return result;
        }
    }
}
