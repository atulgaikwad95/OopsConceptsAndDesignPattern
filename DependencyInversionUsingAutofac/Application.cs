using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionUsingAutofac
{
    class Application
    {
        IBusinessLogic _businessLogic;

        public Application(IBusinessLogic businessLogic)
        {
            _businessLogic = businessLogic;
        }

        public void Run()
        {
            _businessLogic.ProcessData();
        }
    }
}
