using Autofac;
using System;
using System.Collections.Generic;
using System.Text;


namespace DependencyInversionUsingAutofac
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<BusinessLogic>().As<IBusinessLogic>();
            builder.RegisterType<Logger>().As<ILogger>();
            builder.RegisterType<DataAccess>().As<IDataAccess>();
            
            return builder.Build();
        }
    }
}
