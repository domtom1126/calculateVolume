using System;

namespace calculateVolume
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            bool displayMenu = true;
            while (displayMenu == true)
            {
                displayMenu = DisplayMenu();
            }
            
        }

        static public bool DisplayMenu()
        {
            Console.WriteLine("What shape do you want the volume for?");
            Console.WriteLine();
            Console.WriteLine("1. Prism");
            Console.WriteLine("2. Pyramid");
            Console.WriteLine("3. Exit");
            string result = Console.ReadLine();

            if (result == "1")
            {
                Prism();
                return true;
            }
            else if (result == "2")
            {
                Pyramid();
                return true;
            }
            else if (result == "3")
            {
                Console.Clear();
                return true;
            }
            else
            {
                Console.WriteLine("Enter a proper value");
                return false;
            }
        }

        public static void Prism()
        {
            Console.Clear();
            Console.WriteLine("What kind of prism?");
            Console.WriteLine();
            Console.WriteLine("1. Rectangular Prism");
            Console.WriteLine("2. Cube");
            Console.WriteLine("3. Triangular Prism");
            Console.WriteLine("4. Cylinder");

            string PrismResult = Console.ReadLine();

            if (PrismResult == "1")
            {
                Console.WriteLine("What is the height");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the width");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the length");
                int length = Convert.ToInt32(Console.ReadLine());

                int rectangularPrismVolume = height * length * width;

                Console.WriteLine("The total volume of the retangular prism is {0}", rectangularPrismVolume);
            }
        }

        public static void Pyramid()
        {
            Console.Clear();
            Console.WriteLine("What kind of pyramid?");
            Console.WriteLine();
            Console.WriteLine("1. Square or Rectangular Pyramid");
            Console.WriteLine("2. Triangular Pyramid");
            Console.WriteLine("3. Cone");
        }

        public static void calculateVolumeOfCylinder()
        {
            Console.WriteLine("What is the radius");
            int radius = Convert.ToInt32(Console.ReadLine());
            int radiusSquared = radius * radius;

            Console.WriteLine("What is the height");
            int height = Convert.ToInt32(Console.ReadLine());

            double pi = 3.14;

            double totalVolume = height * radiusSquared * pi;

            Console.WriteLine("The total volume is {0}", totalVolume);

        }

        public static void calculateVolumeOfCube()
        {
            
        }

        public static void calculateVolumeOfPrism()
        {
            Console.WriteLine("volume of a prism");
        }

        public static void calculateVolumeOfPyramid()
        {
            Console.WriteLine("volume of a pyramid");
        }
    }
}
