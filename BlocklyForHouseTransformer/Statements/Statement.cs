﻿namespace BlocklyForHouse.Transform.XmlToPython.Statements
{
    public abstract class Statement : AbstractExpression
    {
        public override string Interpret(ref XmlToPythonContext context)
        {
            System.Diagnostics.Debug.Assert(context.currentNode.Name == "statement");
            return null;
        }
    }
}
