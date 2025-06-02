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
    public partial class Deposite : Form
    {
        public Deposite()
        {
            InitializeComponent();
        }
   
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\DELL\\Desktop\\ATM Machine\\ATM_DataBase.mdf\";Integrated Security=True;Connect Timeout=30");
        int oldbalance, newBlannce;
        String Acc = Login.accountNum;
        public void GetbalanceMethod()
        {
            conn.Open();
            String Qry = "Select Account_Balance from AccountTbl Where Account_AccNum = '" +Acc + "'  ";
            SqlDataAdapter adpt = new SqlDataAdapter(Qry, conn);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            oldbalance = Convert.ToInt32(dt.Rows[0][0].ToString());

            conn.Close();
        }

        public void addtransationMethod()
        {
            String TransationType = "Deposit";
            try
            {
                conn.Open();
                String Qry = "Insert Into TransationTbl Values ('" + Acc + "','" + TransationType+ "','" + txt_amount.Text + "' , '" +DateTime.Today.ToString() + "' )";
                SqlCommand cmd = new SqlCommand(Qry, conn);
                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_deposite_Click(object sender, EventArgs e)
        {
            if (txt_amount.Text == "" || Convert.ToInt32(txt_amount.Text) <= 0)
            {
                MessageBox.Show("Enter the Amount for the deposite ");
            }
            else
            {

                newBlannce = oldbalance+Convert.ToInt32(txt_amount.Text);
                try
                {
                    conn.Open();
                    String Qry = "Update AccountTbl Set Account_Balance  = " + newBlannce + " Where Account_AccNum =  '" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(Qry, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Amount Added Successfully ");
                    conn.Close();

                    addtransationMethod();


                    Home home = new Home();
                    home.Show();
                    this.Hide();

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Deposite_Load(object sender, EventArgs e)
        {
            GetbalanceMethod();
        }

     
        private void txt_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
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
