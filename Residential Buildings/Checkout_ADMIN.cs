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
    public partial class Checkout_ADMIN : UserControl
    {

        int ResID;
        int RoomID;
        string CostInMonth;
        string Available;
        DateTime Start;
        DateTime End;

        SqlConnection connect = new SqlConnection("Data Source=LAPTOP-KGEDKJ8Q\\SQLEXPRESS;Initial Catalog=proj_BUILD;Integrated Security=True");


        SqlCommand query;
        SqlDataAdapter adapter;
        DataTable table;

        public Checkout_ADMIN()
        {
            InitializeComponent();
        }

        void ShowReservations()
        {
            connect.Open();

            adapter = new SqlDataAdapter("select * from Reservation", connect);
            table = new DataTable();
            adapter.Fill(table);
            ForCheckOutData.DataSource = table;

            connect.Close();
        }

        void Search_Resrvations()
        {

            connect.Open();

            adapter = new SqlDataAdapter("EXECUTE search_AvailableRese @usrav1 ='" + txtSearchDetailas.Text + "'", connect);
            table = new DataTable();
            adapter.Fill(table);
            ForCheckOutData.DataSource = table;


            connect.Close();


        }

        private void ResDetails_ADMIN_Load(object sender, EventArgs e)
        {
            ShowReservations();
        }

        private void txtSearchDetailas_TextChanged(object sender, EventArgs e)
        {
            Search_Resrvations();
        }

        private void ForCheckOutData_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ResID = int.Parse(ForCheckOutData.Rows[e.RowIndex].Cells[0].Value.ToString());

            txtResID.Text = ResID.ToString();

            CostInMonth = ForCheckOutData.Rows[e.RowIndex].Cells[1].Value.ToString();

            Available = ForCheckOutData.Rows[e.RowIndex].Cells[2].Value.ToString();

            Start = Convert.ToDateTime(ForCheckOutData.Rows[e.RowIndex].Cells[4].Value.ToString());

            End = Convert.ToDateTime(ForCheckOutData.Rows[e.RowIndex].Cells[5].Value.ToString());

            RoomID = int.Parse(ForCheckOutData.Rows[e.RowIndex].Cells[7].Value.ToString());
        }

        void EditDateTime()
        {
            connect.Open();

            query = new SqlCommand("UPDATE Reservation SET RentalStart = '" + dateTimeStart.Value.ToString() + "' , RentalEnd = '" + dateTimeEnd.Value.ToString() + "' WHERE ResID = '" + ResID + "'", connect);

            query.ExecuteNonQuery();

            connect.Close();
            ShowReservations();
        }

        void CheckOut()
        {
            connect.Open();

            query = new SqlCommand("DELETE FROM Reservation WHERE ResID = '" + ResID + "'", connect);

            query.ExecuteNonQuery();

            connect.Close();

            ShowReservations();
            HomePage_ADMIN.HA.NOTrented();
            HomePage_ADMIN.HA.ShowRentedRooms();
        }

        void UpdateRoomState()
        {
            connect.Open();

            query = new SqlCommand("UPDATE Room SET Available = 'yes'" +
                "WHERE RoomID = '" + RoomID + "'", connect);

            query.ExecuteNonQuery();


            connect.Close();

            ShowReservations();
            HomePage_ADMIN.HA.ShowRentedRooms();
            HomePage_ADMIN.HA.NOTrented();
        }

        private void EditResBtn_Click(object sender, EventArgs e)
        {
            EditDateTime();
        }

        private void CheckOutBtn_Click(object sender, EventArgs e)
        {
            if (txtPay.Text == CostInMonth)
            {
                CheckOut();
                UpdateRoomState();
            }
            else
            {
                MessageBox.Show("The funds Doesn't Match The Real Cost", "Please Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
