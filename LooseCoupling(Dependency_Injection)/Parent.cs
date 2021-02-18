using System;

namespace LooseCoupling_Dependency_Injection_
{
    public class Parent
    {
        private IService _iservice;

        public Parent(IService _iservice)
        {
            this._iservice = _iservice;
        }

        public void PrintResult(int a,int b)
        {
            var ans=_iservice.result(a, 4);
            Console.WriteLine("The Result is {0} ", ans);
        }
    }
  
}
