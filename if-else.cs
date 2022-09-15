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
            
            // Пример
            
            Console.Write("Enter name: ");
            string role = Console.ReadLine();

            if(role == "Admin")
            {
                Console.Write("Enter user name: ");
                string user_name = Console.ReadLine();
                Console.Write("Enter {0} age :", user_name);
                short age = Convert.ToInt16(Console.ReadLine());

                if (age <= 0 || age > 99)
                {
                    Console.Write("Enter {0} age :", user_name);
                    age = Convert.ToInt16(Console.ReadLine());
                }

                if (age <= 0 || age > 99)
                    Console.WriteLine("Error");
                else
                    Console.WriteLine("User's age is " + age);

            } else
            {
                Console.WriteLine("You are not admin!");
            }

      }
    }
}
