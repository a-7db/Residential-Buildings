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
    public partial class Buildings_ADMIN : UserControl
    {
        int BuildingID;

        SqlConnection connect = new SqlConnection("Data Source=LAPTOP-KGEDKJ8Q\\SQLEXPRESS;Initial Catalog=proj_BUILD;Integrated Security=True");


        SqlCommand query;
        SqlDataAdapter adapter;
        DataTable table;



        public Buildings_ADMIN()
        {
            InitializeComponent();
        }

        void clear()
        {
            txtBuildID.Text = "";
            txtLocation.Text = "";
            txtFloorsCount.Text = "";
            txtFamilies.Text = "";
            txtRoomCount.Text = "";
        }

        void ShowBuildings()
        {
            connect.Open();

            adapter = new SqlDataAdapter("select * from Building", connect);
            table = new DataTable();
            adapter.Fill(table);
            BuildData.DataSource = table;

            connect.Close();
        }

        private void Buildings_ADMIN_Load(object sender, EventArgs e)
        {
            ShowBuildings();
        }

        private void BuildData_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BuildingID = int.Parse(BuildData.Rows[e.RowIndex].Cells[0].Value.ToString());

            txtBuildID.Text = BuildingID.ToString();

            txtLocation.Text = BuildData.Rows[e.RowIndex].Cells[1].Value.ToString();

            txtFloorsCount.Text = BuildData.Rows[e.RowIndex].Cells[2].Value.ToString();

            txtFamilies.Text = BuildData.Rows[e.RowIndex].Cells[3].Value.ToString();

            txtRoomCount.Text = BuildData.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        void AddBuilds()
        {
            connect.Open();

            query = new SqlCommand("INSERT INTO Building VALUES('" + txtLocation.Text + "' , '" + txtFloorsCount.Text + "' , '"+ txtFamilies.Text + "' , '" + txtRoomCount.Text + "')", connect);

            query.ExecuteNonQuery();

            connect.Close();

            ShowBuildings();
            clear();
            HomePage_ADMIN.HA.showCountOfBuild();
        }

        void EditBuilds()
        {
            connect.Open();

            query = new SqlCommand("UPDATE Building SET Location ='" + txtLocation.Text + "' , Floors = '" + txtFloorsCount.Text + "' , Families = '" + txtFamilies.Text + "' , Rooms = '" + txtRoomCount.Text + "' WHERE BuildingID = '" + BuildingID + "'", connect);

            query.ExecuteNonQuery();


            connect.Close();

            ShowBuildings();
            clear();
        }

        void RemoveBuilds()
        {
            connect.Open();

            query = new SqlCommand("DELETE FROM Building WHERE BuildingID = '" + BuildingID + "'", connect);

            query.ExecuteNonQuery();


            connect.Close();

            ShowBuildings();
            HomePage_ADMIN.HA.showCountOfBuild();
            clear();
        }

        void Search_Builds()
        {

            connect.Open();

            adapter = new SqlDataAdapter("EXECUTE searchBuild @buildKey ='" + txtSearchBuild.Text + "'", connect);
            table = new DataTable();
            adapter.Fill(table);
            BuildData.DataSource = table;


            connect.Close();


        }

        private void AddBuildBtn_Click(object sender, EventArgs e)
        {
            AddBuilds();
        }

        private void EditBuildBtn_Click(object sender, EventArgs e)
        {
            EditBuilds();
        }

        private void RemoveBuildBtn_Click(object sender, EventArgs e)
        {
            RemoveBuilds();
        }

        private void txtSearchBuild_TextChanged(object sender, EventArgs e)
        {
            Search_Builds();
        }
    }
}
