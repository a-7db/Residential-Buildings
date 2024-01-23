using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Residential_Buildings
{
    public partial class HomePage_CUSTOMER1 : Form
    {


        string CustName;
        string CustPass;
        public HomePage_CUSTOMER1(string GetName, string GetPass)
        {
            InitializeComponent();

            CustName = GetName;
            CustPass = GetPass;
        }



        private void adduserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            CustScreenPanel.Controls.Clear();
            CustScreenPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void ReserveBtn_Click(object sender, EventArgs e)
        {
            CUSTOMER_Reserve USC = new CUSTOMER_Reserve(CustPass);
            adduserControl(USC);
        }



        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            LoginPage Lgn = new LoginPage();
            Lgn.Show();
            this.Close();

        }

        private void YourReservationBtn_Click(object sender, EventArgs e)
        {
            CUSTOMER_OResv USC = new CUSTOMER_OResv(CustPass);
            adduserControl(USC);
        }

        private void HomePage_CUSTOMER1_Load_1(object sender, EventArgs e)
        {
            lblCustName.Text = "Welcome    " + CustName;

            CUSTOMER_Reserve USC = new CUSTOMER_Reserve(CustPass);
            adduserControl(USC);
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            LoginPage lgn = new LoginPage();
            lgn.Close();
            this.Close();
        }

        private void Closebtn_MouseMove(object sender, MouseEventArgs e)
        {
            Closebtn.ForeColor = Color.FromArgb(70, 132, 194);
        }

        private void Closebtn_MouseLeave(object sender, EventArgs e)
        {
            Closebtn.ForeColor = Color.FromArgb(44, 44, 47);

        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MinBtn_MouseMove(object sender, MouseEventArgs e)
        {
            MinBtn.ForeColor = Color.FromArgb(70, 132, 194);
        }

        private void MinBtn_MouseLeave(object sender, EventArgs e)
        {
            MinBtn.ForeColor = Color.FromArgb(44, 44, 47);
        }
    }
}
