using System;

namespace SimpleCalculator
{
    public class InputValidation
    {
        public static string validateCommand(string[] args)
        {
            string myOperator = "";
            string firstOp = "", secondOp = "";
            int firstOpNum, secondOpNum;
            firstOp = args[0];
            bool isNumeric1 = int.TryParse(firstOp, out firstOpNum);

            // check if args[] contains exit command || last/lastq command
            if (args.Length == 1)
            {
                if (!isNumeric1 && firstOp.Length > 1)
                {
                    switch (firstOp)
                    {
                        case "exit":
                        case "quit":
                            return "exit";
                        case "last":
                            return "last";
                        case "lastq":
                            return "lastq";
                        default:
                            return "invalid";
                    }
                }
                // check if args[] contains existing constant
                else if (!isNumeric1 && firstOp.Length == 1)
                {
                    return "getConstant";
                }
                else return "invalid";
            }
            else
            {
                myOperator = args[1];
                secondOp = args[2];
                bool isNumeric2 = int.TryParse(secondOp, out secondOpNum);

                if (myOperator == "=")
                {
                    // Check if constant is being assigned an int
                    if (Char.IsLetter(firstOp, 0) && firstOp.Length == 1 && isNumeric2)
                    {
                        return "saveConstant";
                    }
                    else return "invalid";
                }
                // check if args[] contains invalid user input (constant longer than one char)
                else
                {
                    if ((!isNumeric1 && firstOp.Length > 1) || (!isNumeric2 && secondOp.Length > 1))
                    {
                        return "invalid";
                    }
                    else return "calculate";
                }
            }
        }
    }
}
