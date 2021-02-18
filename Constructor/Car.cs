using System;

namespace Constructor
{
    public class Car : Vehicle
    {
      /*  public Car()
        {
            Console.WriteLine("car is Initialized");
        }*/

        public Car(string rNum) : base(rNum)
        {
            Console.WriteLine("Car is Initialized {0}" ,rNum);
        }
    }
}
