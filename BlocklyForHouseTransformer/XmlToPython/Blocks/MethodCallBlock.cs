namespace BlocklyForHouse.Transform.XmlToPython.Blocks
{
    /// <summary>
    /// Class of block which are simple function calls
    /// </summary>
    /// <typeparam name="InputValueType">Input value type</typeparam>
    public abstract class MethodCallBlock<InputValueType> : Block
        where InputValueType:Values.Value, new()
    {
        /// <summary>
        /// Literal for function
        /// </summary>
        protected abstract string FunctionLiteral { get; }

        /// <summary>
        /// Is it needed to call <see cref="XmlToPythonContext.NextCheck"/>
        /// <para>Intended use - put constant value</para>
        /// </summary>
        protected abstract bool NeedNextCheck { get; }

        /// <summary>
        /// Interpret context as <see cref="MethodCallBlock{InputValueType}"/>
        /// </summary>
        /// <param name="context">Context to interpret</param>
        /// <returns>Python code</returns>
        public override string Interpret(ref XmlToPythonContext context)
        {
            base.Interpret(ref context);
            context.NextNode();
            var result = string.Format(LiteralsPython.MethodCall,(new InputValueType()).Interpret(ref context),FunctionLiteral);
            context.ParentNode();
            if (NeedNextCheck)
                context.NextCheck();
            return result;
        }

    }
}
