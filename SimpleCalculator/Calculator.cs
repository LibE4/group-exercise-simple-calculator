namespace SimpleCalculator
{
    public class Calculator
    {
        public static int calculate(int firstOpNum, int secondOpNum, string myOperator)
        {
            switch (myOperator)
            {
                case "+":
                    return CalcMath.Add(firstOpNum, secondOpNum);
                case "-":
                    return CalcMath.Subtract(firstOpNum, secondOpNum);
                case "/":
                    return CalcMath.Divide(firstOpNum, secondOpNum);
                case "*":
                    return CalcMath.Multiply(firstOpNum, secondOpNum);
                case "%":
                    return CalcMath.Modulus(firstOpNum, secondOpNum);
                default:
                    return 0;
            }
        }
    }
}
