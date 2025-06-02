using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void btn_balance_Click(object sender, EventArgs e)
        {
            Balance bal = new Balance();
            bal.Show();
            this.Hide();
        }

        private void btn_ministatement_Click(object sender, EventArgs e)
        {
            MiniStatement min_statement = new MiniStatement();
            min_statement.Show();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            lbl_accountnumber.Text = "Account Number : " + Login.accountNum;
        }

        private void btn_deposite_Click(object sender, EventArgs e)
        {
            Deposite deposite = new Deposite();
            deposite.Show();
            this.Hide();
        }

        private void btn_changepin_Click(object sender, EventArgs e)
        {
            ChangePin changepin = new ChangePin();
            changepin.Show();
            this.Hide();
        }

        private void btn_withdraw_Click(object sender, EventArgs e)
        {
            Withdraw withdraw = new Withdraw();
            withdraw.Show();    
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_fastcash_Click(object sender, EventArgs e)
        {
            FastCash fastcash = new FastCash();
            fastcash.Show();
            this.Hide();
        }
    }
}
