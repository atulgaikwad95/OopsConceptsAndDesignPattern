using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public sealed class Singleton                                    // Sealed is used to avoid inheritance from other class 
    {
       private static int counter = 0;
        //  private static Singleton instance = null;               // For Lazy Initialization of Object.

        private static readonly Lazy<Singleton> instance = new Lazy<Singleton>(()=>new Singleton());     // For Lazy Initialization using Lazy Keyword (comes after .Net version- 4.0)
     //   private static readonly object obj = new object();
        public static Singleton GetInstance
        {
            get
            {
                /*                if (instance == null)
                                {
                                    lock (obj)
                                    {
                                        if (instance == null)
                                            instance = new Singleton();
                                    }
                                }
                               return instance;*/

                return instance.Value;                               // For Lazy Initialization (Need to return value of Instance)
            }
        }
        private Singleton()                                              // private constructor avoid creating object from outsider class.
        {
            counter++;
            Console.WriteLine("The value is " + counter.ToString());
        }
      public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }

    class Program
    {
        private static void PrintStudentDetails()
        {
            var s1 = Singleton.GetInstance;
            s1.PrintDetails("Hello s1");
        }

        private static void PrintEmployeeDetails()
        {
            var s2 = Singleton.GetInstance;
            s2.PrintDetails("Hello s2");
        }
        static void Main(string[] args)
        {
            Parallel.Invoke(                               // Thread Safety Singleton (When multiple thread tried to invoke GetInstance Property.
                () => PrintStudentDetails(),
                () => PrintEmployeeDetails()
                          );



            /*var s1 = Singleton.GetInstance;                            //For Simple Singleton 
            s1.PrintDetails("Hello s1");
            var s2 = Singleton.GetInstance;
            s2.PrintDetails("hello s2");*/

        }



    }
}
