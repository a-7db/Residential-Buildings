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
    public partial class addADMINS : UserControl
    {
        int AdmID;
        SqlConnection connect = new SqlConnection("Data Source=LAPTOP-KGEDKJ8Q\\SQLEXPRESS;Initial Catalog=proj_BUILD;Integrated Security=True");


        SqlCommand query;
        SqlDataAdapter adapter;
        DataTable table;


        public addADMINS()
        {
            InitializeComponent();
        }


        void clear()
        {
            txtAdminID.Text = "";
            txtAdName.Text = "";
            txtPass.Text = "";

        }

        void ShowAdmins()
        {
            connect.Open();

            adapter = new SqlDataAdapter("select * from Admin_", connect);
            table = new DataTable();
            adapter.Fill(table);
            AdminData.DataSource = table;

            connect.Close();
        }

        void AddAdm()
        {
            connect.Open();

            query = new SqlCommand("INSERT INTO Admin_ VALUES('" + txtAdName.Text + "' , '" + txtPass.Text + "')", connect);

            query.ExecuteNonQuery();

            connect.Close();

            ShowAdmins();
            clear();
            
        }

        void EditAdm()
        {
            query = new SqlCommand("UPDATE Admin_ SET AdminID ='" + txtAdminID.Text + "' , AdminName = '" + txtAdName.Text + "' , AdminPass = '"+txtPass.Text+"' WHERE AdminID = '" + AdmID + "'", connect);

            query.ExecuteNonQuery();


            connect.Close();

            ShowAdmins();

            clear();
        }


        void RemoveAdm()
        {
            connect.Open();

            query = new SqlCommand("DELETE FROM Admin_ WHERE AdminID = '" + AdmID + "'", connect);

            query.ExecuteNonQuery();


            connect.Close();

            ShowAdmins();

            clear();
        }




        private void addADMINS_Load(object sender, EventArgs e)
        {
            ShowAdmins();
        }

        private void AddCustBtn_Click(object sender, EventArgs e)
        {
            AddAdm();
        }

        private void AdminData_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            AdmID = int.Parse(AdminData.Rows[e.RowIndex].Cells[0].Value.ToString());

            txtAdminID.Text = AdmID.ToString();

            txtAdName.Text = AdminData.Rows[e.RowIndex].Cells[1].Value.ToString();

            txtPass.Text = AdminData.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void EditCustBtn_Click(object sender, EventArgs e)
        {
            EditAdm();
        }

        private void RemoveCustBtn_Click(object sender, EventArgs e)
        {
            RemoveAdm();
        }
    }
}
