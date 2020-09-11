using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models
{
    public class ItemDataAccess
    {
        static string connectionString = "Server=DESKTOP-74PJPSM; Initial Catalog=MEL; Integrated Security=true";

        public Movie GetMovieByID(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Select * From [dbo].[Movie] WHERE id = @id", connection);
                connection.Open();

                cmd.Parameters.AddWithValue("id", id);
                var reader = cmd.ExecuteReader();

                Movie movie = new Movie();

                while (reader.Read())
                {
                    movie = new Movie()
                    {
                        ItemID = reader.GetInt32(0),
                        ItemName = reader.GetString(1),
                        Picture = reader.GetString(2),
                        Genre = reader.GetString(3),
                        MovieLength = reader.GetInt32(4)
                    };
                }
                return movie;
            };
        }

        public List<Movie> GetAllMovies()
        {           
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Select * FROM Movie", connection);
                connection.Open();

                List<Movie> movieList = new List<Movie>();
                var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Movie m = new Movie
                        {
                            ItemID = reader.GetInt32(0),
                            ItemName = reader.GetString(1),
                            Picture = reader.GetString(2),
                            Genre = reader.GetString(3),
                            MovieLength = reader.GetInt32(4)
                        };
                        movieList.Add(m);
                    }
                return movieList; 
                }       
        }

        public TvSerie GetTvSerieByID(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Select * From [dbo].[TvSerie] WHERE id = @id", connection);
                connection.Open();

                cmd.Parameters.AddWithValue("id", id);
                var reader = cmd.ExecuteReader();

                TvSerie tvSerie = new TvSerie();

                while (reader.Read())
                {
                    tvSerie = new TvSerie()
                    {
                        ItemID = reader.GetInt32(0),
                        ItemName = reader.GetString(1),
                        Picture = reader.GetString(2),
                        Genre = reader.GetString(3),
                        Seasons = reader.GetInt32(4),
                        EpisodeLength = reader.GetInt32(5)
                    };
                }
                return tvSerie;
            };
        }

        public List<TvSerie> GetAllTvSeries()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Select * FROM TvSerie", connection);
                connection.Open();

                List<TvSerie> tvSerieList = new List<TvSerie>();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TvSerie t = new TvSerie
                    {
                        ItemID = reader.GetInt32(0),
                        ItemName = reader.GetString(1),
                        Picture = reader.GetString(2),
                        Genre = reader.GetString(3),
                        Seasons = reader.GetInt32(4),
                        EpisodeLength = reader.GetInt32(5)
                    };
                    tvSerieList.Add(t);
                }
                return tvSerieList;
            }
        }

        public Game GetGameByID(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Select * From [dbo].[Game] WHERE id = @id", connection);
                connection.Open();

                cmd.Parameters.AddWithValue("id", id);
                var reader = cmd.ExecuteReader();

                Game game = new Game();

                while (reader.Read())
                {
                    game = new Game()
                    {
                        ItemID = reader.GetInt32(0),
                        ItemName = reader.GetString(1),
                        Picture = reader.GetString(2),
                        Genre = reader.GetString(3),
                        PlayedTime = reader.GetInt32(4)
                    };
                }
                return game;
            };
        }

        public List<Game> GetAllGames()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Select * FROM Game", connection);
                connection.Open();

                List<Game> gameList = new List<Game>();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Game g = new Game
                    {
                        ItemID = reader.GetInt32(0),
                        ItemName = reader.GetString(1),
                        Picture = reader.GetString(2),
                        Genre = reader.GetString(3),
                        PlayedTime = reader.GetInt32(4)
                    };
                    gameList.Add(g);
                }
                return gameList;
            }
        }
    }
}
