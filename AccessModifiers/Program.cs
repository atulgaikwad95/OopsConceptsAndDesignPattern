using System;

namespace AccessModifiers
{
   public class Program
    {
       public static void Main(string[] args)
        {
            var person = new Person(new DateTime(1995, 03, 28));
            /*person.setBirthDate(new DateTime(1995, 03, 28));

            Console.WriteLine(person.getBirthDate());*/
           // person.Birthdate = new DateTime(1995, 03, 28);
            Console.WriteLine(person.Age);
    
        }
    }
}
