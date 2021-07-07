using System;

namespace Day_5_PowerofTwo
{
    class UC_3_PowerOfTwo
    {
        static void Main(string[] args)
        {

            int Num = 0;
            int i = 1;
            Console.WriteLine("Enter the Number ");
            Num = int.Parse(Console.ReadLine());
            for (i = 1; i <= Num; i++)
            {


                double power =Math.Pow(2,i);
                Console.WriteLine("Power of Two = " + power);
                
            }
            Console.ReadLine();
        }
    }
}
