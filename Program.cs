using System;

namespace Lessthan100
{
    //Lab 4: Given two numbers, return True if the sum of both numbers is less than 100. Otherwise return False
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the first number : ");
            int firstNo = int.Parse(Console.ReadLine());
            Console.Write("Please enter the second number : ");
            int secondNo = int.Parse(Console.ReadLine());
            int sum = firstNo + secondNo;
            //conditional statement
            if (sum < 100)     {
             Console.WriteLine("TRUE");
             Console.WriteLine("The sum is " + sum+" and it's less than 100");
            }
            else if (sum >100)    {
             Console.WriteLine("FALSE");
             Console.WriteLine("The sum is " + sum+" and it's greater than 100");
            }
            else         {
              Console.WriteLine("The sum is equal to 100");
            }
        }
    }
}
