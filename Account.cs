using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Account
    {
        private string _firstName;
        private string _lastName;
        private string _bvn;
        private decimal _accountBalance;



        //constructor that receives the instance variables with a public property
        public Account(string firstName, string lastName, string bvn, decimal accountBalance)
        {
            _firstName = firstName;
            _lastName = lastName;
            _bvn = bvn;
            _accountBalance = accountBalance;
        }





        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }


        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string Bvn
        {
            get { return _bvn; }
            set { _bvn = value; }
        }


        public Account(decimal balance)
        {

        }
        public decimal Balance
        {
            get { return _accountBalance; }
            set
            {
                if (value >= 0)
                    _accountBalance = value;
                else
                    throw new Exception("Balance cannot be negative");
            }
        }
        public virtual void Credit(decimal amount)
        {
            if (amount > 0)
                Balance += amount;
            else
                throw new Exception("Credited amount must be greater than zero");
        }

        public virtual bool Debit(decimal amount)
        {
            bool OK;
            if (Balance >= amount)
            {
                Balance -= amount;
                OK = true;

            }
            else
            {
                Console.Write("Debit amount exceeded account balance.");
                OK = false;
            }
            return OK;
        }

    }
}
