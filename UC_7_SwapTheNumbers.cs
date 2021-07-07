using System;

namespace Day_5_SwappingNumbers
{
    class SwapTheNumbers
    {
        static void Main(string[] args)
        {

            int Number1= 5;
            int Number2=10;
           
            Console.WriteLine("Welcome to Swapping Numbers Program");

            Number1 = Number1 * Number2;  // Number1 = 5*10 = 50  
            Number2 = Number1 / Number2;  // Number2= 50/10  =5  } // getting swap with each other 
            Number1 = Number1 / Number2;  // Number1 =50/5 = 10  }
            Console.WriteLine("Swap Number1 =" + Number1 + " :with Number2 =" + Number2);
            Console.ReadLine();


            


        }
    }
}
