using System.Collections.Generic;

namespace Customerdemo
{
    public class Customer
    {
        public int id;
        public string name;
      public readonly  List<Order> orders= new List<Order>();

        public Customer(int id)
        {
            this.id = id;
        }
        public Customer(int id,string name):this(id)
        {
            this.name = name;
        }
        
        public void promote()
        {
           // orders = new List<Order>();
        }

    }
}
