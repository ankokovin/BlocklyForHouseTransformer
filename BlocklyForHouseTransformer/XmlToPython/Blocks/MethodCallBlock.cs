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
        /// <para>By default it is set to true only if block has attribute <see cref="Custom_attributes.BodyCommandAttribute"/></para>
        /// </summary>
        protected virtual bool NeedNextCheck => 
            GetType().GetCustomAttributes(typeof(Custom_attributes.BodyCommandAttribute),false).Length == 1;


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
