using System;

namespace Inheritance
{
    public class Text : Presentation
    { 
         public int Fontsize { get; set; }
        public int Fontname { get; set; }

        public void Hyperlink()
        {
            Console.WriteLine("Link is Added");
        }
    }
}
