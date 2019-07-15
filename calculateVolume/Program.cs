using System;

namespace calculateVolume
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the radius");
            int radius = Convert.ToInt32(Console.ReadLine());
            int radiusSquared = radius * radius;

            Console.WriteLine("What is the height");
            int height = Convert.ToInt32(Console.ReadLine());

            double pi = 3.14;

            double totalVolume = height * radiusSquared * pi;

            Console.WriteLine("The volume is {0}", totalVolume);
        }
    }
}
