using System;

namespace InterfaceSegregation
{
    public interface IPrinter
    {
        void Print();
        void Fax();
        void Scan();
    }

    public class MultiFunctionPrinter : IPrinter
    {
        public void Fax()
        {
            Console.WriteLine("Fax is created");
        }

        public void Print()
        {
            Console.WriteLine("Print is Created");
        }

        public void Scan()
        {
            Console.WriteLine("Scan is done");
        }
    }

    public interface IFax
    {
        void Fax();
    }
    public interface IOldPrinter
    {
        void Print();
    }
    public class OldPrinter : IOldPrinter
    {
        public void Print()
        {
            Console.WriteLine("Print is Created");
        }
    }

    public class FaxMachine : IFax
    {
        public void Fax()
        {
            Console.WriteLine("Fax is done");
        }
    }

    public class SemiMachine : IOldPrinter, IFax
    {
        public void Fax()
        {
            Console.WriteLine("Fax is done");
        }

        public void Print()
        {
            Console.WriteLine("Print is done");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IOldPrinter o = new OldPrinter();
            o.Print();
        }
    }
}
