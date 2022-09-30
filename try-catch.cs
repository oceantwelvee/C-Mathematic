using System;
using System.IO;

namespace myFirstProject
{
    class Program
    {
        static void Main()
        {
            //try/catch
 
           // try
           // {
               // int num = Convert.ToInt32(Console.ReadLine());
              //  Console.WriteLine(num);
          //  }catch(FormatException)
           // {
                //Console.WriteLine("Вы ввели не корректно!");
           // }
            try
            {
                int a, b, res;
                Console.Write("Введите первое число: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите второе число: ");
                b = Convert.ToInt32(Console.ReadLine());
                res = a / b;
                Console.WriteLine("Результат: " + res);
            }catch(DivideByZeroException)
            {
                Console.WriteLine("Деление на ноль!");
            }catch(FormatException)
            {
                Console.WriteLine("Вы ввели не корректно!");
            }finally
            {
                Console.WriteLine("Спасибо!");
            }
        }


    

    
    }
 
}
