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
    public partial class LoginPage : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=LAPTOP-KGEDKJ8Q\\SQLEXPRESS;Initial Catalog=proj_BUILD;Integrated Security=True");


        SqlCommand query;

        
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
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



        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string Tusrname = txt_UsrName.Text;
            string Tpass = txt_pass.Text;


            if (Tusrname != "" && Tpass != "")
            {
                
                    connect.Open();

                    string loginAdmin = "SELECT * FROM Admin_ WHERE AdminName= '" + Tusrname + "' AND AdminPass= '" + Tpass + "'";
                    query = new SqlCommand(loginAdmin, connect);

                    SqlDataReader drAD = query.ExecuteReader();




                    if (drAD.Read() == true)
                    {
                        HomePage_ADMIN FM1 = new HomePage_ADMIN(txt_UsrName.Text);
                        FM1.Show();
                        this.Hide();

                    }
                    else if (drAD.HasRows == false)
                    {
                        connect.Close();
                        connect.Open();
                        string loginCust = "SELECT * FROM Customer WHERE FName= '" + Tusrname + "' AND CustomerID= '" + Tpass + "'";
                        query = new SqlCommand(loginCust, connect);

                        SqlDataReader drCust = query.ExecuteReader();

                        if (drCust.Read() == true)
                        {
                            HomePage_CUSTOMER1 HPC = new HomePage_CUSTOMER1(txt_UsrName.Text, txt_pass.Text);
                            HPC.Show();
                            this.Hide();
                        CUSTOMER_OResv COR = new CUSTOMER_OResv(txt_pass.Text);
                        CUSTOMER_Reserve CRID = new CUSTOMER_Reserve(txt_pass.Text);
                        }
                        else
                        {
                            MessageBox.Show("Try Again", "Incorrect",                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                            txt_UsrName.Focus();
                        }
                        connect.Close();
                    }
                    else
                    {
                        MessageBox.Show("Try Again", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        connect.Close();
                        txt_UsrName.Focus();
                    }


                
            }
            else
            {
                MessageBox.Show("There are no data, Please try again and insert your data", "NO DATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_UsrName.Focus();
            }

        }
        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked)
            {
                txt_pass.PasswordChar = '\u2022';
            }
            else
            {
                txt_pass.PasswordChar = '\0';
            }
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            label3.ForeColor = Color.FromArgb(252, 180, 47);
            label3.Font = new Font(label3.Font,FontStyle.Bold);
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

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            CreateCustomer CC = new CreateCustomer();
            CC.Show();
            this.Hide();
        }
    }
}
