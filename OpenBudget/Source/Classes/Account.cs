using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace OpenBudget
{
    class Account
    {
        private ArrayList Transactions;

        public Account()
        {
            this.Transactions = new ArrayList();
        }

        public void AddTransaction(Transaction transaction)
        {
            this.Transactions.Add(transaction);
        }

        public override string ToString()
        {
            String res = "";
            for (int i = 0; i < this.Transactions.Count; i++)
            {
                res += this.Transactions[i].ToString();
            }
            return res;
        }
    }
}
