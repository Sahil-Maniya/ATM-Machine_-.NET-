namespace Account
{
    partial class Account
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_accountnumber = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_faname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_pin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_occupation = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comb_education = new System.Windows.Forms.ComboBox();
            this.DOB_account = new System.Windows.Forms.DateTimePicker();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 61);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(945, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(246, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "ATM Management System";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(35, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Account Number ";
            // 
            // txt_accountnumber
            // 
            this.txt_accountnumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F);
            this.txt_accountnumber.Location = new System.Drawing.Point(30, 142);
            this.txt_accountnumber.Name = "txt_accountnumber";
            this.txt_accountnumber.Size = new System.Drawing.Size(373, 44);
            this.txt_accountnumber.TabIndex = 3;
            this.txt_accountnumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_accountnumber_KeyPress);
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F);
            this.txt_name.Location = new System.Drawing.Point(30, 250);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(373, 44);
            this.txt_name.TabIndex = 5;
            this.txt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(35, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 38);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name";
            // 
            // txt_faname
            // 
            this.txt_faname.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F);
            this.txt_faname.Location = new System.Drawing.Point(30, 355);
            this.txt_faname.Name = "txt_faname";
            this.txt_faname.Size = new System.Drawing.Size(373, 44);
            this.txt_faname.TabIndex = 7;
            this.txt_faname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(35, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 38);
            this.label5.TabIndex = 6;
            this.label5.Text = "Father Name";
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.Location = new System.Drawing.Point(30, 452);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(373, 145);
            this.txt_address.TabIndex = 9;
            this.txt_address.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(35, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 38);
            this.label6.TabIndex = 8;
            this.label6.Text = "Address";
            // 
            // txt_phone
            // 
            this.txt_phone.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F);
            this.txt_phone.Location = new System.Drawing.Point(547, 452);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(373, 44);
            this.txt_phone.TabIndex = 11;
            this.txt_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_phone_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(552, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 38);
            this.label7.TabIndex = 10;
            this.label7.Text = "Phone #";
            // 
            // txt_pin
            // 
            this.txt_pin.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F);
            this.txt_pin.Location = new System.Drawing.Point(547, 142);
            this.txt_pin.Name = "txt_pin";
            this.txt_pin.Size = new System.Drawing.Size(373, 44);
            this.txt_pin.TabIndex = 13;
            this.txt_pin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_accountnumber_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Location = new System.Drawing.Point(552, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 38);
            this.label8.TabIndex = 12;
            this.label8.Text = "PIN";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label10.Location = new System.Drawing.Point(552, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 38);
            this.label10.TabIndex = 16;
            this.label10.Text = "Education";
            // 
            // txt_occupation
            // 
            this.txt_occupation.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F);
            this.txt_occupation.Location = new System.Drawing.Point(547, 349);
            this.txt_occupation.Name = "txt_occupation";
            this.txt_occupation.Size = new System.Drawing.Size(373, 44);
            this.txt_occupation.TabIndex = 19;
            this.txt_occupation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label11.Location = new System.Drawing.Point(552, 308);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 38);
            this.label11.TabIndex = 18;
            this.label11.Text = "Occupation";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label12.Location = new System.Drawing.Point(563, 511);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 38);
            this.label12.TabIndex = 20;
            this.label12.Text = "DOB";
            // 
            // comb_education
            // 
            this.comb_education.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F);
            this.comb_education.FormattingEnabled = true;
            this.comb_education.Items.AddRange(new object[] {
            "Non Graduate ",
            "Under Graduate ",
            "Post Graduate"});
            this.comb_education.Location = new System.Drawing.Point(547, 250);
            this.comb_education.Name = "comb_education";
            this.comb_education.Size = new System.Drawing.Size(373, 46);
            this.comb_education.TabIndex = 22;
            // 
            // DOB_account
            // 
            this.DOB_account.CalendarFont = new System.Drawing.Font("Microsoft YaHei UI", 21.75F);
            this.DOB_account.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F);
            this.DOB_account.Location = new System.Drawing.Point(558, 553);
            this.DOB_account.Name = "DOB_account";
            this.DOB_account.Size = new System.Drawing.Size(373, 44);
            this.DOB_account.TabIndex = 23;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_login.Font = new System.Drawing.Font("Microsoft JhengHei UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(215, 620);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(171, 50);
            this.btn_login.TabIndex = 24;
            this.btn_login.Text = "Submit";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft JhengHei UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(570, 620);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(171, 50);
            this.btn_logout.TabIndex = 25;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 697);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(990, 23);
            this.panel2.TabIndex = 26;
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 720);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.DOB_account);
            this.Controls.Add(this.comb_education);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_occupation);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_pin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_faname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_accountnumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_accountnumber;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_faname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_pin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_occupation;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comb_education;
        private System.Windows.Forms.DateTimePicker DOB_account;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Panel panel2;
    }
}

