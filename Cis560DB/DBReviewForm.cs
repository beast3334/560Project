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
    //Delegate used to unlock all button on the DBMenu Form from the DBReviewForm
    public delegate void enableButtonsReview();

    /// <summary>
    /// DBReviewForm Class
    /// </summary>
    public partial class uxDBReviewForm : Form
    {
        public event enableButtonsReview _enableButtons;
        // Represents Connection to the SQL Server database
        SqlConnection sqlconnection;
        // Statement or stored procedure to be executed against a SQL Server database
        SqlCommand sqlcommand;
        // Table representing data
        DataTable datatable;
        // Represents a set of data commands and a database connection that are used to fill a dataSet and update the database.
        SqlDataAdapter sqladapter;

        // String which contains the prameters to establsh connection to sql database
        string ConnectionString = "Data Source=mssql.cs.ksu.edu;Initial Catalog=cis560_team24;Integrated Security=True";
        //// String used to write and store a sql query
        string Query;

        /// <summary>
        /// Initializes the DBReviewForm
        /// </summary>
        public uxDBReviewForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads data from sql tables into the DataGridView uxMovieGrid after the DBReviewForm is load by the user.
        /// </summary>
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

        /// <summary>
        /// Adds a rating of a movie from a user to the database. 
        /// </summary>
        private void uxSubmitButton_Click(object sender, EventArgs e)
        {
            if(!(uxOneStar.Checked || uxTwoStar.Checked || uxThreeStar.Checked || uxFourStar.Checked || uxFiveStar.Checked))
            {
                MessageBox.Show("You must select a rating");
                return;
            }
            string s = uxMovieGrid.SelectedCells[0].Value.ToString();
            using (SqlConnection connection = new SqlConnection("Data Source = mssql.cs.ksu.edu; Initial Catalog = cis560_team24; Integrated Security = True"))
            {
                connection.Open();
                if (!ReviewerExists(connection))
                {
                    //Insert MovieInfo.Reviewer information
                    string query = "INSERT INTO MovieInfo.Reviewer (ReviewerName) VALUES (@param1)";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                    
                        cmd.Parameters.Add("@param1", SqlDbType.NVarChar, 128).Value = uxFirstName.Text;
                        
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                }
                //Insert Review Information

                try
                {
                    string query2 = "INSERT INTO MovieInfo.Rating (MovieId, ReviewerId, ReviewerRating, numberofRatings) VALUES (@param1, @param2, @param3, @param4)";
                    using (SqlCommand cmd = new SqlCommand(query2, connection))
                    {
                        cmd.Parameters.Add("@param1", SqlDbType.Int).Value = uxMovieGrid.SelectedCells[0].Value.ToString();
                        cmd.Parameters.Add("@param2", SqlDbType.Int).Value = GetReviewerId(connection);
                        cmd.Parameters.Add("@param3", SqlDbType.Int).Value = GetRating();
                        cmd.Parameters.Add("@param4", SqlDbType.Int).Value = GetReviewCount(connection);
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();

                    }
                }
                catch
                {
                    MessageBox.Show("A review by that person already exists for this movie!");
                }
                
            }
            MessageBox.Show("Succesfully added review!");
        }

        /// <summary>
        /// Checks if a reviewer already exist in the database.
        /// </summary>
        /// <param name="connection">SqlConnection used to establishes a connection to the database.</param>
        /// <returns>Returns a boolean value which represents if a reviewer already exists in the database. </returns>
        private bool ReviewerExists(SqlConnection connection)
        {
            SqlCommand cmd = new SqlCommand("MovieInfo.CHECK_IF_REVIEWER_EXISTS", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Name", uxFirstName.Text));
            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    int test = Convert.ToInt32(rdr[0]);
                    if (Convert.ToInt32(rdr[0]) == 0)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Retrieves the id of a reviewer with a specific name.
        /// </summary>
        /// <param name="connection">SqlConnection used to establishes a connection to the database.</param>
        /// <returns>Returns an int value that represents the id of an reviewer. </returns>
        private int GetReviewerId(SqlConnection connection)
        {     
            SqlCommand cmd = new SqlCommand("MovieInfo.GET_REVIEWER_ID", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Name", uxFirstName.Text));
            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    return Convert.ToInt32(rdr[0]);
                }
            }
            return 0;
        }

        /// <summary>
        /// Gets the value of a movie rating. 
        /// </summary>
        /// <returns>Returns an int value that represents the value of a rating. </returns>
        private int GetRating()
        {
            if(uxOneStar.Checked)
            {
                return 1;
            }
            else if(uxTwoStar.Checked)
            {
                return 2;
            }
            else if(uxThreeStar.Checked)
            {
                return 3;
            }
            else if(uxFourStar.Checked)
            {
                return 4;
            }
            else if(uxFiveStar.Checked)
            {
                return 5;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Retrieves the number of reviews for a specific movie. 
        /// </summary>
        /// <param name="connection">SqlConnection used to establishes a connection to the database.</param>
        /// <returns>Returns an int value that represents the id of an reviewer</returns>
        private int GetReviewCount(SqlConnection connection)
        {
            SqlCommand cmd = new SqlCommand("MovieInfo.GET_REVIEW_COUNT", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MOVIEID", uxMovieGrid.SelectedCells[0].Value.ToString()));
            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    return Convert.ToInt32(rdr[0]) + 1;
                }
            }
            return 0;
        }

        /// <summary>
        /// Updates the movies loaded in the uxMovieGrid when the text in the uxSearchBox is changed. 
        /// </summary>
        private void uxSearchBox_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(datatable);
            DV.RowFilter = string.Format("MovieTitle LIKE '%{0}%'", uxSearchBox.Text);
            uxMovieGrid.DataSource = DV;
        }

        /// <summary>
        /// When the form closes, uses the delegate to unlock the buttons in the DBMenu Form.
        /// </summary>
        private void ClosingForm(object sender, FormClosedEventArgs e)
        {
            _enableButtons();
        }
    }
}
