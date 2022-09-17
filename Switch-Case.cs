using System;

namespace myFirstProject
{
    class Program
    {
        static void Main()
        {
            short user_input = Convert.ToInt16(Console.ReadLine());
            
            switch(user_input)
            {
                case 15:
                    Console.WriteLine("number is 15");
                    break;
                case 16:
                    Console.WriteLine("number is 16");
                    break;

                case 25:
                    Console.WriteLine("number is 25");
                    break;

                case 100:
                    Console.WriteLine("number is 100");
                    break;

                default: // "Иначе" если предыдущие значении не сработали..
                    Console.WriteLine("Not a Number!");
                    break;
            }
        }
    }
}
