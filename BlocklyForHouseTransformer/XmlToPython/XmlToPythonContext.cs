using System.Xml;

namespace BlocklyForHouse.Transform.XmlToPython
{
    /// <summary>
    /// Context of transformation
    /// </summary>
    public class XmlToPythonContext
    {
        /// <summary>
        /// current xml node of context
        /// </summary>
        public XmlNode currentNode;

        /// <summary>
        /// number of space identions inside current context
        /// </summary>
        public int tabCount;

        /// <summary>
        /// Constructor for <see cref="XmlToPythonContext"/>
        /// </summary>
        /// <param name="text">Xml text</param>
        public XmlToPythonContext(string text)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(text);
            currentNode = xmlDocument.DocumentElement;
            tabCount = 0;
        }

        /// <summary>
        /// Set <see cref="currentNode"/> on first child of current node
        /// <para>Attention! Make sure there is only one child or other children are taken in consideration</para>
        /// </summary>
        public void NextNode()
        {
            currentNode = currentNode.FirstChild;
        }

        /// <summary>
        /// Set <see cref="currentNode"/> on parent node of current node
        /// <para>Attention! Make sure not to use it, when current node is <see cref="Blocks.Script"/></para>
        /// </summary>
        public void ParentNode()
        {
            currentNode = currentNode.ParentNode;
        }

        /// <summary>
        /// Check if there is next xml tag avaliable
        /// </summary>
        /// <example>
        /// Consider this input:
        /// <code>
        /// &lt;block type=&quot;smt&quot;&gt;
        /// ...
        /// &lt;next&gt;
        /// ...
        /// &lt;/next&gt;
        /// &lt;/block&gt;
        /// </code>
        /// It is much more convinient to consider the content of &quot;next&quot; as the block on same lvl
        /// For example, this is used inside <see cref="Statements.Body"/>:
        /// <code>
        /// XmlNode prev;
        /// do
        /// {
        ///     prev = context.currentNode;
        ///     result += BlocklyTransformer.AddSpaces(context.tabCount)
        ///     + (Blocks[context.currentNode.Attributes[&quot;type&quot;].Value]).Interpret(ref context) + &quot;\n&quot;;
        /// } while (prev!=context.currentNode);
        /// </code>
        /// And here is the use of <see cref="NextCheck"/> in <see cref="Blocks.OpenDoor.Interpret(ref XmlToPythonContext)"/>:
        /// <code>
        /// base.Interpret(ref context);
        /// context.NextNode();
        /// var result = (new Values.Door().Interpret(ref context)) + &quot;.&quot; + LiteralsPython.DoorOpen + &quot;()&quot;;
        /// context.ParentNode();
        /// context.NextCheck();
        /// return result;
        /// </code>
        /// Suppose we have such input:
        /// <code>
        /// &lt;block type=&quot;open_door&quot;&gt;
        /// ...
        /// &lt;next&gt;
        /// &lt;block type=&quot;open_door&quot;&gt;
        /// ...
        /// &lt;/block&gt;
        /// &lt;/next&gt;
        /// &lt;/block&gt;
        /// </code>
        /// When we will be done with first iteration inside <see cref="Statements.Body.Interpret(ref XmlToPythonContext)"/>,
        /// <see cref="XmlToPythonContext.currentNode"/> will point to next <see cref="Blocks.OpenDoor"/> block
        /// 
        /// </example>
        public void NextCheck()
        {
            if (currentNode.ChildNodes.Count > 1 && currentNode.ChildNodes[1].Name == "next")
                currentNode = currentNode.ChildNodes[1].FirstChild;
        }
    }


}
