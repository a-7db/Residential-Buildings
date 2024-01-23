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
    public partial class CUSTOMER_OResv : UserControl
    {
        int ResID;
        int RoomID;
        string Available;
        


        SqlConnection connect = new SqlConnection("Data Source=LAPTOP-KGEDKJ8Q\\SQLEXPRESS;Initial Catalog=proj_BUILD;Integrated Security=True");


        SqlCommand query;
        SqlDataAdapter adapter;
        DataTable table;


        string CustPass;
        public CUSTOMER_OResv(string GetPass)
        {
            InitializeComponent();
            CustPass = GetPass;
        }

        

        void ShowReservations()
        {
            connect.Open();

            adapter = new SqlDataAdapter("SELECT * FROM Reservation WHERE CustomerID = '"+ CustPass + "'", connect);
            table = new DataTable();
            adapter.Fill(table);
            ForCheckOutData.DataSource = table;

            connect.Close();
        }


        void CheckOut()
        {
            connect.Open();

            query = new SqlCommand("DELETE FROM Reservation WHERE ResID = '" + ResID + "'", connect);

            query.ExecuteNonQuery();

            connect.Close();

            ShowReservations();
        }

        void UpdateRoomState()
        {
            connect.Open();

            query = new SqlCommand("UPDATE Room SET Available = 'yes'" +
                "WHERE RoomID = '" + RoomID + "'", connect);

            query.ExecuteNonQuery();


            connect.Close();

            ShowReservations();
        }


        void EditDateTime()
        {
            connect.Open();

            query = new SqlCommand("UPDATE Reservation SET RentalStart = '" + dateTimeStart.Value.ToString() + "' , RentalEnd = '" + dateTimeEnd.Value.ToString() + "' WHERE ResID = '" + ResID + "'", connect);

            query.ExecuteNonQuery();

            connect.Close();
            ShowReservations();
        }


        private void CUSTOMER_OResv_Load(object sender, EventArgs e)
        {
            ShowReservations();
        }

        private void CheckOutBtn_Click(object sender, EventArgs e)
        {
            CheckOut();
            UpdateRoomState();
        }

        private void ForCheckOutData_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ResID = int.Parse(ForCheckOutData.Rows[e.RowIndex].Cells[0].Value.ToString());

            txtResID.Text = ResID.ToString();

            Available = ForCheckOutData.Rows[e.RowIndex].Cells[2].Value.ToString();

            dateTimeStart.Value = Convert.ToDateTime(ForCheckOutData.Rows[e.RowIndex].Cells[4].Value.ToString());

            dateTimeEnd.Value = Convert.ToDateTime(ForCheckOutData.Rows[e.RowIndex].Cells[5].Value.ToString());

            RoomID = int.Parse(ForCheckOutData.Rows[e.RowIndex].Cells[7].Value.ToString());

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            EditDateTime();
        }
    }
}
