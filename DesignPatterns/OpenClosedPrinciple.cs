/*using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;


namespace DesignPatterns
{
    public enum Color
    {
        Red, Green, Blue
    }
    public enum Size
    {
        Small, Large, Huge
    }

    public class Product
    {
        public string Name;
        public Color Color;
        public Size Size;

        public Product(string name, Color color,Size size)
        {
            Name = name;
            Color = color;
            Size = size;
        }
    }


    public class ProductFilter
    {
        public IEnumerable<Product> FilterBySize(IEnumerable<Product> products,Size size)
        {
            foreach(var p in products)
            {
                if (p.Size == size)
                    yield return p;
            }
        }

        public IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
        {
            foreach (var p in products)
            {
                if (p.Color == color)
                    yield return p;
            }
        }
    }

    class OpenClosedPrinciple
    {
        static void Main(string[] args)
        {
            var apple = new Product("apple", Color.Green, Size.Small);
            var Tree = new Product("tree", Color.Green, Size.Small);
            var Mango = new Product("Mango", Color.Red, Size.Small);
            var house = new Product("house", Color.Blue, Size.Small);

            var pf = new ProductFilter();
            Product[] products = { apple,Tree,Mango,house};
            Console.WriteLine("The Products Are :");
            foreach(var p in pf.FilterByColor(products, Color.Green))
            {
                Console.WriteLine($" - {p.Name} is green");
            }

        }
    }
}*/