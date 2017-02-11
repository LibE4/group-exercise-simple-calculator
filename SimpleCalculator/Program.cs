using System;

namespace SimpleCalculator
{
    class Program
    {
        public static void Main(string[] args)
        {

            Storage storage = new Storage();
            int counter = 0;
            string myOperator = "";
            string currentCommand = "", firstOp = "", secondOp = "";
            int firstOpNum, secondOpNum, calcResult = 0;

            START:
            Console.WriteLine($"[{counter}]>");
            currentCommand = Console.ReadLine();

            // Return string[]{3} of operands/operator, or string[]{1} of constant
            var commandKeys = Expression.getMathExpression(currentCommand);

            firstOp = commandKeys[0];
            bool isNumeric1 = int.TryParse(firstOp, out firstOpNum);

            // Return desired "action" to trigger desired case
            var action = InputValidation.validateCommand(commandKeys);
            switch (action)
            {
                case "invalid":
                    Console.WriteLine("Invalid command");
                    break;
                case "exit":
                    goto END;
                case "last":
                    Console.WriteLine(storage.last);
                    break;
                case "lastq":
                    Console.WriteLine(storage.lastq);
                    break;
                case "getConstant":
                    if (Storage.myConstants.ContainsKey(firstOp))
                    {
                        Console.WriteLine(Storage.myConstants[firstOp]);
                    }
                    else
                    {
                        Console.WriteLine($"Constant '{firstOp}' does not exist!");
                    }
                    break;
                default:
                    myOperator = commandKeys[1];
                    secondOp = commandKeys[2];
                    bool isNumeric2 = int.TryParse(secondOp, out secondOpNum);
                    switch (action)
                    {
                        case "saveConstant":
                            if (Storage.myConstants.ContainsKey(firstOp))
                            {
                                Console.WriteLine($"Error! Constant '{firstOp}' already saved.");
                            }
                            else
                            {
                                Console.WriteLine($"'{firstOp}' saved as '{secondOpNum}'");
                                Storage.myConstants[firstOp] = secondOpNum;
                            }
                            break;
                        case "calculate":

                            // confirm constant exists before attempting to calculate
                            if (!isNumeric1)
                            {
                                if (Storage.myConstants.ContainsKey(firstOp))
                                {
                                    firstOpNum = Storage.myConstants[firstOp];
                                }
                                else
                                {
                                    Console.WriteLine($"Constant '{firstOp}' does not exist!");
                                }
                            }
                            if (!isNumeric2)
                            {
                                if (Storage.myConstants.ContainsKey(secondOp))
                                {
                                    secondOpNum = Storage.myConstants[secondOp];
                                }
                                else
                                {
                                    Console.WriteLine($"Constant '{secondOp}' does not exist!");
                                }
                            }
                            calcResult = Calculator.calculate(firstOpNum, secondOpNum, myOperator);

                            // utilize Storage to save calculation outcome
                            storage.last = calcResult;
                            Console.WriteLine(calcResult);
                            break;
                    }
                    break;
            }

            // utilize Storage to save last valid user input calculation (unless user has typed "last" || "lastq" commands)
            if (currentCommand.ToLower() != "last" && currentCommand.ToLower() != "lastq")
            {
                storage.lastq = currentCommand;
            }
            counter++;
            goto START;

            END:
            Console.WriteLine("Bye!");

        }
    }
}
