using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Newtonsoft.Json;

namespace OpenBudget
{
    class Account
    {
        private ArrayList Transactions;
        private string AccountName;
        private float AccountBalance;
        [JsonProperty]
        private string Currency;

        public string GetCurrency()
        {
            return Currency;
        }

        public void SetCurrency(string value)
        {
            Currency = value;
        }

        public Account()
        {
            this.Transactions = new ArrayList();
        }

        public void AddTransaction(Transaction transaction)
        {
            this.Transactions.Add(transaction);
        }

        public void SetAccountName(string name)
        {
            this.AccountName = name;
        }

        public void SetAccountBalance(float balance)
        {
            this.AccountBalance = balance;
        }
        

        public override string ToString()
        {
            string json = JsonConvert.SerializeObject(this);
            return json;
            //String res = "";
            //for (int i = 0; i < this.Transactions.Count; i++)
            //{
            //    res += this.Transactions[i].ToString();
            //}
            //return res;
        }
    }
}
