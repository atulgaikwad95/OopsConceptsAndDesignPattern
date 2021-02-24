using System;

namespace ProxyDesignPattern
{
    public interface IService
    {
        void Login(int age);
    }

    class ConcreteService : IService
    {
        public void Login(int age)
        {
            Console.WriteLine($"Login Successfull, Your Age is {age}");
        }
    }

    class Proxy : IService
    {
        private IService _service;
        public Proxy(IService service)
        {
            _service = service;
        }
        public void Login(int age)
        {
            if (age < 18)
            {
                Console.WriteLine("You are not eligible for Login");
            }
            else
            {
                _service.Login(age);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IService concreteService = new ConcreteService();
            IService proxy = new Proxy(concreteService);

            concreteService.Login(15);
            proxy.Login(15);

            concreteService.Login(19);
            proxy.Login(19);

            Console.ReadLine();
        }
    }
}
