using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class SavingsAccount : Account
    {
        private decimal _interestRate;


        public SavingsAccount(string firstname, string lastname, string bvn, decimal accountBalance, decimal interestRate) : base(firstname, lastname, bvn, accountBalance)
        {
            _interestRate = interestRate;
        }

        public decimal InterestRate
        {
            get { return _interestRate; }
            set
            {
                if (value > 0)
                    _interestRate = value;
                else
                    throw new Exception("Interest rate must be greater than zero");
            }
        }


        public decimal CalculateInterest()
        {
            return Balance * InterestRate;
        }
    }
}