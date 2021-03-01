using AutoMapper;
using System;

namespace AutoMapperDemo
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

     class Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }

        public override string ToString()
        {
            return $"{nameof(FirstName)}:{FirstName} , {nameof(LastName)}:{LastName}, {nameof(Salary)}:{Salary}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            student.FirstName = "Atul";
            student.LastName = "Gaikwad";
            
            var mapperConfiguration = new MapperConfiguration(cfg => cfg.CreateMap<Student, Teacher>());
            var mapper = mapperConfiguration.CreateMapper();
            var teacher = mapper.Map<Student, Teacher>(student);                  
            Console.WriteLine(teacher);
            
        }
    }
}
