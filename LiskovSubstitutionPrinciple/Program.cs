using System;

namespace LiskovSubstitutionPrinciple
{
    public class Rectangle
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }
        public Rectangle()
        {  }

        public Rectangle(int width,int height)
        {
            Width = width;
            Height = height;
        }


        public override string ToString()
        {
            return "Width= " + Width + "and" + "Height =" + Height;
        }
    }

    public class Square : Rectangle
    {

        public override int Width
        {
            set { base.Width = base.Height = value; }
        }
        public override int Height
        {
            set { base.Width = base.Height = value; }
        }
    }
    class Program
    {
        public static int Area(Rectangle r) => r.Width * r.Height;
        static void Main(string[] args)
        {
            Rectangle rc = new Rectangle(3, 4);
           Console.WriteLine("Area of Rechangle is = " + Area(rc));
          Console.WriteLine(rc);

            Rectangle sr = new Square();
            sr.Width = 5;
            Console.WriteLine("Area of Square = " + Area(sr));
        }
    }
}
