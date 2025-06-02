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
    public partial class Loading_Page : Form
    {
        public Loading_Page()
        {
            InitializeComponent();
            panel_Myprogress.Width = 0;
            panel_Myprogress.BackColor = Color.Green;
        }

        int Starting = 0;
        int maxWidth;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Starting += 1;            
            maxWidth = this.Width;
            panel_Myprogress.Width = (maxWidth * Starting) / 100;
            lbl_percentage.Text = Starting + "%";
            if(Starting >=100)
            {
                panel_Myprogress.Width = 0;
                timer1.Stop();
                Login login = new Login();
                login.Show();
                this.Hide();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void panel_Myprogress_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
