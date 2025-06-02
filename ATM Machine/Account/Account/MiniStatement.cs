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
    public partial class MiniStatement : Form
    {
        public MiniStatement()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\DELL\\Desktop\\ATM Machine\\ATM_DataBase.mdf\";Integrated Security=True;Connect Timeout=30");
        String Acc = Login.accountNum;



        private void PopulateMethod()
        {
            conn.Open();
            String Qry = "Select * from TransationTbl Where Transation_AccNum = '" + Acc + "' ";
            SqlDataAdapter adpt = new SqlDataAdapter(Qry, conn);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            Data_Grid.DataSource = dt;
        }
        private void btn_logout_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MiniStatement_Load(object sender, EventArgs e)
        {
            PopulateMethod();
        }
    }
}
