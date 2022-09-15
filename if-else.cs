using System;

namespace myFirstProject
{
    class Program
    {
        static void Main()
        {
             //If else
            int a = 5;
            bool isHasCar = false;

            if (a > 7)
            
                Console.WriteLine("number > 7");
             else if(a < 5)
            
                Console.WriteLine("number is < 5");
            
              else if(a == 5)
            {
                Console.WriteLine("number is 5");
               // if(isHasCar)
                    if((a == 5 || isHasCar) && a > 2)
                    Console.WriteLine("User has a car!");
                
            }
                else
            {
                Console.WriteLine("number is not 5");
            };
      }
    }
}
