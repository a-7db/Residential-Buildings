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
    public partial class Rooms_ADMIN : UserControl
    {
        int RoomID;

        SqlConnection connect = new SqlConnection("Data Source=LAPTOP-KGEDKJ8Q\\SQLEXPRESS;Initial Catalog=proj_BUILD;Integrated Security=True");


        SqlCommand query;
        SqlDataAdapter adapter;
        DataTable table;

        public Rooms_ADMIN()
        {
            InitializeComponent();
        }

        void clear()
        {
            txtRoomID.Text = "";
            txtFloor.Text = "";
            txtCost.Text = "";
            
        }

        void ShowRoom()
        {
            connect.Open();

            adapter = new SqlDataAdapter("select * from Room", connect);
            table = new DataTable();
            adapter.Fill(table);
            RoomData.DataSource = table;

            connect.Close();
        }

        void ShowBID()
        {
            connect.Open();

            query = new SqlCommand("SELECT BuildingID FROM Building", connect);
            adapter.SelectCommand = query;
            table = new DataTable();
            adapter.Fill(table);
            CBoxBuldID.DataSource = table;
            CBoxBuldID.DisplayMember = "BuildingID";
            CBoxBuldID.ValueMember = "BuildingID";

            connect.Close();
        }

        void AddRoom()
        {
            connect.Open();

            query = new SqlCommand("INSERT INTO Room VALUES('" + txtFloor.Text + "' , '" + txtCost.Text + "' , 'yes' , '" + CBoxBuldID.Text + "')", connect);

            query.ExecuteNonQuery();

            connect.Close();

            ShowRoom();
            clear();
            HomePage_ADMIN.HA.NOTrented();
        }

        void EditRoom()
        {
            int bID = int.Parse(CBoxBuldID.Text);
            connect.Open();

            query = new SqlCommand("UPDATE Room SET Floor ='" + txtFloor.Text + "' , CostInMonth = '" + txtCost.Text + "' , Available = 'yes' , BuildingID = '" + bID + "' WHERE RoomID = '" + RoomID + "'", connect);

            query.ExecuteNonQuery();


            connect.Close();

            ShowRoom();
            
            clear();
        }

        void RemoveRoom()
        {
            connect.Open();

            query = new SqlCommand("DELETE FROM Room WHERE RoomID = '" + RoomID + "'", connect);

            query.ExecuteNonQuery();


            connect.Close();

            ShowRoom();

            clear();
        }

        private void Rooms_ADMIN_Load(object sender, EventArgs e)
        {
            ShowRoom();
            ShowBID();
        }

        private void AddRoomBtn_Click(object sender, EventArgs e)
        {
            AddRoom();
        }

        private void EditRoomBtn_Click(object sender, EventArgs e)
        {
            EditRoom();
        }
        string GETavailable;
        public void RoomData_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            RoomID = Convert.ToInt32(RoomData.Rows[e.RowIndex].Cells[0].Value.ToString());

            txtRoomID.Text = RoomID.ToString();

            txtFloor.Text = RoomData.Rows[e.RowIndex].Cells[1].Value.ToString();

            txtCost.Text = RoomData.Rows[e.RowIndex].Cells[2].Value.ToString();

            GETavailable = RoomData.Rows[e.RowIndex].Cells[3].Value.ToString();

            CBoxBuldID.Text = RoomData.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void RemoveRoomBtn_Click(object sender, EventArgs e)
        {
            RemoveRoom();
        }
    }
}
