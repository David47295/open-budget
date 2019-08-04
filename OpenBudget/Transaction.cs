using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenBudget
{
    class Transaction
    {
        private int Id;
        private float Amount;
        private String Description;

        public Transaction(int id, float amount, String description)
        {
            this.Id = id;
            this.Amount = amount;
            this.Description = description;
        }

        public override String ToString()
        {
            String res = "Transaction has ID = " + this.Id + " Amount = " + this.Amount + "\n";
            return res;
        }
    }
}
