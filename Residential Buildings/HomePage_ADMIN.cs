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
    public partial class HomePage_ADMIN : Form
    {

        SqlConnection connect = new SqlConnection("Data Source=LAPTOP-KGEDKJ8Q\\SQLEXPRESS;Initial Catalog=proj_BUILD;Integrated Security=True");


        SqlCommand query;
        



        string getAdName;

        public static HomePage_ADMIN HA;
        public HomePage_ADMIN(string AdName)
        {
            InitializeComponent();
            getAdName = AdName;

            HA = this;
           
        }

        public void showCountOfBuild()
        {
            connect.Open();

            query = new SqlCommand("SELECT COUNT(*) FROM Building", connect);
            query.ExecuteNonQuery();

            int GetCBuild = Convert.ToInt32(query.ExecuteScalar());
            buildCountlbl.Text = GetCBuild.ToString();


            connect.Close();
        }

        public void ShowRentedRooms()
        {
            connect.Open();

            query = new SqlCommand("SELECT COUNT(*) FROM Reservation WHERE Available = 'no'", connect);
            query.ExecuteNonQuery();

            int GetrentRoom = Convert.ToInt32(query.ExecuteScalar());
            RentedCountlbl.Text = GetrentRoom.ToString();


            connect.Close();
        }

        public void NOTrented()
        {
            connect.Open();

            query = new SqlCommand("SELECT COUNT(*) FROM Room WHERE Available like 'yes'", connect);
            query.ExecuteNonQuery();

            int GetNotRented = Convert.ToInt32(query.ExecuteScalar());
            NOTRentedlbl.Text = GetNotRented.ToString();


            connect.Close();
        }

        private void HomePage_ADMIN_Load(object sender, EventArgs e)
        {
            txtadminName.Text = "welcome    " + getAdName;

            showCountOfBuild();
            ShowRentedRooms();
            NOTrented();
            


            HomePage_CUSTOMER ADC = new HomePage_CUSTOMER();
            adduserControl(ADC);
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            Closebtn.ForeColor = Color.FromArgb(252, 180, 47);
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            Closebtn.ForeColor = Color.FromArgb(44, 44, 47);
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void MinBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        

        //To Show In Container:

        private void adduserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            screenPanel.Controls.Clear();
            screenPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void AddCustBtn_Click(object sender, EventArgs e)
        {
            HomePage_CUSTOMER ADC = new HomePage_CUSTOMER();
            adduserControl(ADC);
        }

        private void ReserveBtn_Click(object sender, EventArgs e)
        {
            Reserve_ADMIN ADC = new Reserve_ADMIN();
            adduserControl(ADC);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Rooms_ADMIN ADC = new Rooms_ADMIN();
            adduserControl(ADC);
        }

        private void BuildPageBtn_Click(object sender, EventArgs e)
        {
            Buildings_ADMIN ADC = new Buildings_ADMIN();
            adduserControl(ADC);
        }

        private void ReservPageBtn_Click(object sender, EventArgs e)
        {
            Checkout_ADMIN ADC = new Checkout_ADMIN();
            adduserControl(ADC);
        }

        private void CheckOutPageBtn_Click(object sender, EventArgs e)
        {
            addADMINS ADC = new addADMINS();
            adduserControl(ADC);
        }

        

        private void MinBtn_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MinBtn_MouseMove(object sender, MouseEventArgs e)
        {
            MinBtn.ForeColor = Color.FromArgb(252, 180, 47);
        }

        private void MinBtn_MouseLeave(object sender, EventArgs e)
        {
            MinBtn.ForeColor = Color.FromArgb(44, 44, 47);

        }

        private void LogOutBtn_Click_1(object sender, EventArgs e)
        {
            LoginPage Lgn = new LoginPage();
            Lgn.Show();
            this.Close();

        }

    }
}
