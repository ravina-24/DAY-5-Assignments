using System;

namespace Day_5_NumberOddOREven
{
    class UC_8_CheckTheOddOrEvenNumber
    {
        static void Main(string[] args)
        {
            int Number = 1;


            Console.WriteLine("Checking Whether the Number is odd or even ");

            Console.WriteLine("Enter the Number");

            Number = int.Parse(Console.ReadLine());

            if ( Number%2 == 0)
            {
                Console.WriteLine("It is an even Number");
            }
            else
            {
                Console.WriteLine("It is an odd Number");
            }
            Console.ReadLine();
        }
    }
}
