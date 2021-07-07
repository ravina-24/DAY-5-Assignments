using System;

namespace Day_5_PrimeFactors
{
    class UC_5_PrimeFactors
    {
        static void Main(string[] args)
        {




            int Num = 1;
            int i = 1;

            Console.WriteLine("Enter the Number ");
            Num = int.Parse(Console.ReadLine());



            for (i = 1; i <= Num; i++)
            {

                if ( Num % i == 0)
                {
                    Console.WriteLine("Factors are = " + i);
                }
                
            }
            Console.ReadLine();
        }
    }
}
