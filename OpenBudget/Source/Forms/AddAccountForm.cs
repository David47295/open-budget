using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using OpenBudget.Source.Classes;

namespace OpenBudget.Source.Forms
{
    public partial class AddAccountForm : Form
    {
        public AddAccountForm()
        {
            InitializeComponent();
            CurrencyComboBox.DataSource = Constants.CURRENCIES;
            BankComboBox.DataSource = Constants.BANKS;
            AccountTypeComboBox.DataSource = Constants.ACCOUNT_TYPES;
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            if (AccountName.Text == "" ||
                OpeningBalance.Text == "" ||)
            {
                return;
            }

            Account account = new Account();
            account.SetAccountName(AccountName.Text);
            account.SetCurrency(CurrencyComboBox.SelectedItem.ToString());
            account.SetAccountBalance(float.Parse(OpeningBalance.Text));
            string json = JsonConvert.SerializeObject(account);
            MessageBox.Show(json);
        }
    }
}
