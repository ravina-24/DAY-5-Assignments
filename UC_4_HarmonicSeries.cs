using System;

namespace Day_5_HarmonicNumberSeries
{
    class UC_4_HarmonicSeries
    {
        static void Main(string[] args)
        {


            
            int Num=0 ;
            int i = 1;
            double sumofHarmonicSeries = 0.0;
            Console.WriteLine("Enter the number");
            Num = int.Parse(Console.ReadLine());
          
            for ( i=1; i<=Num; i++)
            {

                Console.Write("1/{0} +" , i );
                sumofHarmonicSeries= 1 / (float)i;



                  
            }
            Console.WriteLine("\nSum of series upto {0} terms : {1}\n", +Num, +sumofHarmonicSeries);
            Console.ReadLine();
        }
    }
}
