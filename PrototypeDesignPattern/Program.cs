using System;

namespace PrototypeDesignPattern
{
    public interface IPrototype<T>               //Creating copy using Explicit Deep Copy Interface
    {
        T DeepCopy();
    }

    public class Person : IPrototype<Person>
    {
        public string[] Names;
        public Address Address;

        public Person(string[] names,Address address)
        {
            Names = names;
            Address = address;
        }

        public override string ToString()
        {
            return $"{nameof(Names)}:{string.Join(" ", Names)} , {nameof(Address)}:{Address}";
        }

        public Person DeepCopy()                                     //Clone Via Deep Copy Interface
        {
            return new Person(Names, Address.DeepCopy());
        }

        public Person(Person other)                                     //Clone Via Copy Constructor
        {
            Names = other.Names;
            Address = new Address(other.Address);
        }
    }

    public class Address : IPrototype<Address>
    {
        public int HouseNumber;
        public string Location;

        public Address(int houseNumber, string location)
        {
            HouseNumber = houseNumber;
            Location = location;
        }

        public override string ToString()
        {
            return $"{nameof(HouseNumber)}:{HouseNumber}, {nameof(Location)}:{Location}";
        }

        public Address DeepCopy()                                 //Clone Via Deep Copy Interface
        {
            return new Address(HouseNumber, Location);
        }

        public Address(Address other)                       //Clone Via Copy Constructor
        {
            HouseNumber = other.HouseNumber;
            Location = other.Location;
        }
    }

    

    class Program
    {
        static void Main(string[] args)
        {
            var atul = new Person(new [] { "raj", "akash" }, new Address(122, "Pune"));
            Console.WriteLine(atul);

            var raj = new Person(atul);                          // Copy "atul" object into "raj" Object (Using Copy Constructor)
            raj.Names[0] = "ajay";                               // Changes Names
            raj.Address.HouseNumber = 332;                       // Changes HouseNumber
            
            Console.WriteLine(raj);

            var vishal = raj.DeepCopy();                        //Copy object by using Explicit deep copy Interface
            Console.WriteLine(vishal);
        }
    }
}
