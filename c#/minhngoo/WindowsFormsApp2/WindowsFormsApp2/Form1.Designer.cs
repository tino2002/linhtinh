namespace WindowsFormsApp2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.txtSoNam = new System.Windows.Forms.TextBox();
            this.TinhLaiSuat = new System.Windows.Forms.Button();
            this.lblMucLaiSuat = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số tiền :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số năm :";
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(172, 82);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(410, 31);
            this.txtSoTien.TabIndex = 2;
            // 
            // txtSoNam
            // 
            this.txtSoNam.Location = new System.Drawing.Point(172, 140);
            this.txtSoNam.Name = "txtSoNam";
            this.txtSoNam.Size = new System.Drawing.Size(410, 31);
            this.txtSoNam.TabIndex = 3;
            // 
            // TinhLaiSuat
            // 
            this.TinhLaiSuat.Location = new System.Drawing.Point(172, 249);
            this.TinhLaiSuat.Name = "TinhLaiSuat";
            this.TinhLaiSuat.Size = new System.Drawing.Size(153, 47);
            this.TinhLaiSuat.TabIndex = 4;
            this.TinhLaiSuat.Text = "Tính lãi suất";
            this.TinhLaiSuat.UseVisualStyleBackColor = true;
            this.TinhLaiSuat.Click += new System.EventHandler(this.buttonTinhLaiSuat_Click);
            // 
            // lblMucLaiSuat
            // 
            this.lblMucLaiSuat.AutoSize = true;
            this.lblMucLaiSuat.Location = new System.Drawing.Point(172, 197);
            this.lblMucLaiSuat.Name = "lblMucLaiSuat";
            this.lblMucLaiSuat.Size = new System.Drawing.Size(128, 25);
            this.lblMucLaiSuat.TabIndex = 5;
            this.lblMucLaiSuat.Text = "Mức lãi suất";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(432, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 56);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 602);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMucLaiSuat);
            this.Controls.Add(this.TinhLaiSuat);
            this.Controls.Add(this.txtSoNam);
            this.Controls.Add(this.txtSoTien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Demo control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.TextBox txtSoNam;
        private System.Windows.Forms.Button TinhLaiSuat;
        private System.Windows.Forms.Label lblMucLaiSuat;
        private System.Windows.Forms.Button button1;
    }
}

