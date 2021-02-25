using System;
using Autofac;

namespace DependecyInversionAutoFac
{
    
    public interface IMobileService
    {
        void Execute();
    }
    public class SMSService : IMobileService
    {
        public void Execute()
        {
            Console.WriteLine("SMS service executing.");
        }
    }

    public interface IMailService
    {
        void Execute();
    }

    public class EmailService : IMailService
    {
        public void Execute()
        {
            Console.WriteLine("Email service Executing.");
        }
    }

    public class NotificationSender
    {
        public IMobileService ObjMobileSerivce = null;
        public IMailService ObjMailService = null;

        //injection through constructor  
        public NotificationSender(IMobileService tmpService)
        {
            ObjMobileSerivce = tmpService;
        }
        //Injection through property  
        public IMailService SetMailService
        {
            set { ObjMailService = value; }
        }
        public void SendNotification()
        {
            ObjMobileSerivce.Execute();
            ObjMailService.Execute();
        }
    }

  
        class Program
        {
            static void Main(string[] args)
            {
                var builder = new ContainerBuilder();
                builder.RegisterType<SMSService>().As<IMobileService>();
                builder.RegisterType<EmailService>().As<IMailService>();
                var container = builder.Build();
               
                container.Resolve<IMobileService>().Execute();
                container.Resolve<IMailService>().Execute();
         
                Console.ReadLine();
            }
        }
    
   
}
