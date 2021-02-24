using System;
using System.Collections.Generic;
using static CommandDesignPattern.BankAccount;

namespace CommandDesignPattern
{

    public class BankAccount
    {
        private int balance;
        private int limit = 100;

        public void Deposit(int amount)
        {
            balance += amount;
            Console.WriteLine($"Amount Deposited {amount} and Balance is now {balance}");
        }

        public void Withdraw(int amount)
        {
            if (balance> limit)
            {
                balance -= amount;
                Console.WriteLine($"Amount Withdrew {amount} and Balance is now {balance}");
            }
        }

        public interface ICommand
        {
            void call();
        }

        public override string ToString()
        {
            return $"Balabace Amount is {balance}";
        }

        public class BankAccountCommand : ICommand
        {
            private BankAccount account;
            private Action action;
            private int amount;

            public BankAccountCommand(BankAccount account, Action action, int amount)
            {
                this.account = account;
                this.action = action;
                this.amount = amount;
            }

            public enum Action
            {
                Withdraw,Deposit
            }
            public void call()
            {
                switch (action)
                {
                    case Action.Deposit:
                        account.Deposit(amount);
                        break;
                    case Action.Withdraw:
                        account.Withdraw(amount);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        throw new InvalidOperationException();
                        
                }
            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount();
            var commands = new List<BankAccountCommand>
            {
                new BankAccountCommand(ba,BankAccountCommand.Action.Deposit,500),
                new BankAccountCommand(ba, BankAccountCommand.Action.Withdraw, 100)
            };

            foreach (var c in commands)
                c.call();
            Console.WriteLine(ba);
            
        }
    }
}
