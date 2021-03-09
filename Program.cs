using System;
using System.Globalization;

namespace Inheritance
{
    public class Program
    {
        static void Main(string[] args)

        {

            Account account = new Account("Joshua", "Adeyemi", "22654773", 7000M);
            Console.WriteLine("Welcome {0} {1} {2}  Your Balance is N{3}", account.FirstName, account.LastName, account.Bvn, account.Balance);
            Console.WriteLine();




            SavingsAccount sa = new SavingsAccount(account.FirstName, account.LastName, account.Bvn, account.Balance, 0.06M);
            decimal totalCredit = 2000.0M;

            Console.WriteLine("Beginning balance is N{0}", account.Balance);
            totalCredit = sa.CalculateInterest();
            Console.WriteLine("Total interest: N{0}", totalCredit);
            sa.Credit(totalCredit);
            Console.WriteLine("Ending balance is: N{0}", sa.Balance);
            Console.WriteLine();




            CheckingAccount ca = new CheckingAccount(7000.00M, 25.00M);
            Console.WriteLine("Beginning balance is N{0}", account.Balance);
            ca.Credit(2000.00M);
            ca.Debit(3000.00M);
            Console.WriteLine("Ending balance is N{0}", ca.Balance);

            Console.ReadLine();
        }
    }
}