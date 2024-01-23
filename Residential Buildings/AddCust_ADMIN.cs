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
    public partial class HomePage_CUSTOMER : UserControl
    {
        int CustID;
        

        SqlConnection connect = new SqlConnection("Data Source=LAPTOP-KGEDKJ8Q\\SQLEXPRESS;Initial Catalog=proj_BUILD;Integrated Security=True");


        SqlCommand query;
        SqlDataAdapter adapter;
        DataTable table;

        public HomePage_CUSTOMER()
        {
            InitializeComponent();
        }

        void clear()
        {
            txtCustomerID.Text = "";
            txtFName.Text = "";
            txtLName.Text = "";
            txtPhone.Text = "";
            dateBDCust.Value = DateTime.Now;
        }

        void CountOfCust()
        {
            connect.Open();

            query = new SqlCommand("SELECT COUNT(*) FROM Customer", connect);
            query.ExecuteNonQuery();

            int GetCCust = Convert.ToInt32(query.ExecuteScalar());
            custCountlbl.Text = GetCCust.ToString();

            connect.Close();
            ShowCust();
        }

        void ShowCust()
        {
            connect.Open();

            adapter = new SqlDataAdapter("select * from Customer", connect);
            table = new DataTable();
            adapter.Fill(table);
            CustData.DataSource = table;

            connect.Close();
        }

        void AddCust()
        {
            connect.Open();

            query = new SqlCommand("INSERT INTO Customer VALUES('" + txtFName.Text + "' , '" + txtLName.Text + "' , '" + txtPhone.Text + "' , '" + dateBDCust.Value.ToString() + "')", connect);

            query.ExecuteNonQuery();

            connect.Close();

            CountOfCust();
            ShowCust();
            clear();
        }

        void EditCust()
        {
            connect.Open();

            query = new SqlCommand("UPDATE Customer SET FName ='" + txtFName.Text + "' , LName = '" + txtLName.Text + "' , Phone = '" + txtPhone.Text + "' , BDay = '" + dateBDCust.Value.ToString() + "' WHERE CustomerID = '"+CustID.ToString()+"'", connect);

            query.ExecuteNonQuery();


            connect.Close();

            ShowCust();
            clear();
        }

        void RemoveCust()
        {
            connect.Open();

            query = new SqlCommand("DELETE FROM Customer WHERE CustomerID = '" + txtCustomerID.Text + "'", connect);    

            query.ExecuteNonQuery();


            connect.Close();

            CountOfCust();
            ShowCust();
            clear();
        }
        
        void Search_cust()
        {

            connect.Open();

            adapter = new SqlDataAdapter("EXECUTE search_Cust @userInput ='" + txtSearchCust.Text + "'", connect);
            table = new DataTable();
            adapter.Fill(table);
            CustData.DataSource = table;
            
            
            connect.Close();

            
        }

        private void AddCust_ADMIN_Load(object sender, EventArgs e)
        {
            ShowCust();
            CountOfCust();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCust();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditCust();
        }

        private void CustData_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CustID = Convert.ToInt32(CustData.Rows[e.RowIndex].Cells[0].Value.ToString());

            txtCustomerID.Text = CustID.ToString();

            txtFName.Text = CustData.Rows[e.RowIndex].Cells[1].Value.ToString();

            txtLName.Text = CustData.Rows[e.RowIndex].Cells[2].Value.ToString();

            txtPhone.Text = CustData.Rows[e.RowIndex].Cells[3].Value.ToString();

            dateBDCust.Value = Convert.ToDateTime(CustData.Rows[e.RowIndex].Cells[4].Value.ToString());

            
        }

        private void RemoveCustBtn_Click(object sender, EventArgs e)
        {
            RemoveCust();
        }

        private void SearchCustBtn_TextChanged(object sender, EventArgs e)
        {
            Search_cust();
            
            
        }
    }
}
