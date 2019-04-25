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
    // Delegate 
    public delegate void enableButtonsSearch();

    public partial class uxDBSearchForm : Form
    {
        //Delegate
        public event enableButtonsSearch _enableButtons;


        //Sql commands
        SqlConnection sqlconnection;
        SqlCommand sqlcommand;
        string ConnectionString = "Data Source=mssql.cs.ksu.edu;Initial Catalog=cis560_team24;Integrated Security=True";

        string Query;
        DataSet dataset;
        DataTable datatable;
        SqlDataAdapter sqladapter;



        /*
         * Initializes the DBSearch Form
         */
        public uxDBSearchForm()
        {
            InitializeComponent();
        }

        /*
         * Loads data from sql tables into the DataGridView uxSearchGrid after the DBSearchForm
         * is load by the user. 
         */
        private void uxDBSearchForm_Load(object sender, EventArgs e)
        {
            // This line of code loads data into the 'cis560_team24DataSet3.Movie' table. You can move, or remove it, as needed.
            this.movieTableAdapter.Fill(this.cis560_team24DataSet3.Movie);
            // This line of code loads data into the 'cis560_team24DataSet2.Director' table. You can move, or remove it, as needed.
            this.directorTableAdapter.Fill(this.cis560_team24DataSet2.Director);
            // This line of code loads data into the 'cis560_team24DataSet1.Movie' table. You can move, or remove it, as needed.
            UpdateDataBox();
        }

        /*
         * Used to help filter data accordingly in the uxSearchGrid per user's request. 
         */
        private void uxTitleBox_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(datatable);
            DV.RowFilter = string.Format("MovieTitle LIKE '%{0}%'", uxSearchBox.Text);
            uxSearchGrid.DataSource = DV;
        }

        /*
         * 
         */
        private void uxMoreInfoButton_Click(object sender, EventArgs e)
        {
            ExpandedInfo ei = new ExpandedInfo();
            string s = uxSearchGrid.SelectedCells[0].Value.ToString();
            ei.Query1 = "Select A.FirstName, A.LastName, C.Role From MovieInfo.Actor A INNER JOIN MovieInfo.[Cast] C ON C.ActorId = A.ActorId WHERE C.MovieId = " + s;
            ei.Query2 = "Select R.ReviewerId, MR.ReviewerName, R.ReviewerRating FROM MovieInfo.Rating R INNER JOIN MovieInfo.Reviewer MR ON MR.ReviewerId = R.ReviewerId WHERE R.MovieId =  " + uxSearchGrid.SelectedCells[0].Value.ToString();
            ei.Query3 = "SELECT FirstName, LastName From MovieInfo.Director D INNER JOIN MovieInfo.MovieDirector MD ON MD.DirectorId = D.DirectorId WHERE MD.MovieId = " + uxSearchGrid.SelectedCells[0].Value.ToString();
            ei.Show();
        }

        /*
         * Removes a selected movie in the uxSearchGrid from the movie database.  
         */
        private void uxDeleteButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete? This cannot be undone.","Confirm Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection("Data Source = mssql.cs.ksu.edu; Initial Catalog = cis560_team24; Integrated Security = True"))
                {
                    string id = uxSearchGrid.SelectedCells[0].Value.ToString();
                    connection.Open();
                    string query = "DELETE FROM MovieInfo.Movie WHERE Movieid = " + id + " DELETE FROM MovieInfo.[CAST} WHERE Movieid = " + id;
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                    }
                }
                UpdateDataBox();
                //Re-search 
                DataView DV = new DataView(datatable);
                DV.RowFilter = string.Format("MovieTitle LIKE '%{0}%'", uxSearchBox.Text);
                uxSearchGrid.DataSource = DV;
            }
        }
        private void UpdateDataBox()
        {
            sqlconnection = new SqlConnection(ConnectionString);
            Query = "Select M.MovieId, M.MovieTitle, STRING_AGG(G.GenreTitle, ',') AS Genres, M.[Language], M.ReleaseDate, M.AllTimeBoxOffice FROM MovieInfo.Movie M INNER JOIN MovieInfo.MovieGenre MG ON MG.MovieId = M.MovieId INNER JOIN MovieInfo.Genre G ON G.GenreId = MG.GenreId Group By M.MovieId, M.MovieTitle, M.[Language], M.ReleaseDate, M.AllTimeBoxOffice";
            sqlcommand = new SqlCommand(Query, sqlconnection);
            sqladapter = new SqlDataAdapter();
            datatable = new DataTable();
            sqladapter.SelectCommand = sqlcommand;
            sqladapter.Fill(datatable);
            uxSearchGrid.DataSource = datatable;
        }


        /*
         * When the form closes, uses the delegate to unlock the uxSearchButton in the 
         * DBMenu Form
         */
        private void ClosingForm(object sender, FormClosedEventArgs e)
        {
            _enableButtons();
        }
    }
}
