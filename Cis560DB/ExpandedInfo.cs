using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cis560DB
{
    public partial class ExpandedInfo : Form
    {
        public ExpandedInfo()
        {
            InitializeComponent();
        }
        public SqlConnection sqlconnection;
        public SqlCommand sqlcommand;
        public string ConnectionString = "Data Source=mssql.cs.ksu.edu;Initial Catalog=cis560_team24;Integrated Security=True";

        public string Query1;
        public string Query2;
        public DataSet dataset;
        public DataTable datatable1;
        public DataTable datatable2;
        public SqlDataAdapter sqladapter;

        private void ExpandedInfo_Load(object sender, EventArgs e)
        {
            sqlconnection = new SqlConnection(ConnectionString);
            
            sqlcommand = new SqlCommand(Query1, sqlconnection);
            sqladapter = new SqlDataAdapter();
            datatable1 = new DataTable();
            
            sqladapter.SelectCommand = sqlcommand;
            uxCastGrid.DataSource = datatable1;

            datatable2 = new DataTable();
            sqlcommand = new SqlCommand(Query2, sqlconnection);
            sqladapter.Fill(datatable1);

           
            sqladapter.SelectCommand = sqlcommand;
            uxReviewGrid.DataSource = datatable2;
            sqladapter.Fill(datatable2);
        }

        private void uxCastGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
