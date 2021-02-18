using System;

namespace Inheritance
{
    public class Presentation
    {
        public int Width { get; set; }
        public int Height { get;set; }

        public void copy()
        {
            Console.WriteLine("Text Copy to clipboard ");
        }

        public void duplicate()
        {
            Console.WriteLine("Duplicate Copy Found");
        }
    }
}
