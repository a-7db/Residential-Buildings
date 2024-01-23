using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Residential_Buildings
{

    public partial class CreateCustomer : Form
    {

        SqlConnection connect = new SqlConnection("Data Source=LAPTOP-KGEDKJ8Q\\SQLEXPRESS;Initial Catalog=proj_BUILD;Integrated Security=True");

        SqlCommand query;
        


        public CreateCustomer()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            LoginPage Lgb = new LoginPage();
            Lgb.Show();
            this.Close();
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            label3.ForeColor = Color.FromArgb(252, 180, 47);
            label3.Font = new Font(label3.Font, FontStyle.Bold);
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.FromArgb(70, 132, 194);
            label3.Font = new Font(label3.Font, FontStyle.Regular);
        }

        private void CreateBtn_MouseMove(object sender, MouseEventArgs e)
        {
            CreateBtn.BackColor = Color.FromArgb(252, 180, 47);
        }

        private void CreateBtn_MouseLeave(object sender, EventArgs e)
        {
            CreateBtn.BackColor = Color.Azure;
        }

        private void LoginBtn_MouseMove(object sender, MouseEventArgs e)
        {
            LoginBtn.BackColor = Color.FromArgb(252, 180, 47);
            LoginBtn.ForeColor = Color.Black;
        }

        private void LoginBtn_MouseLeave(object sender, EventArgs e)
        {
            LoginBtn.BackColor = Color.FromArgb(70, 132, 194);
            LoginBtn.ForeColor = Color.White;
        }

        void clear()
        {
            
            txtFName.Text = "";
            txtLName.Text = "";
            txtPhone.Text = "";
            dateBDCust.Value = DateTime.Now;
        }

        void AddCust()
        {
            connect.Open();

            query = new SqlCommand("INSERT INTO Customer VALUES('" + txtFName.Text + "' , '" + txtLName.Text + "' , '" + txtPhone.Text + "' , '" + dateBDCust.Value.ToString() + "')", connect);

            query.ExecuteNonQuery();

            connect.Close();

            clear();
        }
        
        void ShowPassCust()
        {
            connect.Open();

            query = new SqlCommand("SELECT TOP(1) * FROM Customer ORDER BY CustomerID DESC", connect);
            query.ExecuteNonQuery();

            int GetCCust = Convert.ToInt32(query.ExecuteScalar());
            txtCustomerID.Text = "Your Password Is: " + GetCCust.ToString();

            connect.Close();
        }



        private void CreateBtn_Click(object sender, EventArgs e)
        {
            AddCust();
            ShowPassCust();
            txtCustomerID.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            LoginPage lgn = new LoginPage();
            lgn.Show();
            this.Hide();
        }
    }
}
