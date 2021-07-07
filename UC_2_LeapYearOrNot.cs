using System;

namespace LeapYearOrNot
{
    class UC_2_LeapYearOrNot
    {
        static void Main(string[] args)
        {

            int year = 0;

            Console.WriteLine("..............CHECKING the LEAP YEAR OR NOT............... ");

            Console.WriteLine("Enter the year in four digit ");
            year = int.Parse(Console.ReadLine());

           if (( year % 100 == 0 ) && ( year % 400 == 0) && ( year % 4 == 0 ))
           {
                Console.WriteLine("Entered year is a LEAP YEAR");
           }
           else 
           {
                Console.WriteLine("Entered year is not a LEAP YEAR");
           }

            Console.ReadLine();
        }
    }
}
