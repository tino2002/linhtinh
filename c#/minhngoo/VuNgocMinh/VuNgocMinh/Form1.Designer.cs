namespace VuNgocMinh
{
    partial class Form1
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
            this.loginlbl = new System.Windows.Forms.Label();
            this.usernamelbl = new System.Windows.Forms.Label();
            this.pswlbl = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.psw = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbbtn = new System.Windows.Forms.Button();
            this.nvbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginlbl
            // 
            this.loginlbl.AutoSize = true;
            this.loginlbl.Location = new System.Drawing.Point(329, 44);
            this.loginlbl.Name = "loginlbl";
            this.loginlbl.Size = new System.Drawing.Size(120, 25);
            this.loginlbl.TabIndex = 0;
            this.loginlbl.Text = "Dang Nhap";
            this.loginlbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // usernamelbl
            // 
            this.usernamelbl.AutoSize = true;
            this.usernamelbl.Location = new System.Drawing.Point(46, 131);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(107, 25);
            this.usernamelbl.TabIndex = 1;
            this.usernamelbl.Text = "Tai khoan";
            // 
            // pswlbl
            // 
            this.pswlbl.AutoSize = true;
            this.pswlbl.Location = new System.Drawing.Point(46, 215);
            this.pswlbl.Name = "pswlbl";
            this.pswlbl.Size = new System.Drawing.Size(104, 25);
            this.pswlbl.TabIndex = 2;
            this.pswlbl.Text = "Mat Khau";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(196, 131);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(441, 31);
            this.username.TabIndex = 3;
            // 
            // psw
            // 
            this.psw.Location = new System.Drawing.Point(196, 209);
            this.psw.Name = "psw";
            this.psw.Size = new System.Drawing.Size(441, 31);
            this.psw.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cbbtn
            // 
            this.cbbtn.Location = new System.Drawing.Point(103, 319);
            this.cbbtn.Name = "cbbtn";
            this.cbbtn.Size = new System.Drawing.Size(217, 42);
            this.cbbtn.TabIndex = 6;
            this.cbbtn.Text = "Can Bo";
            this.cbbtn.UseVisualStyleBackColor = true;
            this.cbbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // nvbtn
            // 
            this.nvbtn.Location = new System.Drawing.Point(422, 319);
            this.nvbtn.Name = "nvbtn";
            this.nvbtn.Size = new System.Drawing.Size(215, 42);
            this.nvbtn.TabIndex = 7;
            this.nvbtn.Text = "nhan vien";
            this.nvbtn.UseVisualStyleBackColor = true;
            this.nvbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nvbtn);
            this.Controls.Add(this.cbbtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.psw);
            this.Controls.Add(this.username);
            this.Controls.Add(this.pswlbl);
            this.Controls.Add(this.usernamelbl);
            this.Controls.Add(this.loginlbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginlbl;
        private System.Windows.Forms.Label usernamelbl;
        private System.Windows.Forms.Label pswlbl;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox psw;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cbbtn;
        private System.Windows.Forms.Button nvbtn;
    }
}

