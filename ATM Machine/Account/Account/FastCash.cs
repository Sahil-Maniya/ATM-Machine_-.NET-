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
    public partial class FastCash : Form
    {
        public FastCash()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\DELL\\Desktop\\ATM Machine\\ATM_DataBase.mdf\";Integrated Security=True;Connect Timeout=30");
        String Acc = Login.accountNum;
        int balance;
        int newBlannce;
        int amount =0 ;

        public void GetbalanceMethod()
        {
            conn.Open();
            String Qry = "Select Account_Balance from AccountTbl Where Account_AccNum = '" + Acc + "'  ";
            SqlDataAdapter adpt = new SqlDataAdapter(Qry, conn);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            lbl_availabelbal.Text = "Balance Rs:" + dt.Rows[0][0].ToString();
            balance = Convert.ToInt32(dt.Rows[0][0].ToString());
            conn.Close();
        }

        public void addtransationMethod()
        {
            String TransationType = "Withdraw";
            try
            {
                conn.Open();
                String Qry = "Insert Into TransationTbl Values ('" + Acc + "','" + TransationType + "','" + amount + "' , '" + DateTime.Today.ToString() + "' )";
                SqlCommand cmd = new SqlCommand(Qry, conn);
                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
     
        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FastCash_Load(object sender, EventArgs e)
        {
            GetbalanceMethod();            
        }

        private void btn_rs100_Click(object sender, EventArgs e)
        {
            if (balance < 100)
            {
                MessageBox.Show("Invalid Balance ");
            }

            else
            {

                amount = 100;
                newBlannce = balance - 100;
                try
                {
                    conn.Open();
                    String Qry = "Update AccountTbl Set Account_Balance  = " + newBlannce + " Where Account_AccNum =  '" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(Qry, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Amount Successfully Withdraw ");
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

        private void btn_rs500_Click(object sender, EventArgs e)
        {
            if (balance < 500)
            {
                MessageBox.Show("Invalid Balance ");
            }

            else
            {
                amount = 500;
                newBlannce = balance - 500;
                try
                {
                    conn.Open();
                    String Qry = "Update AccountTbl Set Account_Balance  = " + newBlannce + " Where Account_AccNum =  '" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(Qry, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Amount Successfully Withdraw ");
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

        private void btn_rs1000_Click(object sender, EventArgs e)
        {
            if (balance < 1000)
            {
                MessageBox.Show("Invalid Balance ");
            }

            else
            {
                amount = 1000;
                newBlannce = balance - 1000;
                try
                {
                    conn.Open();
                    String Qry = "Update AccountTbl Set Account_Balance  = " + newBlannce + " Where Account_AccNum =  '" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(Qry, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Amount Successfully Withdraw ");
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

        private void btn_rs2000_Click(object sender, EventArgs e)
        {
            if (balance < 2000)
            {

                MessageBox.Show("Invalid Balance ");
            }

            else
            {
                amount = 2000;
                newBlannce = balance - 2000;
                try
                {
                    conn.Open();
                    String Qry = "Update AccountTbl Set Account_Balance  = " + newBlannce + " Where Account_AccNum =  '" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(Qry, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Amount Successfully Withdraw ");
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

        private void btn_rs5000_Click(object sender, EventArgs e)
        {
            if (balance < 5000)
            {
                MessageBox.Show("Invalid Balance ");
            }

            else
            {
                amount = 5000;
                newBlannce = balance - 5000;
                try
                {
                    conn.Open();
                    String Qry = "Update AccountTbl Set Account_Balance  = " + newBlannce + " Where Account_AccNum =  '" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(Qry, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Amount Successfully Withdraw ");
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

        private void btn_rs10000_Click(object sender, EventArgs e)
        {
            if (balance < 10000)
            {
                MessageBox.Show("Invalid Balance ");
            }

            else
            {
                amount = 10000;
                newBlannce = balance - 10000;
                try
                {
                    conn.Open();
                    String Qry = "Update AccountTbl Set Account_Balance  = " + newBlannce + " Where Account_AccNum =  '" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(Qry, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Amount Successfully Withdraw ");
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

        private void btn_back_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
