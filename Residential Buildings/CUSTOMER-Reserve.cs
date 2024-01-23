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
    public partial class CUSTOMER_Reserve : UserControl
    {
        int RoomID;
        string floor;
        string CostInMonth;
        int BuildingID;


        SqlConnection connect = new SqlConnection("Data Source=LAPTOP-KGEDKJ8Q\\SQLEXPRESS;Initial Catalog=proj_BUILD;Integrated Security=True");


        SqlCommand query;
        SqlDataAdapter adapter;
        DataTable table;

        string CustID;
        public CUSTOMER_Reserve(string GetID)
        {
            InitializeComponent();

            CustID = GetID;
        }


        void ShowRoom()
        {
            connect.Open();

            adapter = new SqlDataAdapter("select * from Room WHERE Available = 'yes'", connect);
            table = new DataTable();
            adapter.Fill(table);
            RoomData.DataSource = table;

            connect.Close();
        }


        void ReserveBTN()
        {

            connect.Open();

            query = new SqlCommand("INSERT INTO Reservation VALUES( '" + CostInMonth + "' , 'no' , '" + floor + "' , '" + dateTimeStart.Value.ToString() + "' , '" + dateTimeEnd.Value.ToString() + "' , '" + BuildingID + "' , '" + RoomID + "' , '" + txtCustID.Text + "' )", connect);

            query.ExecuteNonQuery();

            connect.Close();

            ShowRoom();

        }

        void UpdateRoomState()
        {
            connect.Open();

            query = new SqlCommand("UPDATE Room SET Available = 'no'" +
                "WHERE RoomID = '" + RoomID + "'", connect);

            query.ExecuteNonQuery();


            connect.Close();

            ShowRoom();

        }




        private void CUSTOMER_Reserve_Load(object sender, EventArgs e)
        {
            ShowRoom();
        }

        private void ReserveBtn1_Click(object sender, EventArgs e)
        {
            if (txtCustID.Text == CustID && txtPay.Text == CostInMonth)
            {
                ReserveBTN();
                UpdateRoomState();
                lblFund.ForeColor = Color.FromArgb(50, 198, 113);
                lblFund.Visible = true;
                DoneLine.Visible = true;
            }
            else
            {
                lblFund.ForeColor = Color.Red;
                DoneLine.BackColor = Color.Red;
                lblFund.Visible = true;
                DoneLine.Visible = true;

                MessageBox.Show("Try Again", "INCORRECT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                

            }

        }

        private void RoomData_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            RoomID = int.Parse(RoomData.Rows[e.RowIndex].Cells[0].Value.ToString());

            floor = RoomData.Rows[e.RowIndex].Cells[1].Value.ToString();

            CostInMonth = RoomData.Rows[e.RowIndex].Cells[2].Value.ToString();

            if (RoomData.Rows[e.RowIndex].Cells[2].Value != null)
            {
                lblFund.Text = CostInMonth + " SAR";
                lblFund.Visible = true;
            }

            BuildingID = int.Parse(RoomData.Rows[e.RowIndex].Cells[4].Value.ToString());
        }
    }
}
