using System;
using System.Net.Mail;

namespace CreationalDesignPatterns
{
    public enum Area
    {
        Rectangle,
        Square
    }
  
     public class Point
    {
        private int x;
        private int y;

        
        public static Point AreaRectangle(int x,int y)     //Factory Method
        {
            return new Point(x , y);
        }

        public static Point AreaSquare(int PI, int r)     //Factory Method
        {
            return new Point(PI ,(r*r));
        }
        private Point(int x,int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"{nameof(x)}:{x} , {nameof(y)}: {y}";
        }

    }
    class Program
    {
      static async System.Threading.Tasks.Task Main(string[] args)
        {
            //Factory Method
            /*         Console.WriteLine("Factory Method Design Pattern");
                     var point = Point.AreaSquare(3, 5);
                     Console.WriteLine(point);*/

            //Asynchronous Factory Method
            /*   AsyncMethod x = await AsyncMethod.CreateAsync();*/

            //Make Factory Methods in Different Class i.e AreaFactory 
            /*  var factoryDemo = AreaFactory.AreaSquare(2, 4);
              Console.WriteLine(factoryDemo);*/


            //Inner Factory (Changes made in FactoryDemo class)
            /*   var innerFactory = FactoryDemo.AreaFactory.AreaSquare(3, 5);
               Console.WriteLine(innerFactory);*/

            SmtpClient client = new SmtpClient("hello.com");
            client.Send(new MailMessage());

        }
    }
}
