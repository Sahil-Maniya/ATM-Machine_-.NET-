using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Account
{
    public partial class Balance : Form
    {
        public Balance()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\DELL\\Desktop\\ATM Machine\\ATM_DataBase.mdf\";Integrated Security=True;Connect Timeout=30");
        public void GetbalanceMethod()
        {
            conn.Open();
            String Qry = "Select Account_Balance from AccountTbl Where Account_AccNum = '" + lbl_AccNum.Text + "'  ";
            SqlDataAdapter adpt = new SqlDataAdapter(Qry, conn);
            DataTable dt = new DataTable(); 
            adpt.Fill(dt);
            lbl_balance_Rs.Text = dt.Rows[0][0].ToString();

            conn.Close();
        }
        private void Balance_Load(object sender, EventArgs e)
        {
            lbl_AccNum.Text = Login.accountNum;
            GetbalanceMethod();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();    
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
