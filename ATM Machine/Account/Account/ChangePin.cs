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
    public partial class ChangePin : Form
    {
        public ChangePin()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\DELL\\Desktop\\ATM Machine\\ATM_DataBase.mdf\";Integrated Security=True;Connect Timeout=30");
        string Acc = Login.accountNum;
        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            if (txt_newpin.Text == "" || txt_confirmpin.Text == "")
            {
                MessageBox.Show("Enter the New and Confirm Pin Number ");
            }

            else if (txt_confirmpin.Text !=  txt_newpin.Text)
            {
                MessageBox.Show("New Pin And Confirm Pin Are differternt ");
            }
            else
            {
                try
                {
                    conn.Open();
                    String Qry = "Update AccountTbl Set Account_Pin  = " + txt_newpin.Text + " Where Account_AccNum =  '" + Acc + "' ";
                    SqlCommand cmd = new SqlCommand(Qry, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pin Change Successfully ");
                    conn.Close();

                    Login login = new Login();  
                    login.Show();
                    this.Hide();
                }

                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();    
            this.Hide();    
        }

        private void txt_newpin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
