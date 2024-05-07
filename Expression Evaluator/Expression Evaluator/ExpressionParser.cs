using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression_Evaluator
{
    public static class ExpressionParser
    {
        public static MathExpression Parse(string input)
        {
            input = input.Trim();
            var exp = new MathExpression();
            string token = "";
            string symbols = "*+/%^";
            bool leftSiddeFlag = false;

            for (int i = 0; i<input.Length; i++)
            {

                if (char.IsDigit(input[i])) 
                {
                    token += input[i];
                    if (leftSiddeFlag && i == input.Length - 1)
                    {
                        exp.RightSideOperand = double.Parse(token);
                        break;
                    }
                }
                else if (symbols.Contains(input[i]))
                {
                    if (!leftSiddeFlag)
                    {
                        exp.LeftSideOperand = double.Parse(token);
                        leftSiddeFlag = true;
                    }
                   
                    exp.Operation = ParseMathOperation(input[i].ToString());
                    token = "";
                }
                else if (input[i] == '-' && i > 0)
                {
                    if (exp.Operation == MathOperation.None)
                    {  
                        exp.Operation = MathOperation.Subtraction;
                        //exp.LeftSideOperand = double.Parse(token);
                        //leftSiddeFlag = true;
                      
                        //token = "";
                    }
                    else
                        token += input[i];

                }
                else if (char.IsLetter(input[i]))
                {
                    leftSiddeFlag = true;
                    token += input[i];  
                }
                else if (input[i] == ' ')
                {
                    if (!leftSiddeFlag)
                    {
                        exp.LeftSideOperand = double.Parse(token);
                        leftSiddeFlag = true;
                        token = "";
                    }
                    else if (exp.Operation == MathOperation.None)
                    {
                        exp.Operation = ParseMathOperation(token);
                        token = "";
                    }

                }
                else
                {
                    token += input[i];
                }
            }

            return exp; 
        }

        private static MathOperation ParseMathOperation(string op)
        {
            switch(op.ToLower())
            {
                case "+":
                    return MathOperation.Addition;
                case "*":
                    return MathOperation.Multiplication;
                case "/":
                    return MathOperation.Division;
                case "%":
                case "mod":
                    return MathOperation.Modulus;
                case "^":
                case "pow":
                    return MathOperation.Power;
                case "sin":
                    return MathOperation.Sin;
                case "cos":
                    return MathOperation.Cos;
                case "tan":
                    return MathOperation.Tan;
                default:
                    return MathOperation.None;
            }
        }
    }
}
