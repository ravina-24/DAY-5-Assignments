using System;

namespace UC_5_FindtheLargestAMongThree
{
    class UC_10_FindTheLargestAmongThree
    {
        static void Main(string[] args)
        {

            int Num1;
            int Num2;
            int Num3;

            Console.WriteLine("Enter the Number 1 ");
            Num1 = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter the Number 2 ");
            Num2 = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter the Number 3");
            Num3 = int.Parse(Console.ReadLine());

            if ( Num1 > Num2  && Num1 > Num3 )
            {
                Console.WriteLine("Entered Number 1  is greatest ="  +Num1);

            }
            else if ( Num2 > Num1 && Num2 > Num3)
            {
                Console.WriteLine("Entered Number 2  is greatest= " + Num2);

            }
            else if ( Num3 > Num1 && Num3 > Num2 )
            {
                Console.WriteLine("Entered Number 3  is greatest = " + Num3);
            }
            Console.ReadLine();
        }
    }
}

