using System;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new Httpcookie();
            cookie["name"] = "Atul";
            Console.WriteLine(cookie["name"]);
        }
    }
}
