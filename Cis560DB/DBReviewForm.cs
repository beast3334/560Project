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

        private void uxRatingChanged(object sender, EventArgs e)
        {
            _rating = Int32.Parse(uxRatingBox.Text.Substring(0, 1));
        }

        private void uxMovieChanged(object sender, EventArgs e)
        {
            _movieTitle = uxMovietTitleBox.Text;
        }

        private void uxReviewTextBox_TextChanged(object sender, EventArgs e)
        {
            _review = uxReviewTextBox.Text;
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
    }
}
