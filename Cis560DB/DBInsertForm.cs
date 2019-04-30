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
    //Delegate used to unlock all button on the DBMenu Form from the DBInsertForm
    public delegate void enableButtonsInsert();

    /// <summary>
    /// DBInsertForm Class
    /// </summary>
    public partial class uxDBInsertForm : Form
    {
        public enableButtonsInsert _enableButtons;
        // Title of movie being added to database
        private string _movieTitle;
        // Director of movie being added to database
        private string _director;
        // Genre of movie being added to database
        private string _genre;
        // Revenue of movie being added to database
        private double _revenue;
        // Release Date of movie being added to database
        private DateTime _releaseDate;
        // Cast list of movie being added to database(Optional)
        private List<string> castList = new List<string>();        
        // BindingList made of strings, used to bind an cast of actors to a movie
        private BindingList<string> bs = new BindingList<string>();

        /// <summary>
        /// Initializes the DBInsertForm
        /// </summary>
        public uxDBInsertForm()
        {
            InitializeComponent();
            uxCastList.DataSource = bs;
        }

        /// <summary>
        /// Updates _movieTitle when uxTitleBox is changed
        /// </summary>
        private void uxTitleBox_TextChanged(object sender, EventArgs e)
        {
            _movieTitle = uxTitleBox.Text;
        }

        /// <summary>
        /// Updates _director when uxDirectorBox is changed
        /// </summary>
        private void uxDirectorBox_TextChanged(object sender, EventArgs e)
        {
            _director = uxDirectorBox.Text;
        }

        /// <summary>
        /// Updates _genre when uxGenreBox is changed
        /// </summary>
        private void uxGenreBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _genre = uxGenreBox.Text;
        }

        /// <summary>
        /// Updates _revenue when uxProfitBox is changed
        /// </summary>
        private void uxProfitBox_TextChanged(object sender, EventArgs e)
        {
            try { 
                _revenue = Convert.ToDouble(uxProfitBox.Text);
            } catch (Exception) {
                MessageBox.Show("Please Enter a Double Value. No letters please.");
                uxProfitBox.Text = "";
            }
        }

        /// <summary>
        /// Updates _releaseDate when uxDatePicker is changed
        /// </summary>
        private void uxDatePicker_ValueChanged(object sender, EventArgs e)
        {
            _releaseDate = uxDatePicker.Value.Date;
        }

        /// <summary>
        ///  Adds a movie to the database.
        /// </summary>
        private void uxAddMovieButton_Click(object sender, EventArgs e)
        {         
            int movieId;
            if (_movieTitle != null && _director != null && _releaseDate != null)
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
                        //insert Genere
                        using (SqlCommand cmd = new SqlCommand("INSERT INTO MovieInfo.MovieGenre (GenreId, MovieId) VALUES (@param1, @param2)", connection))
                        {
                            cmd.Parameters.Add("@param1", SqlDbType.Int).Value = GetGenreId(connection);
                            cmd.Parameters.Add("@param2", SqlDbType.Int).Value = movieId;
                            cmd.CommandType = CommandType.Text;
                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();
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
                    Close();
                }
            } else {
                MessageBox.Show("Please fill out all required (*) fields.");
            }
        }

        /// <summary>
        /// Adds an actor to the cast list of a movie to be added to the database
        /// </summary>
        private void uxAddActor_Click(object sender, EventArgs e)
        {
            bs.Add(uxFirstName.Text + "|" + uxLastName.Text + "|" + uxGender.Text + "|" + uxRole.Text);
            uxFirstName.Clear();
            uxLastName.Clear();
            uxGender.SelectedIndex = -1;
            uxRole.Clear();
        }

        /// <summary>
        ///  Assigns an id value to an movie, director, or actor. Used when adding a new movie to the database.
        /// </summary>
        /// <param name="query">String that stores the procedure for a query. </param>
        /// <param name="connection">SqlConnection used to establishes a connection to the database. </param>
        /// <returns> Return an int called key which represents an id for either an movie, director, or actor. </returns>
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

        /// <summary>
        /// Checks if a given actor exists in a database.
        /// </summary>
        /// <param name="actor">String which represents the name of an actor. </param>
        /// <param name="connection">SqlConnection used to establishes a connection to the database.</param>
        /// <returns>Returns a boolean value which tells if the actor already exist. </returns>
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

        /// <summary>
        /// Retrieves the actorId of an given actor from a database.
        /// </summary>
        /// <param name="actor">String which represents the name of an actor. </param>
        /// <param name="connection">SqlConnection used to establishes a connection to the database. </param>
        /// <returns>Returns an int value which represents the actorId of an actor. </returns>
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

        /// <summary>
        /// Checks if a given director exists in a database.
        /// </summary>
        /// <param name="connection">SqlConnection used to establishes a connection to the database.</param>
        /// <returns>Returns a boolean value which tells if the director already exist. </returns>
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

        /// <summary>
        /// Retrieves the directorId of an given director from a database.
        /// </summary>
        /// <param name="connection">SqlConnection used to establishes a connection to the database.</param>
        /// <returns>Returns an int value which represents the actorId of an actor.</returns>
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

        /// <summary>
        /// Retrieves the gerneId of an given movie from a database
        /// </summary>
        /// <param name="connection">SqlConnection used to establishes a connection to the database.</param>
        /// <returns>Returns an int value which represents the genre of a movie.</returns>
        private int GetGenreId(SqlConnection connection)
        {
            SqlCommand cmd = new SqlCommand("MovieInfo.GET_GENRE_ID", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 32).Value = uxGenreBox.Text;
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
        /// When the form closes, uses the delegate to unlock the buttons in the DBMenu Form.
        /// </summary>
        private void ClosingForm(object sender, FormClosedEventArgs e)
        {
            _enableButtons();
        }
    }
}
