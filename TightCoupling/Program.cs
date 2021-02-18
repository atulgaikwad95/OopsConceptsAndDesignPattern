using System;

namespace TightCoupling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Client
    {
        Service service = new Service();
        public void getData()
        {
            service.getService();
        }
    }
    public class Service
    {
        public void getService()
        {
            Console.WriteLine("Getiing the Service");
        }
    }


}
