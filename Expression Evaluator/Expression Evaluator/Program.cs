namespace Expression_Evaluator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) { 
                Console.Write("Enter the math Expression: ");
                var exp = ExpressionParser.Parse(Console.ReadLine());

                Console.WriteLine($"left operand {exp.LeftSideOperand}  operation {exp.Operation}  right operand {exp.RightSideOperand}");

                Console.WriteLine($"Expression result = {EvaluateExpression(exp)}");

                Console.WriteLine("===================================== \n");
            }
        }

        static double EvaluateExpression(MathExpression exp)
        {
            switch(exp.Operation)
            {
                case MathOperation.Addition: 
                    return exp.LeftSideOperand + exp.RightSideOperand;
                case MathOperation.Subtraction:
                    return exp.LeftSideOperand - exp.RightSideOperand;  
                case MathOperation.Division:
                    return exp.LeftSideOperand / exp.RightSideOperand;  
                case MathOperation.Multiplication:
                    return exp.RightSideOperand * exp.LeftSideOperand;
                case MathOperation.Modulus:
                    return exp.LeftSideOperand % exp.RightSideOperand;
                case MathOperation.Power:
                    return Math.Pow(exp.LeftSideOperand, exp.RightSideOperand);
                case MathOperation.Sin:
                    return Math.Sin(exp.RightSideOperand);
                case MathOperation.Cos:
                    return Math.Cos(exp.RightSideOperand);
                case MathOperation.Tan:
                    return Math.Tan(exp.RightSideOperand);
                default:
                    return 0;

            }
        }
    }
}
