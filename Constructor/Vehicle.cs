using System;

namespace Constructor
{
    public class Vehicle
    {
        public readonly string rNum;
      /*  public Vehicle()
        {
            Console.WriteLine("Vehicle is initialized");
        }*/
        public Vehicle( string rNum)
        {
           this.rNum = rNum;
            Console.WriteLine("Vehicle is Initialized {0}", rNum);
        }
    }
}
