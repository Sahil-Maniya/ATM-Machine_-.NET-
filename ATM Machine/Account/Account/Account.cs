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
    public partial class Account : Form
    {

        public Account()
        {
            InitializeComponent();
        }
        int bal=0;
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\DELL\\Desktop\\ATM Machine\\ATM_DataBase.mdf\";Integrated Security=True;Connect Timeout=30");
        private void btn_login_Click(object sender, EventArgs e)
        {

    
            if (txt_accountnumber.Text == "" || txt_name.Text == "" || txt_faname.Text == "" || txt_address.Text == "" || txt_pin.Text == "" || comb_education.Text == "" || txt_occupation.Text == "" || DOB_account.Text == "" || txt_phone.Text == "")
            {
                MessageBox.Show("Missing Field");
            }
           else if (txt_phone.Text.Length != 10)
            {
                MessageBox.Show("Enter the 10 digit  ");
            }
            else
            {
                try
                {
                    conn.Open();
                    String Qry = "Insert Into AccountTbl(Account_AccNum,Account_Name,Account_FaName,Account_DOB,Account_Phone,Account_Address,Account_Occupation,Account_Education,Account_Pin,Account_Balance) Values ('" + txt_accountnumber.Text + "','" + txt_name.Text + "','" + txt_faname.Text + "' , '" + DOB_account.Text + "' , '" + txt_phone.Text + "' , '" + txt_occupation.Text + "' , '" + txt_address.Text + "' , '" + comb_education.SelectedItem.ToString() + "'," + txt_pin.Text + "," + bal + ")";
                    SqlCommand cmd = new SqlCommand(Qry, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created Successfully");

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_accountnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }    
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled= true;
            }
        }

        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if(txt_phone.Text.Length >=10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            
        }
    }
}
