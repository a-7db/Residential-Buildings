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
    public partial class Reserve_ADMIN : UserControl
    {
        int CustID;
        int RoomID;
        int BuildID;
        string floor;
        string CostInMonth;

        SqlConnection connect = new SqlConnection("Data Source=LAPTOP-KGEDKJ8Q\\SQLEXPRESS;Initial Catalog=proj_BUILD;Integrated Security=True");


        SqlCommand query;
        SqlDataAdapter adapter;

        public Reserve_ADMIN()
        {
            InitializeComponent();
        }
        private DataTable custTable = new DataTable();
        void ShowCust()
        {
            connect.Open();

            adapter = new SqlDataAdapter("select * from Customer", connect);
            custTable = new DataTable();
            adapter.Fill(custTable);
            CustData.DataSource = custTable;

            connect.Close();
        }


        void clear()
        {
            txtBuldID.Text = "";
            txtCustID.Text = "";
            txtRoomID.Text = "";
        }


        private DataTable ReseTable = new DataTable();
        void ShowRoom()
        {
            connect.Open();

            adapter = new SqlDataAdapter("select * from Room WHERE Available = 'yes'", connect);
            ReseTable = new DataTable();
            adapter.Fill(ReseTable);
            ReserveData.DataSource = ReseTable;

            connect.Close();
        }

        void Search_cust()
        {

            connect.Open();

            adapter = new SqlDataAdapter("EXECUTE search_Cust @userInput ='" + txtSearchCust.Text + "'", connect);
            custTable = new DataTable();
            adapter.Fill(custTable);
            CustData.DataSource = custTable;


            connect.Close();


        }

        void Search_RoomSYes()
        {

            connect.Open();

            adapter = new SqlDataAdapter("EXECUTE searchAllRooms @allRoooms ='" + txtSearchReserve.Text + "'", connect);
            ReseTable = new DataTable();
            adapter.Fill(ReseTable);
            ReserveData.DataSource = ReseTable;


            connect.Close();


        }

        
        void ReserveBTN()
        {
            
            connect.Open();

            query = new SqlCommand("INSERT INTO Reservation VALUES( '" + CostInMonth + "' , 'no' , '" + floor + "' , '" + dateTimeEnd.Value.ToString() + "' , '" + dateTimeStart.Value.ToString() + "' , '" + txtBuldID.Text + "' , '" + txtRoomID.Text + "' , '" + txtCustID.Text + "' )", connect);

            query.ExecuteNonQuery();

            connect.Close();

            ShowRoom();
            HomePage_ADMIN.HA.ShowRentedRooms();
        }

        void UpdateRoomState()
        {
            connect.Open();

            query = new SqlCommand("UPDATE Room SET Available = 'no'" +
                "WHERE RoomID = '"+txtRoomID.Text+"'", connect);

            query.ExecuteNonQuery();


            connect.Close();

            ShowRoom();
            HomePage_ADMIN.HA.ShowRentedRooms();
            HomePage_ADMIN.HA.NOTrented();
        }

        private void Reserve_ADMIN_Load(object sender, EventArgs e)
        {
            ShowRoom();
            ShowCust();
        }

        private void txtSearchCust_TextChanged(object sender, EventArgs e)
        {
            Search_cust();
            
        }

        private void txtSearchReserve_TextChanged(object sender, EventArgs e)
        {
            Search_RoomSYes();
        }

        private void ReserveBtn_Click(object sender, EventArgs e)
        {
            ReserveBTN();
            UpdateRoomState();
        }
        
        private void CustData_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CustID = int.Parse(CustData.Rows[e.RowIndex].Cells[0].Value.ToString());

            txtCustID.Text = CustID.ToString();
        }
        
        private void ReserveData_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            RoomID = int.Parse(ReserveData.Rows[e.RowIndex].Cells[0].Value.ToString());

            floor = ReserveData.Rows[e.RowIndex].Cells[1].Value.ToString();

            CostInMonth = ReserveData.Rows[e.RowIndex].Cells[2].Value.ToString();

            BuildID = int.Parse(ReserveData.Rows[e.RowIndex].Cells[4].Value.ToString());

            txtRoomID.Text = RoomID.ToString();
            txtBuldID.Text = BuildID.ToString();
        }
    }
}
