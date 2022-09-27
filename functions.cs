using System;


namespace myFirstProject
{
    class Program
    {
        static void Main()
        {
            //functions;
            //Print("Hello");
            //Print("How are you?");
            //Print("Thank you");

            int res1 = Sum(5, 9);
            int a = 3, b = 9;
            int res2 = Sum(a, b);
            Print(res1.ToString());
            Print(res2.ToString());
        }
       public static void Print(string words)
        {
            Console.WriteLine(words);
        }

        public static int Sum(int x, int y)
        {
           return x + y;
        }
       
    }
 
}
