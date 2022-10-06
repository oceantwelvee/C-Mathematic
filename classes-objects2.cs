using System;


namespace project
{
     class Robot
    {
        private string name;

        private int weight;

        private byte[] coordinates;

        public void setValues(string _name, int _weight, byte[] _coordinates)
        {
            name = _name;
            weight = _weight;
            coordinates = _coordinates;
        }

        public void printValues()
        {
            Console.WriteLine(name + " weight: " + weight + ". Coordinates: ");
            foreach (byte el in coordinates)
                Console.WriteLine(el);
        }
    }
}

// Аксессоры get set

using System;


namespace project
{
    class Robot
    {
        private static int count;

        private string name;
        private int weight;
        private byte[] coordinates;

        public int Weight
        {
            get
            {
                Console.Write("Результат: ");
                return this.weight;
            }
            set
            {
                if (value < 1)
                    this.weight = 1;
                else if (value > 5000)
                    this.weight = 5000;
                else
                    this.weight = value;
            }
        }

        public Robot(string name, int weight, byte[] coordinates)
        {
            Console.WriteLine("Object has been created");
            this.setValues(name, weight, coordinates);
            count++;
        }

        public Robot() { 
            count++;

        }
        public void setValues(string name, int weight, byte[] coordinates)
        {
            this.name = name;
            this.weight = weight;
            this.coordinates = coordinates;
        }

        public void printValues()
        {
            Console.WriteLine(this.name + " weight: " + this.weight + " .Coordinates");
            foreach(byte el in this.coordinates)
            {
                Console.WriteLine(el);
            }
        }

        public static void Print()
        {
            Console.WriteLine("count is: " + count);
        }
    }
}
