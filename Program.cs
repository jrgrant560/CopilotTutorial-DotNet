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

            Console.WriteLine("Welcome to the Tshirt database! What action would you like to perform?");
            Console.WriteLine("1. Display");
            Console.WriteLine("2. Add");
            Console.WriteLine("3. Update");
            Console.WriteLine("4. Delete");
            string userResponse = Console.ReadLine().ToLower();

            TshirtService myTshirtService = new TshirtService();
            string dbSource = "dbTshirts.json";

            switch (userResponse)
            {
                case "display":
                case "1":
                    Console.WriteLine("You chose to display the database.");
                    myTshirtService.Display(dbSource);
                    break;

                case "add":
                case "2":
                    Console.WriteLine("You chose to add a tshirt to the database.");
                    TShirt myTshirt = new TShirt();
                    Console.WriteLine("Enter the new tshirt Name:");
                    myTshirt.TshirtName = Console.ReadLine();
                    Console.WriteLine("Enter the new tshirt Logo:");
                    myTshirt.Logo = Console.ReadLine();
                    Console.WriteLine("Enter the new tshirt Size:");
                    myTshirt.Size = Console.ReadLine();

                    myTshirtService.Add(dbSource, myTshirt);
                    break;

                case "update":
                case "3":
                    Console.WriteLine("You chose to update a tshirt in the database.");
                    TShirt updatedTShirt = new TShirt();
                    Console.WriteLine("Enter the ID of the tshirt you want to update:");
                    int tShirtIdToUpdate = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the new tshirt Name:");
                    updatedTShirt.TshirtName = Console.ReadLine();
                    Console.WriteLine("Enter the new tshirt Logo:");
                    updatedTShirt.Logo = Console.ReadLine();
                    Console.WriteLine("Enter the new tshirt Size:");
                    updatedTShirt.Size = Console.ReadLine();

                    myTshirtService.Update(dbSource, tShirtIdToUpdate, updatedTShirt);
                    break;

                case "remove":
                case "delete":
                case "4":
                    Console.WriteLine("You chose to remove a tshirt from the database.");
                    Console.WriteLine("Enter the ID of the tshirt you want to remove:");
                    int tShirtId = Convert.ToInt32(Console.ReadLine());

                    myTshirtService.Remove(dbSource, tShirtId);
                    break;

                default:
                    Console.WriteLine("You did not choose a valid option.");
                    break;
            }

        }
    }
}
