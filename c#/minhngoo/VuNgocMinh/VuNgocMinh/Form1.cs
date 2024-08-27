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

namespace VuNgocMinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //dang nhap nhan vien
        private void loginbtn_Click(object sender, EventArgs e)
        {
            string strconnect = System.Configuration.ConfigurationSettings.AppSettings["MyConnectString"].ToString();
            try
            {
                string command = "select * from DANGNHAP where MADN = N'" + username.Text + "' and MATKHAU = N'" + psw.Text + "'" +
                    " and QUYEN = 'c'";
                SqlConnection connecttion = new SqlConnection(strconnect); ;
                connecttion.Open();
                SqlCommand lenh = new SqlCommand(command, connecttion);
                SqlDataReader reader = lenh.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Dang nhap thanh cong");
                    this.Hide();
                    Form2 main = new Form2();
                    main.ShowDialog();
                    this.psw.Text = "";
                    this.username.Text = "";
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Sai ten dang nhap hoac mat khau hoac ban khong co quyen truy cap");
                }
                connecttion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message.ToString());
            }
        }
        //dang nhap canbo
        private void button2_Click(object sender, EventArgs e)
        {
            string strconnect = System.Configuration.ConfigurationSettings.AppSettings["MyConnectString"].ToString();
            try
            {
                string command = "select * from DANGNHAP where MADN = N'" + username.Text + "' and MATKHAU = N'" + psw.Text + "'" +
                    " and QUYEN = 'a'";
                SqlConnection connecttion = new SqlConnection(strconnect); ;
                connecttion.Open();
                SqlCommand lenh = new SqlCommand(command, connecttion);
                SqlDataReader reader = lenh.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Dang nhap thanh cong");
                    this.Hide();
                    Form2 main = new Form2();
                    main.ShowDialog();
                    this.psw.Text = "";
                    this.username.Text = "";
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Sai ten dang nhap hoac mat khau hoac ban khong co quyen truy cap");
                }
                connecttion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message.ToString());
            }
        }
    }
}
