using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountInheritance
{
    class SavingsAccount : Account
    {
        private decimal interestRate;

        public SavingsAccount(decimal balance, decimal interestRate) : base(balance)
        {
            InterestRate = interestRate;
        }
        public decimal InterestRate
        {
            get
            {
                return interestRate;
            }
            set
            {
                interestRate = value;
            }
        }
        public decimal CalculateInterest()
        {
            return Balance / 100 * InterestRate;
        }
    }
}
