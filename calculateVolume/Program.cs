using System;

namespace calculateVolume
{
    class Program
    {
        static void Main(string[] args)
        {
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
            Console.WriteLine("1. Cylinder");
            Console.WriteLine("2. Cube");
            Console.WriteLine("3. Prism");
            Console.WriteLine("4. Pyramid");
            Console.WriteLine("5. Exit");
            string result = Console.ReadLine();

            if (result == "1")
            {
                calculateVolumeOfCylinder();
                return true;
            }
            else if (result == "2")
            {
                calculateVolumeOfCube();
                return true;
            }
            else if (result == "3")
            {
                calculateVolumeOfPrism();
                return true;
            }
            else if (result == "4")
            {
                calculateVolumeOfPyramid();
                return true;
            }
            else if (result == "5")
            {
                Console.Clear();
                return false;
            }
            else
            {
                Console.WriteLine("Please use a valid number");
                return false;
            }

        }

        public static void Prism()
        {
            Console.WriteLine("What kind of prism?");
            Console.WriteLine();
            Console.WriteLine("1. Rectangular Prism");
            Console.WriteLine("2. Cube");
            Console.WriteLine("3. Triangular Prism");
            Console.WriteLine("3. Cylinder");
             void RectangularPrism()
            {

            }
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
