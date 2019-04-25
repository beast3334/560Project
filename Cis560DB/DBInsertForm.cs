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
    public delegate void enableInsertButton();

    public partial class uxDBInsertForm : Form
    {
        private string _movieTitle;
        private string _director;
        private string _genre;
        private string _language;
        private double _revenue;
        private DateTime _releaseDate;
        private List<string> castList = new List<string>();
        private BindingList<string> bs = new BindingList<string>();

        public enableInsertButton _enableButton;

        public uxDBInsertForm()
        {
            InitializeComponent();
            uxCastList.DataSource = bs;
        }

        private void uxTitleBox_TextChanged(object sender, EventArgs e)
        {
            _movieTitle = uxTitleBox.Text;
        }

        private void uxDirectorBox_TextChanged(object sender, EventArgs e)
        {
            _director = uxDirectorBox.Text;
        }

        private void uxGenreBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _genre = uxGenreBox.Text;
        }

        private void uxLanguageBox_TextChanged(object sender, EventArgs e)
        {
            _language = uxLanguageBox.Text;
        }

        private void uxProfitBox_TextChanged(object sender, EventArgs e)
        {
            try { 
                _revenue = Convert.ToDouble(uxProfitBox.Text);
            } catch (Exception) {
                MessageBox.Show("Please Enter a Double Value. No letters please.");
                uxProfitBox.Text = "";
            }
        }

        private void uxDatePicker_ValueChanged(object sender, EventArgs e)
        {
            _releaseDate = uxDatePicker.Value.Date;
        }

        private void uxAddMovieButton_Click(object sender, EventArgs e)
        {         
            int movieId;
            if (_movieTitle != null && _director != null && _releaseDate != null && _genre != null && _revenue != null && _language !=null)
            {
                bool errorFree = true;
                try
                {
                    using (SqlConnection connection = new SqlConnection("Data Source = mssql.cs.ksu.edu; Initial Catalog = cis560_team24; Integrated Security = True"))
                    {
                        connection.Open();
                        //Insert MovieInfo.Movie information
                        string query = "INSERT INTO MovieInfo.Movie (MovieId, MovieTitle, ReleaseDate, [Language], AllTimeBoxOffice ) VALUES (@param1, @param2, @param3, @param4, @param5)";
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            movieId = GetNextKey("MovieInfo.GET_HIGHEST_MOVIE_KEY", connection);
                            cmd.Parameters.Add("@param1", SqlDbType.Int).Value = movieId;
                            cmd.Parameters.Add("@param2", SqlDbType.NVarChar, 64).Value = uxTitleBox.Text;
                            cmd.Parameters.Add("@param3", SqlDbType.Date).Value = Convert.ToDateTime(uxDatePicker.Text);
                            cmd.Parameters.Add("@param4", SqlDbType.NVarChar, 3).Value = uxLanguageBox.Text;
                            cmd.Parameters.Add("@param5", SqlDbType.BigInt).Value = uxProfitBox.Text;
                            cmd.CommandType = CommandType.Text;
                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();
                        }

                        //insert Actor info (if needed)
                        List<string> actors = uxCastList.Items.Cast<String>().ToList();
                        List<int> actorIds = new List<int>();
                        List<string> actorRoles = new List<string>();
                        List<int> directorIds = new List<int>();
                        foreach (string actor in actors)
                        {
                            string[] pieces = actor.Split('|');
                            if (!CheckIfActorExists(actor, connection))
                            {
                                using (SqlCommand cmd = new SqlCommand("INSERT INTO MovieInfo.Actor (ActorId, FirstName, LastName, Gender) VALUES (@param1, @param2, @param3, @param4)", connection))
                                {
                                    int actorId = GetNextKey("MovieInfo.GET_HIGHEST_ACTOR_KEY", connection);
                                    actorIds.Add(actorId);
                                    cmd.Parameters.Add("@param1", SqlDbType.Int).Value = actorId;
                                    cmd.Parameters.Add("@param2", SqlDbType.NVarChar, 32).Value = pieces[0];
                                    cmd.Parameters.Add("@param3", SqlDbType.NVarChar, 64).Value = pieces[1];
                                    cmd.Parameters.Add("@param4", SqlDbType.NVarChar, 3).Value = pieces[2];
                                    cmd.CommandType = CommandType.Text;
                                    cmd.ExecuteNonQuery();
                                    cmd.Parameters.Clear();
                                }
                            } else {
                                actorIds.Add(GetActorId(actor, connection));
                            }
                            actorRoles.Add(pieces[3]);

                        }
                        //insert cast info
                        int i = 0;
                        foreach (int actorid in actorIds)
                        {
                            using (SqlCommand cmd = new SqlCommand("INSERT INTO MovieInfo.Cast (ActorId, MovieId, Role) VALUES (@param1, @param2, @param3)", connection))
                            {
                                cmd.Parameters.Add("@param1", SqlDbType.Int).Value = actorid;
                                cmd.Parameters.Add("@param2", SqlDbType.Int).Value = movieId;
                                cmd.Parameters.Add("@param3", SqlDbType.NVarChar, 64).Value = actorRoles.ElementAt(i);

                                cmd.CommandType = CommandType.Text;
                                cmd.ExecuteNonQuery();
                                cmd.Parameters.Clear();
                                i++;
                            }
                        }
                        if (!CheckifDirectorExists(connection))
                        {
                            //insert Director
                            using (SqlCommand cmd = new SqlCommand("INSERT INTO MovieInfo.Director (DirectorId, FirstName, LastName) VALUES (@param1, @param2, @param3)", connection))
                            {
                                string[] pieces = uxDirectorBox.Text.Split();
                                int directorid = GetNextKey("MovieInfo.GET_HIGHEST_DIRECTOR_KEY", connection);
                                directorIds.Add(directorid);
                                cmd.Parameters.Add("@param1", SqlDbType.Int).Value = directorid;
                                cmd.Parameters.Add("@param2", SqlDbType.NVarChar, 32).Value = pieces[0];
                                cmd.Parameters.Add("@param3", SqlDbType.NVarChar, 64).Value = pieces[1];
                                cmd.CommandType = CommandType.Text;
                                cmd.ExecuteNonQuery();
                                cmd.Parameters.Clear();
                            }
                        } else {
                            directorIds.Add(GetDirectorId(connection));
                        }

                        //insert MovieDirection
                        foreach (int directorid in directorIds)
                        {
                            using (SqlCommand cmd = new SqlCommand("INSERT INTO MovieInfo.MovieDirector (DirectorId, MovieId) VALUES (@param1, @param2)", connection))
                            {
                                cmd.Parameters.Add("@param1", SqlDbType.Int).Value = directorid;
                                cmd.Parameters.Add("@param2", SqlDbType.Int).Value = movieId;

                                cmd.CommandType = CommandType.Text;
                                cmd.ExecuteNonQuery();
                                cmd.Parameters.Clear();
                            }
                        }
                    }
                } catch (System.Data.SqlClient.SqlException) {
                    MessageBox.Show("Movie already exist in the database");
                    errorFree = false;
                } catch (System.IndexOutOfRangeException){
                    MessageBox.Show("Director needs a first name and last name.");
                    errorFree = false;
                } catch (Exception ex) {
                    MessageBox.Show("Something went wrong, please try again. ( " + ex.ToString() +  ")" );
                    errorFree = false;
                }
                if (errorFree) {
                    MessageBox.Show("Movie Added!");
                }
                Close();
            } else {
                MessageBox.Show("Please fill out all required (*) fields.");
            }
        }

        private void uxAddActor_Click(object sender, EventArgs e)
        {
            bs.Add(uxFirstName.Text + "|" + uxLastName.Text + "|" + uxGender.Text + "|" + uxRole.Text);   
        }
        private int GetNextKey(string query, SqlConnection connection)
        {
            int key = 0;
            SqlCommand retrieve = new SqlCommand(query, connection);
            using (SqlDataReader rdr = retrieve.ExecuteReader())
            {
                while (rdr.Read())
                {
                   key = Convert.ToInt32(rdr[0]);
                }
                key++;
                return key;

            }
        }
        private bool CheckIfActorExists(string actor, SqlConnection connection)
        {
            string[] pieces = actor.Split('|');
            SqlCommand cmd = new SqlCommand("MovieInfo.CHECK_IF_ACTOR_EXIST", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@FirstName", pieces[0]));
            cmd.Parameters.Add(new SqlParameter("@LastName", pieces[1]));
            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while(rdr.Read())
                {
                    int test = Convert.ToInt32(rdr[0]);
                    if(Convert.ToInt32(rdr[0]) == 0)
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
        private int GetActorId(string actor, SqlConnection connection)
        {
            string[] pieces = actor.Split('|');
            SqlCommand cmd = new SqlCommand("MovieInfo.GET_ACTOR_ID", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@FirstName", pieces[0]));
            cmd.Parameters.Add(new SqlParameter("@LastName", pieces[1]));
            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while(rdr.Read())
                {
                    return Convert.ToInt32(rdr[0]);
                }
            }
            return 0;
        }
        private bool CheckifDirectorExists(SqlConnection connection)
        {
            string[] pieces = uxDirectorBox.Text.Split();
            SqlCommand cmd = new SqlCommand("MovieInfo.CHECK_IF_DIRECTOR_EXISTS", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@FirstName", pieces[0]));
            cmd.Parameters.Add(new SqlParameter("@LastName", pieces[1]));
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
        private int GetDirectorId(SqlConnection connection)
        {
            string[] pieces = uxDirectorBox.Text.Split();
            SqlCommand cmd = new SqlCommand("MovieInfo.GET_DIRECTOR_ID", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@FirstName", pieces[0]));
            cmd.Parameters.Add(new SqlParameter("@LastName", pieces[1]));
            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    return Convert.ToInt32(rdr[0]);
                }
            }
            return 0;
        }

        private void ClosingForm(object sender, FormClosedEventArgs e)
        {
            _enableButton();
        }
    }
}
