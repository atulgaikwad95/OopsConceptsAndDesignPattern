using System;

namespace Inheritance
{

    class Program
    {
        static void Main(string[] args)
        {
            var txt = new Text();
            Console.WriteLine(txt.Height = 100);
            Console.WriteLine(txt.Width = 200);
            txt.copy();
        }
    }
}
