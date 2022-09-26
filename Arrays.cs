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
            
//             Многомерные массивы
            
              int[,] nums =
            {
                {4,6,7 },
                {5,7,8 },
                {9, 14, 32 }
            };
            nums[1, 1] = 50;
            
           // foreach метод
                byte[] numbers = new byte[5];
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;
            numbers[4] = 50;

            string[] users = new string[5];
            users[0] = "Tamerlan";
            users[1] = "Kamran";
            users[2] = "Almaz";
            users[3] = "Intigam";
            users[4] = "Credo Bank";

            for(int i = 0; i < users.Length; i++)
            {
                //Console.WriteLine("users : "+ users[i]);
            }

            foreach(string i in users)
            {
                //Console.WriteLine("users: " + i);
            }

            string[] ourCompanie = new string[10];
            ourCompanie[0] = "Apple";
            ourCompanie[1] = "Meta";
            ourCompanie[2] = "Google";
            ourCompanie[3] = "Amazon";
            ourCompanie[4] = "Microsoft";
            ourCompanie[5] = "HP";
            ourCompanie[6] = "Dell";
            ourCompanie[7] = "Asus";
            ourCompanie[8] = "Samsung";
            ourCompanie[9] = "Toshiba";

            foreach (string com in ourCompanie)
                Console.WriteLine("Our Companies: " + com);
        }
            }
            
        }
    }
}
