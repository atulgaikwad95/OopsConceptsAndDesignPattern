using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserDecision = "";
            do
            {
                Console.WriteLine("Enter The Target Number");
                int UserChoice = int.Parse(Console.ReadLine());

                int start = 0;
                while (start <= UserChoice)
                {
                    Console.WriteLine(start + " ");
                    start += 2;
                }


                do
                {
                    Console.WriteLine("Do you want to continue... Yes or No");
                    UserDecision = Console.ReadLine().ToUpper();

                    if (UserDecision != "YES" && UserDecision != "NO")
                    {
                        Console.WriteLine("You Have Enter Invalid Choice... Please say Yes or No");
                    }
                } while (UserDecision != "YES" && UserDecision != "NO");
            } while (UserDecision == "YES");
        }
    }
}
