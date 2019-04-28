using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DatabasePopulator
{
    class Program
    {
        static void Main(string[] args)
        {
            PopulateMovie();
            PopulateMovieDirector();
            PopulateMovieDirection();
            PopulateActors();
            PopulateCast();
            PopulateGenres();
            PopulateMovieGenres();
        }
        private static void PopulateMovie()
        {
            List<string[]> MovieList = new List<string[]>();
            using (TextFieldParser parser = new TextFieldParser(@"U:\\560 Final Project\\tmdb_5000_movies.csv"))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                while (!parser.EndOfData)
                {
                    string[] line = new string[5];

                    string[] fields = parser.ReadFields();

                    line[0] = fields[3]; //movieId
                    line[1] = fields[5]; //language
                    line[2] = fields[17]; //title
                    line[3] = fields[11]; //date
                    line[4] = fields[12]; //revenue

                    MovieList.Add(line);
                }
            }
            MovieList.RemoveAt(0); //remove header
            MovieList.RemoveAll(HasNull); //remove any nulls
            using (SqlConnection connection = new SqlConnection("Data Source=mssql.cs.ksu.edu;Initial Catalog=cis560_team24;Integrated Security=True"))
            {

                connection.Open();
                string query = "INSERT INTO MovieInfo.Movie (MovieId, MovieTitle, ReleaseDate, [Language], AllTimeBoxOffice) VALUES (@param1, @param2, @param3, @param4, @param5)";
                int counter = 0;
                foreach (string[] movie in MovieList)
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {


                        cmd.Parameters.Add("@param1", SqlDbType.Int).Value = movie[0];
                        cmd.Parameters.Add("@param2", SqlDbType.NVarChar, 64).Value = movie[2];
                        cmd.Parameters.Add("@param3", SqlDbType.Date).Value = Convert.ToDateTime(movie[3]);
                        cmd.Parameters.Add("@param4", SqlDbType.NVarChar, 3).Value = movie[1];
                        cmd.Parameters.Add("@param5", SqlDbType.BigInt).Value = movie[4];
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Added " + counter);
                        counter++;
                    }

                }
            }
        }
        private static void PopulateMovieDirector()
        {
            List<string[]> DirectorList = new List<string[]>();
            List<List<Dictionary<string, string>>> FinalList = new List<List<Dictionary<string, string>>>();
            using (TextFieldParser parser = new TextFieldParser(@"U:\\560 Final Project\\tmdb_5000_credits.csv"))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                while (!parser.EndOfData)
                {
                    string[] line = new string[5];

                    string[] fields = parser.ReadFields();
                    if (fields[0] == "movie_id")
                        continue;

                    string test = fields[3];
                    JArray a = JArray.Parse(test);


                    List<Dictionary<string, string>> InnerList = new List<Dictionary<string, string>>();
                    foreach (JObject o in a.Children<JObject>())
                    {
                        Dictionary<string, string> dict = new Dictionary<string, string>();

                        foreach (JProperty p in o.Properties())
                        {
                            string name = p.Name;
                            string value = (string)p.Value;
                            dict.Add(name, value);
                        }
                        InnerList.Add(dict);
                    }

                    FinalList.Add(InnerList);

                }
            }
            foreach (List<Dictionary<string, string>> movie in FinalList)
            {
                foreach (Dictionary<string, string> member in movie)
                {
                    string[] director = new string[4];
                    if (member.ContainsValue("Director"))
                    {
                        if (member["name"].Split().Count() < 2)
                        {
                            director[0] = member["name"];
                            director[1] = "";
                            director[2] = member["id"];
                        }
                        else if (member["name"].Split().Count() == 3)
                        {
                            director[0] = member["name"].Split()[0];
                            director[1] = member["name"].Split()[2];
                            director[2] = member["id"];

                        }
                        else
                        {
                            director[0] = member["name"].Split()[0];
                            director[1] = member["name"].Split()[1];
                            director[2] = member["id"];
                        }
                        if (!UsedKey(DirectorList, director[2]))
                        {
                            DirectorList.Add(director);
                        }

                    }
                }
            }

            using (SqlConnection connection = new SqlConnection("Data Source = mssql.cs.ksu.edu; Initial Catalog = cis560_team24; Integrated Security = True"))
            {

                connection.Open();
                string query = "INSERT INTO MovieInfo.Director (DirectorId, FirstName, LastName) VALUES (@param1, @param2, @param3)";
                int counter = 0;
                foreach (string[] director in DirectorList)
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {


                        cmd.Parameters.Add("@param1", SqlDbType.Int).Value = director[2];
                        cmd.Parameters.Add("@param2", SqlDbType.NVarChar, 32).Value = director[0];
                        cmd.Parameters.Add("@param3", SqlDbType.NVarChar, 64).Value = director[1];
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Added " + counter);
                        counter++;
                    }
                }
            }
        }
        private static void PopulateMovieDirection()
        {

            List<string> DirectorList = new List<string>();
            List<List<Dictionary<string, string>>> FinalList = new List<List<Dictionary<string, string>>>();
            List<string> movieIds = new List<string>();
            using (TextFieldParser parser = new TextFieldParser(@"U:\\560 Final Project\\tmdb_5000_credits.csv"))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                while (!parser.EndOfData)
                {
                    string[] line = new string[5];

                    string[] fields = parser.ReadFields();
                    if (fields[0] == "movie_id")
                        continue;

                    string test = fields[3];
                    JArray a = JArray.Parse(test);


                    movieIds.Add(fields[0]);
                    List<Dictionary<string, string>> InnerList = new List<Dictionary<string, string>>();
                    foreach (JObject o in a.Children<JObject>())
                    {
                        Dictionary<string, string> dict = new Dictionary<string, string>();

                        foreach (JProperty p in o.Properties())
                        {
                            string name = p.Name;
                            string value = (string)p.Value;
                            dict.Add(name, value);
                        }
                        InnerList.Add(dict);
                    }

                    FinalList.Add(InnerList);

                }
            }

            foreach (List<Dictionary<string, string>> movie in FinalList)
            {
                foreach (Dictionary<string, string> member in movie)
                {
                    string[] director = new string[4];
                    if (member.ContainsKey("job"))
                    {
                        if (member["job"].Equals("Director"))
                        {
                            DirectorList.Add(member["id"]);
                            break;
                        }

                    }

                }

            }
            Console.WriteLine(movieIds);
            Console.WriteLine(DirectorList);
            using (SqlConnection connection = new SqlConnection("Data Source = mssql.cs.ksu.edu; Initial Catalog = cis560_team24; Integrated Security = True"))
            {

                connection.Open();
                string query = "INSERT INTO MovieInfo.MovieDirector (MovieId, DirectorId) VALUES (@param1, @param2)";
                int counter = 0;
                foreach (string movieId in movieIds)
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        int value = 0;
                        try
                        {
                            foreach (Dictionary<string, string> member in FinalList.ElementAt(counter))
                            {
                                if (member["job"] == "Director")
                                {
                                    value = Convert.ToInt32(member["id"]);
                                    break;
                                }
                                value = 0;
                            }

                        }
                        catch
                        {
                            value = 0;
                        }
                        cmd.Parameters.Add("@param1", SqlDbType.Int).Value = movieId;

                        cmd.Parameters.Add("@param2", SqlDbType.Int).Value = value;




                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Added " + counter);
                        counter++;
                    }
                }
            }
        }
        private static void PopulateActors()
        {
            List<string[]> ActorList = new List<string[]>();
            List<List<Dictionary<string, string>>> FinalList = new List<List<Dictionary<string, string>>>();
            using (TextFieldParser parser = new TextFieldParser(@"U:\\560 Final Project\\tmdb_5000_credits.csv"))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                while (!parser.EndOfData)
                {
                    string[] line = new string[5];

                    string[] fields = parser.ReadFields();
                    if (fields[0] == "movie_id")
                        continue;

                    string test = fields[2];
                    JArray a = JArray.Parse(test);

                    List<Dictionary<string, string>> InnerList = new List<Dictionary<string, string>>();
                    foreach (JObject o in a.Children<JObject>())
                    {
                        Dictionary<string, string> dict = new Dictionary<string, string>();

                        foreach (JProperty p in o.Properties())
                        {
                            string name = p.Name;
                            string value = (string)p.Value;
                            dict.Add(name, value);
                        }
                        InnerList.Add(dict);
                    }

                    FinalList.Add(InnerList);

                }
            }
            foreach (List<Dictionary<string, string>> movie in FinalList)
            {
                foreach (Dictionary<string, string> member in movie)
                {
                    string[] actor = new string[4];

                    if (member["name"].Split().Count() < 2)
                    {
                        actor[0] = member["name"];
                        actor[1] = "";
                        actor[2] = member["id"];
                        actor[3] = member["gender"];
                    }
                    else if (member["name"].Split().Count() == 3)
                    {
                        actor[0] = member["name"].Split()[0];
                        actor[1] = member["name"].Split()[2];
                        actor[2] = member["id"];
                        actor[3] = member["gender"];
                    }
                    else
                    {
                        actor[0] = member["name"].Split()[0];
                        actor[1] = member["name"].Split()[1];
                        actor[2] = member["id"];
                        actor[3] = member["gender"];
                    }
                    if (!UsedKey(ActorList, actor[2]))
                    {
                        ActorList.Add(actor);
                    }

                }
            }
            using (SqlConnection connection = new SqlConnection("Data Source = mssql.cs.ksu.edu; Initial Catalog = cis560_team24; Integrated Security = True"))
            {

                connection.Open();
                string query = "INSERT INTO MovieInfo.Actor (ActorId, FirstName, LastName, Gender) VALUES (@param1, @param2, @param3, @param4)";
                int counter = 0;
                string gender = "N/A";
                foreach (string[] actor in ActorList)
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        if (actor[3] == "0")
                        {
                            gender = "N/A";
                        }
                        else if (actor[3] == "1")
                        {
                            gender = "F";
                        }
                        else
                        {
                            gender = "M";
                        }


                        cmd.Parameters.Add("@param1", SqlDbType.Int).Value = actor[2];
                        cmd.Parameters.Add("@param2", SqlDbType.NVarChar, 32).Value = actor[0];
                        cmd.Parameters.Add("@param3", SqlDbType.NVarChar, 64).Value = actor[1];
                        cmd.Parameters.Add("@param4", SqlDbType.NVarChar, 3).Value = gender;
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Added " + counter);
                        counter++;
                    }
                }
            }
        }
        private static void PopulateCast()
        {
            List<string> ActorList = new List<string>();
            List<List<Dictionary<string, string>>> FinalList = new List<List<Dictionary<string, string>>>();
            List<string> movieIds = new List<string>();
            using (TextFieldParser parser = new TextFieldParser(@"U:\\560 Final Project\\tmdb_5000_credits.csv"))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                while (!parser.EndOfData)
                {
                    string[] line = new string[5];

                    string[] fields = parser.ReadFields();
                    if (fields[0] == "movie_id")
                        continue;

                    string test = fields[2];
                    JArray a = JArray.Parse(test);


                    movieIds.Add(fields[0]);
                    List<Dictionary<string, string>> InnerList = new List<Dictionary<string, string>>();
                    foreach (JObject o in a.Children<JObject>())
                    {
                        Dictionary<string, string> dict = new Dictionary<string, string>();

                        foreach (JProperty p in o.Properties())
                        {
                            string name = p.Name;
                            string value = (string)p.Value;
                            dict.Add(name, value);
                        }
                        InnerList.Add(dict);
                    }

                    FinalList.Add(InnerList);

                }
            }
            using (SqlConnection connection = new SqlConnection("Data Source = mssql.cs.ksu.edu; Initial Catalog = cis560_team24; Integrated Security = True"))
            {

                connection.Open();
                string query = "INSERT INTO MovieInfo.[Cast] (ActorId, MovieId, [Role]) VALUES (@param1, @param2, @param3)";
                int counter = 0;
                int counter2 = 0;
                foreach (string movieId in movieIds)
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        string character;
                        string actorid;


                        foreach (Dictionary<string, string> member in FinalList.ElementAt(counter))
                        {
                            character = member["character"];
                            actorid = member["id"];
                            cmd.Parameters.Add("@param1", SqlDbType.Int).Value = actorid;
                            cmd.Parameters.Add("@param2", SqlDbType.Int).Value = movieId;
                            cmd.Parameters.Add("@param3", SqlDbType.NVarChar, 64).Value = character;
                            cmd.CommandType = CommandType.Text;
                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();
                            counter2++;
                            Console.WriteLine("Added " + counter2);
                        }
                        
                        counter++;

                    }
                }
            }
        }
        private static void PopulateGenres()
        {
            List<string[]> GenreList = new List<string[]>();
            List<List<Dictionary<string, string>>> FinalList = new List<List<Dictionary<string, string>>>();
            using (TextFieldParser parser = new TextFieldParser(@"U:\\560 Final Project\\tmdb_5000_movies.csv"))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                while (!parser.EndOfData)
                {
                    string[] line = new string[5];

                    string[] fields = parser.ReadFields();
                    if (fields[0] == "budget")
                        continue;

                    string test = fields[1];
                    JArray a = JArray.Parse(test);


                    List<Dictionary<string, string>> InnerList = new List<Dictionary<string, string>>();
                    foreach (JObject o in a.Children<JObject>())
                    {
                        Dictionary<string, string> dict = new Dictionary<string, string>();

                        foreach (JProperty p in o.Properties())
                        {
                            string name = p.Name;
                            string value = (string)p.Value;
                            dict.Add(name, value);
                        }
                        InnerList.Add(dict);
                    }

                    FinalList.Add(InnerList);

                }
            }
            foreach (List<Dictionary<string, string>> movie in FinalList)
            {
                foreach (Dictionary<string, string> genre in movie)
                {
                    string[] newgenre = new string[3];

                    newgenre[2] = genre["id"];
                    newgenre[1] = genre["name"];
                    if (!UsedKey(GenreList, newgenre[2]))
                    {
                        GenreList.Add(newgenre);
                    }
                }
            }
            using (SqlConnection connection = new SqlConnection("Data Source=mssql.cs.ksu.edu;Initial Catalog=cis560_team24;Integrated Security=True"))
            {
                
                connection.Open();
                int counter = 0;
                string query = "INSERT INTO MovieInfo.Genre (GenreId, GenreTitle) VALUES (@param1, @param2)";
                foreach (string[] genre in GenreList)
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        
                        cmd.Parameters.Add("@param1", SqlDbType.Int).Value = genre[2];

                        cmd.Parameters.Add("@param2", SqlDbType.NVarChar, 32).Value = genre[1];
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();

                        Console.WriteLine("Added: " + counter++);
                    }
                }
            }
        }
        private static void PopulateMovieGenres()
        {
            List<string> GenreList = new List<string>();
            List<List<Dictionary<string, string>>> FinalList = new List<List<Dictionary<string, string>>>();
            List<string> movieIds = new List<string>();
            using (TextFieldParser parser = new TextFieldParser(@"U:\\560 Final Project\\tmdb_5000_movies.csv"))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                while (!parser.EndOfData)
                {
                    string[] line = new string[5];

                    string[] fields = parser.ReadFields();
                    if (fields[0] == "budget")
                        continue;

                    string test = fields[1];
                    JArray a = JArray.Parse(test);


                    movieIds.Add(fields[3]);
                    List<Dictionary<string, string>> InnerList = new List<Dictionary<string, string>>();
                    foreach (JObject o in a.Children<JObject>())
                    {
                        Dictionary<string, string> dict = new Dictionary<string, string>();

                        foreach (JProperty p in o.Properties())
                        {
                            string name = p.Name;
                            string value = (string)p.Value;
                            dict.Add(name, value);
                        }
                        InnerList.Add(dict);
                    }

                    FinalList.Add(InnerList);

                }
            }
            using (SqlConnection connection = new SqlConnection("Data Source = mssql.cs.ksu.edu; Initial Catalog = cis560_team24; Integrated Security = True"))
            {

                connection.Open();
                string query = "INSERT INTO MovieInfo.MovieGenre (MovieId, GenreId) VALUES (@param1, @param2)";
                int counter = 0;
                int counter2 = 0;
                foreach (string movieId in movieIds)
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        


                        foreach (Dictionary<string, string> member in FinalList.ElementAt(counter))
                        {
                            
                            cmd.Parameters.Add("@param1", SqlDbType.Int).Value = movieId;
                            cmd.Parameters.Add("@param2", SqlDbType.Int).Value = member["id"];
                            cmd.CommandType = CommandType.Text;
                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();
                            counter2++;
                            Console.WriteLine("Added " + counter2);
                        }
                        Console.WriteLine("On Movie: " + counter);
                        counter++;

                    }
                }
            }
        }
        private static bool HasNull(string[] contents)
        {
            if ((contents[0] == null || contents[0] == "") || (contents[1] == null || contents[1] == "") || (contents[2] == null || contents[2] == "") || (contents[3] == null || contents[3] == "") || (contents[4] == null || contents[4] == ""))
            {
                return true;
            }
            return false;
        }
        private static bool UsedKey(List<string[]> contents, string key)
        {
            if(contents.Count == 0)
            {
                return false;
            }
            foreach(string[] director in contents)
            {
                if(director[2] == key)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
