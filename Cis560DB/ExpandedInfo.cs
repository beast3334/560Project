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
        // // Represents Connection to the SQL Server database
        public SqlConnection sqlconnection;
        // Statement or stored procedure to be executed against a SQL Server database
        public SqlCommand sqlcommand;
        //Represents a set of data
        public DataSet dataset;
        // Table representing data, holds cast of movies
        public DataTable dataTable_Cast;
        // Table representing data, holds movie ratings by reviewers
        public DataTable dataTable_Ratings;
        // Represents a set of data commands and a database connection that are used to fill a dataSet and update the database.
        public SqlDataAdapter sqladapter;


        // String which contains the prameters to establsh connection to sql database
        public string ConnectionString = "Data Source=mssql.cs.ksu.edu;Initial Catalog=cis560_team24;Integrated Security=True";
        //String used to write and store a sql query
        public string Query1;
        //String used to write and store a sql query
        public string Query2;
        //String used to write and store a sql query, query for finding a movie's director
        public string _directorQuery;

        /// <summary>
        /// Initializes the ExpandedInfo Form
        /// </summary>
        public ExpandedInfo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// After the ExpandedInfo Form is loaded, populates the uxReviewGrid with movie ratings and the uxCastGrid with movies cast members
        /// </summary>
        private void ExpandedInfo_Load(object sender, EventArgs e)
        {
            sqlconnection = new SqlConnection(ConnectionString);
            
            sqlcommand = new SqlCommand(Query1, sqlconnection);
            sqladapter = new SqlDataAdapter();
            dataTable_Cast = new DataTable();
            
            sqladapter.SelectCommand = sqlcommand;
            uxCastGrid.DataSource = dataTable_Cast;

            dataTable_Ratings = new DataTable();
            sqlcommand = new SqlCommand(Query2, sqlconnection);
            sqladapter.Fill(dataTable_Cast);

           
            sqladapter.SelectCommand = sqlcommand;
            uxReviewGrid.DataSource = dataTable_Ratings;
            sqladapter.Fill(dataTable_Ratings);
            uxDirectorLabel.Text = "Director: " + GetDirector(sqlconnection);
        }

        /// <summary>
        /// Retrieves the director of a specific movie. 
        /// </summary>
        /// <param name="connection">SqlConnection used to establishes a connection to the database.</param>
        /// <returns>Returns a string value which represents the name of a director of a movie.</returns>
        private string GetDirector(SqlConnection connection)
        {
            SqlCommand cmd = new SqlCommand(_directorQuery, connection);
            connection.Open();
            cmd.CommandType = CommandType.Text;
            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    return rdr[0] + " " + rdr[1].ToString();
                }
            }
            return "";
        }
    }
}
