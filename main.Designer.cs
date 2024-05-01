namespace UI
{
    partial class main
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
            this.cardnumberlbl = new System.Windows.Forms.Label();
            this.usernamelbl = new System.Windows.Forms.Label();
            this.fnamelbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.homebtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.pointsbtn = new System.Windows.Forms.Button();
            this.smoneybtn = new System.Windows.Forms.Button();
            this.depositbtn = new System.Windows.Forms.Button();
            this.withdrawbtn = new System.Windows.Forms.Button();
            this.fastcashbtn = new System.Windows.Forms.Button();
            this.balancelbl = new System.Windows.Forms.Label();
            this.pointslbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.panel1.Controls.Add(this.cardnumberlbl);
            this.panel1.Controls.Add(this.usernamelbl);
            this.panel1.Controls.Add(this.fnamelbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 73);
            this.panel1.TabIndex = 2;
            // 
            // cardnumberlbl
            // 
            this.cardnumberlbl.AutoSize = true;
            this.cardnumberlbl.Font = new System.Drawing.Font("Franklin Gothic Demi", 10.2F);
            this.cardnumberlbl.Location = new System.Drawing.Point(656, 9);
            this.cardnumberlbl.Name = "cardnumberlbl";
            this.cardnumberlbl.Size = new System.Drawing.Size(202, 21);
            this.cardnumberlbl.TabIndex = 6;
            this.cardnumberlbl.Text = "Cardnumber : cardnumber";
            this.cardnumberlbl.Click += new System.EventHandler(this.cardnumberlbl_Click);
            // 
            // usernamelbl
            // 
            this.usernamelbl.AutoSize = true;
            this.usernamelbl.Font = new System.Drawing.Font("Franklin Gothic Demi", 10.2F);
            this.usernamelbl.Location = new System.Drawing.Point(656, 30);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(170, 21);
            this.usernamelbl.TabIndex = 5;
            this.usernamelbl.Text = "Username : username";
            // 
            // fnamelbl
            // 
            this.fnamelbl.AutoSize = true;
            this.fnamelbl.Font = new System.Drawing.Font("Georgia", 22.2F);
            this.fnamelbl.Location = new System.Drawing.Point(12, 9);
            this.fnamelbl.Name = "fnamelbl";
            this.fnamelbl.Size = new System.Drawing.Size(381, 43);
            this.fnamelbl.TabIndex = 4;
            this.fnamelbl.Text = "Welcome back fname.";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.homebtn);
            this.panel2.Controls.Add(this.exitbtn);
            this.panel2.Controls.Add(this.pointsbtn);
            this.panel2.Controls.Add(this.smoneybtn);
            this.panel2.Controls.Add(this.depositbtn);
            this.panel2.Controls.Add(this.withdrawbtn);
            this.panel2.Controls.Add(this.fastcashbtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(136, 420);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Demi", 15.2F);
            this.button1.Location = new System.Drawing.Point(0, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 47);
            this.button1.TabIndex = 8;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // homebtn
            // 
            this.homebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.homebtn.FlatAppearance.BorderSize = 0;
            this.homebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homebtn.Font = new System.Drawing.Font("Franklin Gothic Demi", 10.2F);
            this.homebtn.Location = new System.Drawing.Point(3, 0);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(130, 47);
            this.homebtn.TabIndex = 7;
            this.homebtn.Text = "Home";
            this.homebtn.UseVisualStyleBackColor = true;
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.Transparent;
            this.exitbtn.Font = new System.Drawing.Font("Franklin Gothic Demi", 15.2F);
            this.exitbtn.Location = new System.Drawing.Point(0, 373);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(136, 47);
            this.exitbtn.TabIndex = 6;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // pointsbtn
            // 
            this.pointsbtn.FlatAppearance.BorderSize = 0;
            this.pointsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pointsbtn.Font = new System.Drawing.Font("Franklin Gothic Demi", 10.2F);
            this.pointsbtn.Location = new System.Drawing.Point(3, 268);
            this.pointsbtn.Name = "pointsbtn";
            this.pointsbtn.Size = new System.Drawing.Size(130, 47);
            this.pointsbtn.TabIndex = 4;
            this.pointsbtn.Text = "Points";
            this.pointsbtn.UseVisualStyleBackColor = true;
            this.pointsbtn.Click += new System.EventHandler(this.pointsbtn_Click);
            // 
            // smoneybtn
            // 
            this.smoneybtn.FlatAppearance.BorderSize = 0;
            this.smoneybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smoneybtn.Font = new System.Drawing.Font("Franklin Gothic Demi", 10.2F);
            this.smoneybtn.Location = new System.Drawing.Point(3, 212);
            this.smoneybtn.Name = "smoneybtn";
            this.smoneybtn.Size = new System.Drawing.Size(130, 47);
            this.smoneybtn.TabIndex = 3;
            this.smoneybtn.Text = "Send Money";
            this.smoneybtn.UseVisualStyleBackColor = true;
            this.smoneybtn.Click += new System.EventHandler(this.smoneybtn_Click);
            // 
            // depositbtn
            // 
            this.depositbtn.FlatAppearance.BorderSize = 0;
            this.depositbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.depositbtn.Font = new System.Drawing.Font("Franklin Gothic Demi", 10.2F);
            this.depositbtn.Location = new System.Drawing.Point(3, 159);
            this.depositbtn.Name = "depositbtn";
            this.depositbtn.Size = new System.Drawing.Size(130, 47);
            this.depositbtn.TabIndex = 2;
            this.depositbtn.Text = "Deposit";
            this.depositbtn.UseVisualStyleBackColor = true;
            this.depositbtn.Click += new System.EventHandler(this.depositbtn_Click);
            // 
            // withdrawbtn
            // 
            this.withdrawbtn.FlatAppearance.BorderSize = 0;
            this.withdrawbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.withdrawbtn.Font = new System.Drawing.Font("Franklin Gothic Demi", 10.2F);
            this.withdrawbtn.Location = new System.Drawing.Point(3, 106);
            this.withdrawbtn.Name = "withdrawbtn";
            this.withdrawbtn.Size = new System.Drawing.Size(130, 47);
            this.withdrawbtn.TabIndex = 1;
            this.withdrawbtn.Text = "Withdraw";
            this.withdrawbtn.UseVisualStyleBackColor = true;
            this.withdrawbtn.Click += new System.EventHandler(this.withdrawbtn_Click);
            // 
            // fastcashbtn
            // 
            this.fastcashbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fastcashbtn.FlatAppearance.BorderSize = 0;
            this.fastcashbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fastcashbtn.Font = new System.Drawing.Font("Franklin Gothic Demi", 10.2F);
            this.fastcashbtn.Location = new System.Drawing.Point(3, 53);
            this.fastcashbtn.Name = "fastcashbtn";
            this.fastcashbtn.Size = new System.Drawing.Size(130, 47);
            this.fastcashbtn.TabIndex = 0;
            this.fastcashbtn.Text = "FastCash";
            this.fastcashbtn.UseVisualStyleBackColor = true;
            this.fastcashbtn.Click += new System.EventHandler(this.fastcashbtn_Click);
            // 
            // balancelbl
            // 
            this.balancelbl.AutoSize = true;
            this.balancelbl.Font = new System.Drawing.Font("Franklin Gothic Demi", 45F);
            this.balancelbl.Location = new System.Drawing.Point(156, 137);
            this.balancelbl.Name = "balancelbl";
            this.balancelbl.Size = new System.Drawing.Size(692, 94);
            this.balancelbl.TabIndex = 4;
            this.balancelbl.Text = " Balance : balance$";
            this.balancelbl.Click += new System.EventHandler(this.balancelbl_Click);
            // 
            // pointslbl
            // 
            this.pointslbl.AutoSize = true;
            this.pointslbl.Font = new System.Drawing.Font("Franklin Gothic Demi", 45F);
            this.pointslbl.Location = new System.Drawing.Point(186, 246);
            this.pointslbl.Name = "pointslbl";
            this.pointslbl.Size = new System.Drawing.Size(471, 94);
            this.pointslbl.TabIndex = 5;
            this.pointslbl.Text = "Points : point";
            this.pointslbl.Click += new System.EventHandler(this.pointslbl_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(942, 493);
            this.Controls.Add(this.pointslbl);
            this.Controls.Add(this.balancelbl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "main";
            this.Load += new System.EventHandler(this.main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button fastcashbtn;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Button pointsbtn;
        private System.Windows.Forms.Button smoneybtn;
        private System.Windows.Forms.Button depositbtn;
        private System.Windows.Forms.Button withdrawbtn;
        private System.Windows.Forms.Label fnamelbl;
        private System.Windows.Forms.Label cardnumberlbl;
        private System.Windows.Forms.Label usernamelbl;
        private System.Windows.Forms.Label balancelbl;
        private System.Windows.Forms.Label pointslbl;
        private System.Windows.Forms.Button homebtn;
        private System.Windows.Forms.Button button1;
    }
}