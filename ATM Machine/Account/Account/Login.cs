using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Account
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\DELL\\Desktop\\ATM Machine\\ATM_DataBase.mdf\";Integrated Security=True;Connect Timeout=30");
        public static string accountNum;

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn_Signup_Click(object sender, EventArgs e)
        {
            Account Acc = new Account();
            Acc.Show();
            this.Hide();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {


            if (txt_accountnumber.Text == "" || txt_pin.Text == "")
            {
                MessageBox.Show("Missing Field");
            }
            else
            {

                conn.Open();
                String Qry = "Select count(*) from AccountTbl Where Account_AccNum = '" + txt_accountnumber.Text + "' and Account_Pin = " + txt_pin.Text;
                SqlDataAdapter adpt = new SqlDataAdapter(Qry, conn);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    accountNum = txt_accountnumber.Text;
                    Home home = new Home();
                    home.Show();
                    this.Hide();

                    conn.Close();

                }

                else
                {

                    MessageBox.Show("Wrong Your Account Number or Pin Code ", "information");
                }
                conn.Close();
            }
        }

        private void txt_accountnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
