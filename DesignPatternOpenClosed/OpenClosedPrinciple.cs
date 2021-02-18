using System;

namespace DesignPatternOpenClosed
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text;
    using static DesignPatternOpenClosed.ProductFilter;

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

            public Product(string name, Color color, Size size)
            {
                Name = name;
                Color = color;
                Size = size;
            }
        }


        public class ProductFilter
        {
            public IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
            {
                foreach (var p in products)
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

             public IEnumerable<Product> FilterByColorAndSize(IEnumerable<Product> products,Color color,Size size)
             {
                foreach(var p in products)
             {
                if (p.Color == color && p.Size == size)
                   yield return p;

             }
             }

        //-----------------xxxxxxxx Now Same Implementation using Interface xxxxxxxxxx------------------ 

           
            public interface ISpectification<T>
            {
            bool IsSatisfied(T t);
            }
         
            public interface IFilter<T>
            {
            IEnumerable<T> Filter(IEnumerable<T> items, ISpectification<T> spec);
            }

        public class ColorSpecification : ISpectification<Product>
        {
            private Color color;
            public ColorSpecification(Color color)
            {
                this.color = color;
            }
            public bool IsSatisfied(Product t)
            {
               return t.Color == color;
            }
        }

        public class SizeSpecification : ISpectification<Product>
        {
            private Size size;
            public SizeSpecification(Size size)
            {
                this.size = size;
            }
            public bool IsSatisfied(Product t)
            {
                return t.Size == size;
            }
        }

        public class AndSpecification<T> : ISpectification<T>
        {
            private ISpectification<T> first, second;

            public AndSpecification(ISpectification<T> first, ISpectification<T> second)
            {
                this.first = first;
                this.second = second;
            }
            public bool IsSatisfied(T t)
            {
                return first.IsSatisfied(t) && second.IsSatisfied(t);
            }
        }

        public class BetterFilter : IFilter<Product>
        {
            public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpectification<Product> spec)
            {
                foreach(var i in items)
                {
                    if (spec.IsSatisfied(i))
                        yield return i;
                }
            }
        }

    }

        class OpenClosedPrinciple
        {
            private static void Main(string[] args)
            {
                var apple = new Product("apple", Color.Green, Size.Small);
                var Tree = new Product("tree", Color.Green, Size.Large);
                var Mango = new Product("Mango", Color.Red, Size.Huge);
                var house = new Product("house", Color.Blue, Size.Huge);

                var pf = new ProductFilter();
                Product[] products = { apple, Tree, Mango, house };
                Console.WriteLine("The Green Products Are :");
                foreach (var p in pf.FilterByColor(products, Color.Green))
                {
                    Console.WriteLine($" - {p.Name} is green");
                }

               Console.WriteLine("The Large Products Are :");
               foreach (var pro in pf.FilterBySize(products,Size.Large))
               {
                Console.WriteLine("--"+ pro.Name+ " is Large");
               }

               Console.WriteLine("The Large and Red Products Are :");
               foreach (var pro in pf.FilterByColorAndSize(products, Color.Red, Size.Huge))
               {
                Console.WriteLine("--" + pro.Name + " is Huge and Red");
               }

            //------------Same implementation Using InterFace-----------

               var bf = new BetterFilter();
            Console.WriteLine("The Green Products Are (New) :");
               foreach(var p in bf.Filter(products,new ColorSpecification(Color.Green)))
            {
                Console.WriteLine($" - {p.Name} is green");
            }
            
            Console.WriteLine("The Large Products Are (New) :");
            foreach (var p in bf.Filter(products, new SizeSpecification(Size.Large)))
            {
                Console.WriteLine($" - {p.Name} is Large");
            }

            Console.WriteLine("The Large and Red Products Are (New) :");
            foreach(var p in bf.Filter(products,new AndSpecification<Product>(new ColorSpecification(Color.Red),new SizeSpecification(Size.Huge))))
            {
                Console.WriteLine("--" + p.Name + " is Huge and Red");
            }
        }
        }
    }
