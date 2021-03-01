using System;
using Autofac;
using AutoMapper;

namespace AutoFacAndAutoMapperDemo
{
   public class Student : IStudent
    {
        public int ID { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
       
        public void UserName(string name)
        {
            Console.WriteLine($"Student UserName is {name}");
        }
        public void AnnualMarks(string userName, int marks)
        {
          Console.WriteLine($"Annual Marks = {nameof(userName)} : {userName} , {nameof(marks)}: {marks}");
        }
    }

    class College : ICollege
    {
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public void CollegeName(string name)
        {
            Console.WriteLine($"{nameof(College)} : {name}");
        }
    }


    class University : IUniversity
    {
        IStudent _student;
        ICollege _college;

        public University(IStudent student, ICollege college)
        {
            _student = student;
            _college = college;
        }
        public void GetInformation()
        {
            _student.UserName("Atul");
            _student.AnnualMarks("Atul", 70);
            _college.CollegeName("DonBosco");
        }
    }


    class CollegeApplication : ICollegeApplication
    {
        IUniversity _university;

        public CollegeApplication(IUniversity university)
        {
            _university = university;
        }

        public void DisplayInformation()
        {
            _university.GetInformation();
        }
    }


       public static class ContainerConfig
         {
            public static IContainer GetConfigure()
          {

            var builder = new ContainerBuilder();

            builder.RegisterType<Student>().As<IStudent>();
            builder.RegisterType<College>().As<ICollege>();
            builder.RegisterType<University>().As<IUniversity>();
            builder.RegisterType<CollegeApplication>().As<ICollegeApplication>();

            return builder.Build();
          
        }
    }  


    class Program
    {
        static void Main(String[] args)
        {
            var container = ContainerConfig.GetConfigure(); 

            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<ICollegeApplication>();
                app.DisplayInformation();
            }

            Console.WriteLine("------------------------------------------------------------------------------------------------");

            var student = new Student
            {
                ID = 100,
                City = "Pune",
                State = "Maharashtra",
                Country = "India"
            };

            var mapperConfiguration = new MapperConfiguration(cfg => cfg.CreateMap<Student, College>());
            var mapper = mapperConfiguration.CreateMapper();
            var teacher = mapper.Map<Student, College>(student);

            Console.WriteLine(teacher.City);
            Console.WriteLine(teacher.State);
            Console.WriteLine(teacher.Country);

        }
    }
}
