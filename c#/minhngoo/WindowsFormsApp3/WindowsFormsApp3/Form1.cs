using Demo_Search_Customer;
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

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public ClsCustomer currentCustomer;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string strconnectstring = System.Configuration.ConfigurationSettings.AppSettings["Myconnectstring"].ToString();
                string strSearch = this.txtSearch.Text;
                string strCommand = "Select * from Customers";
                SqlConnection myConnection = new SqlConnection(strconnectstring);
                myConnection.Open();
                MessageBox.Show("ket noi thanh cong");
                SqlCommand myCommand = new SqlCommand(strCommand,myConnection);
                SqlDataAdapter da = new SqlDataAdapter(myCommand);
                DataSet ds = new DataSet();
                da.Fill(ds,"myCustomer");
                this.dgvCustomers.DataSource = ds;
                this.dgvCustomers.DataMember = "MyCustomer";
                myConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Co loi" + ex.Message.ToString() ,"co loi");
            }


            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                // Row, column toaj dodoj click
                DataGridViewRow dr = dgvCustomers.Rows[e.RowIndex];  //(lấy ra hàng hiện tại)
                if (dr != null)
                {
                    currentCustomer = new ClsCustomer();
                    currentCustomer.CustomerID = int.Parse(dr.Cells["CustomerID"].Value.ToString());
                    currentCustomer.FullName = dr.Cells["FullName"].Value.ToString();
                    currentCustomer.EmailAddress = dr.Cells["EmailAddress"].Value.ToString();
                    currentCustomer.Password = dr.Cells["Password"].Value.ToString();
                    MessageBox.Show(currentCustomer.CustomerID.ToString());
                }
        }
    }
}
