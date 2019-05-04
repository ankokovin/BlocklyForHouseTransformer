namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    /// <summary>
    /// Class of block which are simple function calls
    /// </summary>
    /// <typeparam name="InputValueType">Input value type</typeparam>
    public abstract class FunctionCallBlock<InputValueType> : Block
         where InputValueType : AbstractExpression, new()
    {
        /// <summary>
        /// Literal for function
        /// </summary>
        protected abstract string FunctionLiteral { get; }

        /// <summary>
        /// Interpret context as <see cref="FunctionCallBlock{InputValueType}"/>
        /// </summary>
        /// <param name="context">Context to interpret</param>
        /// <returns>Python code</returns>
        public override string Interpret(ref XmlToPythonContext context)
        {
            base.Interpret(ref context);
            context.NextNode();
            var result = string.Format(LiteralsPython.FunctionCall, FunctionLiteral, (new InputValueType()).Interpret(ref context));
            context.ParentNode();
            return result;
        }


    }
}
