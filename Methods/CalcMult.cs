using System;

namespace CopilotTutorial
{
    public class CalcMult
    {
        public void MyMultiply(int numA, int numB)
        {
            Console.WriteLine($"CalcMult method is running {numA} * {numB}");
            int multProd = numA * numB;
            
            Console.WriteLine( $"The product of {numA} * {numB} is {multProd}");
        }
    }

}