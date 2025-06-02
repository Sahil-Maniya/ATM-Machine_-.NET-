namespace Account
{
    partial class Home
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
            this.btn_deposite = new System.Windows.Forms.Button();
            this.btn_withdraw = new System.Windows.Forms.Button();
            this.btn_changepin = new System.Windows.Forms.Button();
            this.btn_fastcash = new System.Windows.Forms.Button();
            this.btn_balance = new System.Windows.Forms.Button();
            this.btn_ministatement = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_accountnumber = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(731, 73);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(686, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(536, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Your Transation Please";
            // 
            // btn_deposite
            // 
            this.btn_deposite.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_deposite.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.btn_deposite.ForeColor = System.Drawing.Color.White;
            this.btn_deposite.Location = new System.Drawing.Point(88, 128);
            this.btn_deposite.Name = "btn_deposite";
            this.btn_deposite.Size = new System.Drawing.Size(250, 61);
            this.btn_deposite.TabIndex = 27;
            this.btn_deposite.Text = "Deposite";
            this.btn_deposite.UseVisualStyleBackColor = false;
            this.btn_deposite.Click += new System.EventHandler(this.btn_deposite_Click);
            // 
            // btn_withdraw
            // 
            this.btn_withdraw.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_withdraw.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.btn_withdraw.ForeColor = System.Drawing.Color.White;
            this.btn_withdraw.Location = new System.Drawing.Point(422, 128);
            this.btn_withdraw.Name = "btn_withdraw";
            this.btn_withdraw.Size = new System.Drawing.Size(250, 61);
            this.btn_withdraw.TabIndex = 28;
            this.btn_withdraw.Text = "Withdraw";
            this.btn_withdraw.UseVisualStyleBackColor = false;
            this.btn_withdraw.Click += new System.EventHandler(this.btn_withdraw_Click);
            // 
            // btn_changepin
            // 
            this.btn_changepin.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_changepin.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.btn_changepin.ForeColor = System.Drawing.Color.White;
            this.btn_changepin.Location = new System.Drawing.Point(88, 385);
            this.btn_changepin.Name = "btn_changepin";
            this.btn_changepin.Size = new System.Drawing.Size(250, 61);
            this.btn_changepin.TabIndex = 29;
            this.btn_changepin.Text = "Change Pin";
            this.btn_changepin.UseVisualStyleBackColor = false;
            this.btn_changepin.Click += new System.EventHandler(this.btn_changepin_Click);
            // 
            // btn_fastcash
            // 
            this.btn_fastcash.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_fastcash.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.btn_fastcash.ForeColor = System.Drawing.Color.White;
            this.btn_fastcash.Location = new System.Drawing.Point(88, 255);
            this.btn_fastcash.Name = "btn_fastcash";
            this.btn_fastcash.Size = new System.Drawing.Size(250, 61);
            this.btn_fastcash.TabIndex = 30;
            this.btn_fastcash.Text = "Fast Cash";
            this.btn_fastcash.UseVisualStyleBackColor = false;
            this.btn_fastcash.Click += new System.EventHandler(this.btn_fastcash_Click);
            // 
            // btn_balance
            // 
            this.btn_balance.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_balance.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.btn_balance.ForeColor = System.Drawing.Color.White;
            this.btn_balance.Location = new System.Drawing.Point(422, 385);
            this.btn_balance.Name = "btn_balance";
            this.btn_balance.Size = new System.Drawing.Size(250, 61);
            this.btn_balance.TabIndex = 31;
            this.btn_balance.Text = "Balance";
            this.btn_balance.UseVisualStyleBackColor = false;
            this.btn_balance.Click += new System.EventHandler(this.btn_balance_Click);
            // 
            // btn_ministatement
            // 
            this.btn_ministatement.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_ministatement.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.btn_ministatement.ForeColor = System.Drawing.Color.White;
            this.btn_ministatement.Location = new System.Drawing.Point(422, 255);
            this.btn_ministatement.Name = "btn_ministatement";
            this.btn_ministatement.Size = new System.Drawing.Size(250, 61);
            this.btn_ministatement.TabIndex = 32;
            this.btn_ministatement.Text = "Mini Statement";
            this.btn_ministatement.UseVisualStyleBackColor = false;
            this.btn_ministatement.Click += new System.EventHandler(this.btn_ministatement_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft JhengHei UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(287, 481);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(171, 50);
            this.btn_logout.TabIndex = 33;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 555);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(731, 16);
            this.panel2.TabIndex = 34;
            // 
            // lbl_accountnumber
            // 
            this.lbl_accountnumber.AutoSize = true;
            this.lbl_accountnumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_accountnumber.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_accountnumber.Location = new System.Drawing.Point(244, 76);
            this.lbl_accountnumber.Name = "lbl_accountnumber";
            this.lbl_accountnumber.Size = new System.Drawing.Size(256, 38);
            this.lbl_accountnumber.TabIndex = 2;
            this.lbl_accountnumber.Text = "Account Number";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 571);
            this.Controls.Add(this.lbl_accountnumber);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_ministatement);
            this.Controls.Add(this.btn_balance);
            this.Controls.Add(this.btn_fastcash);
            this.Controls.Add(this.btn_changepin);
            this.Controls.Add(this.btn_withdraw);
            this.Controls.Add(this.btn_deposite);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_deposite;
        private System.Windows.Forms.Button btn_withdraw;
        private System.Windows.Forms.Button btn_changepin;
        private System.Windows.Forms.Button btn_fastcash;
        private System.Windows.Forms.Button btn_balance;
        private System.Windows.Forms.Button btn_ministatement;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_accountnumber;
    }
}