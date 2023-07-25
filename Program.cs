using System;

namespace Space
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of circle");

            float radius = Convert.ToInt32(Console.ReadLine());
            const float p = 3.14F;

            if (radius > 0)
            {
                Console.WriteLine("Calculating the surface of circle");
                Console.WriteLine($"Area of circle is {p * radius * radius}");
            }

            else if (radius == 0)
            {
                Console.WriteLine("Radius can't be null");
            }
            else
            {
                Console.WriteLine("Radius can't be lower than null");
            }

        }
    }
}