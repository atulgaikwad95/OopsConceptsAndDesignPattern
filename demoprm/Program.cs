﻿/*using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("Hello World! Atul Gaikwad");
        Console.WriteLine("Enter the course");
        string cName = Console.ReadLine();
        // Console.WriteLine("Hello Atul In " + cName);
        Console.WriteLine("Hello {0}", cName);
    }
}

*/

using System;
namespace demoprm
{
    public class Info
    {
        public string course;

        public void Information(string name)
        {
            Console.WriteLine("I am {0}, and course is {1}", name, course);
        }

        public static Info getInfo(string nm)
        {
            Console.WriteLine("String is {0}", nm);
            return new Info();
        }

    }


    public class Program
    {
        public static void Main(String[] args)
        {
            var info = new Info();
            info.course = "C#";
            info.Information("Atul");

            var cl = new demo();
            cl.number = 100;
            cl.getNum(111);

            Info.getInfo("om");
            var cust = new Customer(11,"raj");
            Console.WriteLine(cust.id);
            Console.WriteLine(cust.name);



        }
    }
}