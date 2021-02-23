using System;

namespace SwitchStatementPrm
{
    class Program
    {
        static void Main(string[] args)
        {
           int TotalCoffeeCost = 0;
            Start:                             // Labels
            Console.WriteLine("Please Enter Size Of Coffee ... 1- Small , 2- Medium , 3- Large");
            int UserChoice = int.Parse(Console.ReadLine());

            switch (UserChoice)
            {
                case 1:
                    TotalCoffeeCost += 1;
                    break;

                case 2:
                    TotalCoffeeCost += 2;
                    break;

                case 3:
                    TotalCoffeeCost += 3;
                    break;

                default:
                    Console.WriteLine("You Choice {0} is invalid please try again..", UserChoice);
                    goto Start;

            }

              Decide:                                  // Labels
            Console.WriteLine("Do you Want to buy another Coffee... Yes or No");
            string UserDecision = Console.ReadLine();

            switch (UserDecision.ToUpper())
            {
                case "YES":
                    goto Start;                         // Jump To the Start Label 
                case "NO":
                        break;
                default:
                    Console.WriteLine("Your Choice {0} is Invalid... Please try again", UserDecision);
                    goto Decide;                        // Jump To the Decide Label 

            }
            Console.WriteLine("Thanks For shopping");
            Console.WriteLine("Your Bill amount is {0}",TotalCoffeeCost);

        }
    }
}
