using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountInheritance
{
    class CheckingAccount : Account
    {
        private decimal transactionFee;

        public CheckingAccount(decimal balance, decimal transactioFee) : base(balance)
        {
            TransactionFee = transactionFee;
        }
        public decimal TransactionFee
        {
            get
            {
                return transactionFee;
            }
            set
            {
                transactionFee = value;
            }
        }

        public override void Credit(decimal deposit)
        {
            base.Credit(deposit);
            Balance -= TransactionFee;
        }
        public override bool Debit(decimal withdraw)
        {
            bool success = base.Debit(withdraw);
            if(success)
            {
                Balance -= TransactionFee;
            }
            return success;
        }
    }
}
