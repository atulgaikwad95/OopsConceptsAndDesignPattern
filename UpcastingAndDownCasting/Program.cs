using System;

namespace UpcastingAndDownCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            Shape shape = circle;

            circle.X = 100;
            shape.X = 200;
            Console.WriteLine(circle.X);
        }
    }
}
