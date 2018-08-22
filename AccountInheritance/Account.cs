using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountInheritance
{
    class Account
    {
        private decimal balance;

        public Account(decimal balance)
        {
            Balance = balance;
        }

        public decimal Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if (value < 0.0m)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(Balance)} cant be a negative number");
                }
                balance = value;
            }
        }

        public virtual void Credit(decimal deposit)
        {
            Balance += deposit;
        }

        public virtual bool Debit(decimal withdraw)
        {
            bool success;

            if(Balance > withdraw)
            {
                Balance -= withdraw;
                success = true;
            }
            else
            {
                Console.WriteLine("Debit amount exceeded account balance");
                success = false;
            }

            return success;
        }
    }
}
