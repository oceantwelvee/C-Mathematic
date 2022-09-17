using System;

namespace myFirstProject
{
    class Program
    {
        static void Main()
        {
           //for while do while;
            
            for(byte i = 0; i <= 10; i++) {
                Console.WriteLine("Element {0}" , i};
                 // 0,1 ,2 ,3, 4, 5, 6,7,8,9,10
            }
                                  
              for(byte i = 200; i > 10; i /=2) // Для деления /=2
            {
                Console.WriteLine("Element {0} ", i);
                // 200, 100, 50, 25, 12
            }
                                  
            for(byte i = 5; i <= 100; i *=2) // Для умножения *=2
            {
                Console.WriteLine("El {0}", i);
                //10, 20 , 40 , 80 
            }
                                  
              //While() внутри круглых скобок указываем условие
                                  
            byte i = 10;

            while(i >= 1)
            {
                Console.WriteLine("Element {0}", i);
                i--;
                // 10,9,8,7,6,5,3,2,1
            }
                                   
            bool isHasCar = true;

            while(isHasCar)
            {
                string end = Console.ReadLine();
                if(end == "end")
                    isHasCar = false;
            }   
                                  
               byte i = 100;
            do
            {
                Console.WriteLine("El {0}" + i);
            } while (i < 10);

                                  
              // break Для остановки цикла
               for(short i = 0; i < 10; i++) {
                   // Хочу чтобы цикл остановился когда дойдет до 5;
                   if(i > 5) break;
                   Console.WriteLine("El:" + i);
               }
             
              // Continue
                if (i % 2 == 0) continue;
        }
    }
}
