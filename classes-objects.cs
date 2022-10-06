using System;

namespace myFirstProject
{
    class Program
    {
        static void Main()
        {
          // Создание классов и объектов
               Robot bot = new Robot();
            bot.setValues("bob", 800, new byte[] {0,0,0});
            bot.printValues();

            //bot.name = "Bob";
            //bot.weight = 800;
            //bot.coordinates = new byte[] { 0, 0, 0 };

            //Console.WriteLine(bot.name + " weight: " + bot.weight);

            Robot killer = new Robot();
            killer.setValues("Terminator", 1000, new byte[] { 0, 0, 10 });
            killer.printValues();



           // killer.name = "Terminator";
           // killer.weight = 1000;
           // killer.coordinates = new byte[] { 0, 0, 10 };

           // Console.WriteLine(killer.name + " weight: " + killer.weight);
        }
        
    } 
}

// Аксессоры get / set

using project;
using System;

namespace myFirstProject
{
    class Program
    {
        static void Main()
        {
            // Создание классов и объектов
            Robot bot = new Robot("bob", 800, new byte[] {0,0,0,});
            bot.printValues();

            Robot killer = new Robot();
            killer.setValues("Terminator", 1000, new byte[] { 0, 0, 10 });
            killer.printValues();

            Robot.Print();

            Robot bot1 = new Robot();
            bot1.Weight = -100;
            Console.WriteLine(bot1.Weight);

        }

    }
}
