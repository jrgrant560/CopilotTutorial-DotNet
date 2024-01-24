using System;


namespace CopilotTutorial
{
    class Program
    {
        // static void Main(string[] args)
        // {
        // 1) This method sends parameters to CalcAdd,
        // 2) then CalcAdd runs the operation and returns the result to Program,
        // 3) then Program writes the result to the console
        // Console.WriteLine("Enter the first number to add:");
        // int myNum1 = Convert.ToInt32(Console.ReadLine());

        // Console.WriteLine("Enter the second number to add:");
        // int myNum2 = Convert.ToInt32(Console.ReadLine());

        // CalcAdd myCalcAdd = new CalcAdd();
        // int sum = myCalcAdd.MyAdd(myNum1, myNum2);

        // Console.WriteLine($"The sum of {myNum1} and {myNum2} is {sum}");


        // 1) This method sends parameters to CalcMult,
        // 2) then CalcMult runs the operation and writes the result to the console.
        // Program does not receive a return value from CalcMult.
        // Console.WriteLine("Enter the first number to multiply:");
        // int myNum3 = Convert.ToInt32(Console.ReadLine());

        // Console.WriteLine("Enter the second number to multiply:");
        // int myNum4 = Convert.ToInt32(Console.ReadLine());

        // CalcMult myCalcMult = new CalcMult();
        // myCalcMult.MyMultiply(myNum3, myNum4);

        // }

        static void Main(string[] args)
        {
            bool continueProgram = true;
            bool firstActivity = true;

            while (continueProgram)
            {
                if (firstActivity) {
                    Console.WriteLine("Welcome to the Tshirt database! Would you like to proceed?");
                } else {
                    Console.WriteLine("Would you like to continue working with the Tshirt database?");
                }
                string userResponse = Console.ReadLine().ToLower();

                switch (userResponse)
                {
                    case "yes":
                    case "y":
                        TshirtHandler tshirtHandler = new TshirtHandler();
                        tshirtHandler.Handle();
                        break;

                    case "no":
                    case "n":
                        Console.WriteLine("You chose not to proceed. Goodbye!");
                        continueProgram = false;
                        break;

                    default:
                        Console.WriteLine("You did not enter a valid response.");
                        break;
                }

                firstActivity = false;
            }
        }
    }
}
