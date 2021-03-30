using System;
using System.Net.NetworkInformation;

namespace console_bank_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DateTime Birthday = new DateTime(1987, 10, 17);
            Client Client1 = new Client(44, "Laila", Birthday);
            BankAccount Account1 = new BankAccount(Client1, "Private", 1000000);
            Console.WriteLine(Client1.Name);
            Console.WriteLine(Account1.Balance);
            Account1.Withdraw(500000);
            Console.WriteLine(Account1.Balance);
            Account1.Withdraw(10000000);
            Console.WriteLine(Account1.Balance);
            Account1.Deposit(10000000);
            Console.WriteLine(Account1.Balance);
            Account1.Balance = -13;
        }
    }

}
