namespace LooseCoupling_Dependency_Injection_
{
    public class Student : IService
    {
        public int Id { get; set; }

        public Student()
        {
          //  Id = studId;
        }

        public int result(int a, int b)
        {
            return a + b;
        }
    }
  
}
