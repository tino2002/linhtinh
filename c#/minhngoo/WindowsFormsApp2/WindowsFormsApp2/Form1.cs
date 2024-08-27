using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonTinhLaiSuat_Click(object sender, EventArgs e)
        {

            //MessageBox.Show("Tính lãi suất","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            DialogResult dr = MessageBox.Show("Bạn có muốn tiếp tục không", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                MessageBox.Show("Bạn vừa bấm Yes!");
                int sonam = int.Parse(this.txtSoNam.Text);
                int sotien = int.Parse(this.txtSoTien.Text);
                float muclaisuat = 0.0f;
                
                muclaisuat = TinhLaiSuat1(sotien, sonam);
                this.lblMucLaiSuat.Text = muclaisuat.ToString();
            }
            else
            {
                MessageBox.Show("Bạn vừa bấm No!");
            }
        }
        private static float TinhMucLaiSuat(int SoTienVay)
        {
            float MucLaiSuat = 0;
            if (SoTienVay < 5000)
            {
                MucLaiSuat = 0;
            }
            else if (SoTienVay < 100000)
            {
                MucLaiSuat = 10.5f;
            }
            else if (SoTienVay < 250000)
            {
                MucLaiSuat = 10;
            }
            else if (SoTienVay < 500000)
            {
                MucLaiSuat = 9.5f;
            }
            else
            {
                MucLaiSuat = 9;
            }
            return MucLaiSuat;
        }
        private float TinhLaiSuat1(int sotien,int sonam)
        {
            float muclaisuat = TinhMucLaiSuat(sotien);
            return muclaisuat * sonam * sotien / 100;
        }
    }
}
