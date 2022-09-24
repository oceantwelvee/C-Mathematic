using System;

namespace myFirstProject
{
    class Program
    {
        static void Main()
        {
         // Массивы
            byte[] nums = new byte[5];
            nums[0] = 250;
            nums[1] = 200;
            nums[2] = 150;
            nums[3] = 100;
            nums[4] = 50;

            //Console.WriteLine("El: " + nums[2]);

            //string arrays;

            string[] words = new string[] { "Alex", "Bob", "Mike" };
            words[1] = "Tommy";

            // Cicles
            for (byte i = 0; i < nums.Length; i++)
                Console.WriteLine("El: " + nums[i]);

            for (byte i = 0; i < words.Length; i++)
            {
                Console.WriteLine("El: " + words[i]);
            }
            
            // Практическое приминение
            
             short[] numbers = new short[10];

            Random random = new Random();
            for(byte i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt16(random.Next(-15, 15));
                Console.WriteLine("El: " + numbers[i]);
            }
            
        }
    }
}
