using System;
using System.Windows.Forms;
using OpenBudget.Source.Forms;

namespace OpenBudget
{
    public partial class Form1 : Form
    {
        private Account currentAccount;
        private int count;
        public Form1()
        {
            InitializeComponent();
            this.currentAccount = new Account();
            this.count = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction(this.count, 6.90f, "Test Shit");
            this.currentAccount.AddTransaction(transaction);
            this.count++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.currentAccount.ToString());
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AddAccountBtn_Click(object sender, EventArgs e)
        {
            AddAccountForm form = new AddAccountForm();
            form.Show();
        }
    }
}
