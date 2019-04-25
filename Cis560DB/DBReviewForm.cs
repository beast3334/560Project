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
    public delegate void enableReviewButton();

    public partial class uxDBReviewForm : Form
    {

        private int _rating;
        private string _movieTitle;
        private string _review;

        SqlConnection sqlconnection;
        SqlCommand sqlcommand;
        string ConnectionString = "Data Source=mssql.cs.ksu.edu;Initial Catalog=cis560_team24;Integrated Security=True";

        string Query;
        DataSet dataset;
        DataTable datatable;
        SqlDataAdapter sqladapter;


        public event enableReviewButton SubmitEvent;

        public uxDBReviewForm()
        {
            InitializeComponent();
            /*
            using (SqlConnection connection = new SqlConnection()) {        // Finish Line
                try {

                    string query = "SELECT MovieTitle FROM Movie"
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conection);
                    connection.Open();
                    DataSet set = new DataSet();
                    adapter.Fill(set, "Movies");
                    SqlCommand command = new SqlCommand(query, db.Connection);
            
                    SqlDataReader reader = .ExecuteReader();
                    while(reader.Read()){
                        uxMovietTitleBox.Items.Add(title);
                    }

                } catch (Exception ex){
                    MessageBox.Show("Error Occured: " + ex);
                }
            }
            */

        }

        

        private void uxSubmit_Click(object sender, EventArgs e)
        {          
            if (_rating > 0 && _movieTitle != null && _review != null){
                /*
                //Code for Query
                string query = ""; // need to add query
                SqlCommand Command = new SqlCommand(query, db.Connection );
                Command.Parameters.Add("@Movie",_movieTitle);
                Command.Parameters.Add("@Rating", _rating);
                Command.Parameters.Add("@Review", _review);
                Command.ExecuteNonQuery();
                */
                SubmitEvent();
                Close();
            } else {
                MessageBox.Show("Please fill out all fields.");
            }
        }

        private void uxDBReviewForm_Load(object sender, EventArgs e)
        {
            sqlconnection = new SqlConnection(ConnectionString);
            Query = "Select * FROM MovieInfo.Movie";
            sqlcommand = new SqlCommand(Query, sqlconnection);
            sqladapter = new SqlDataAdapter();
            datatable = new DataTable();
            sqladapter.SelectCommand = sqlcommand;
            sqladapter.Fill(datatable);
            uxMovieGrid.DataSource = datatable;
        }
    }
}
