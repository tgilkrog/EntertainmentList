using ModelLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class ReviewDataAccess
    {
        static string connectionString = "Server=DESKTOP-74PJPSM; Initial Catalog=MEL; Integrated Security=true";

        /*ALL Data base stuff related too movies*/
        public void CreateMovieReview(MovieReview mr, int userId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "Insert Into [dbo].[MovieReview](thoughts, score, movieId, userId) values(@thoughts, @score, @movieId, @userId)";
                    cmd.Parameters.AddWithValue("thoughts", mr.Thoughts);
                    cmd.Parameters.AddWithValue("score", mr.Score);
                    cmd.Parameters.AddWithValue("movieId", mr.Movie.ItemID);
                    cmd.Parameters.AddWithValue("userId", userId);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
        public MovieReview GetMovieReviewById(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Select * From [dbo].[MovieReview], [dbo].[Movie] WHERE MovieReview.Id = @id AND MovieReview.movieId = Movie.id", connection);
                connection.Open();

                cmd.Parameters.AddWithValue("id", id);
                var reader = cmd.ExecuteReader();

                MovieReview movieReview = new MovieReview();

                while (reader.Read())
                {
                    movieReview = new MovieReview()
                    {
                        ReviewId = reader.GetInt32(0),
                        Thoughts = reader.GetString(1),
                        Score = reader.GetInt32(2),
                        Movie = new Movie() 
                        { 
                            ItemID = reader.GetInt32(3),
                            ItemName = reader.GetString(6),
                            Picture = reader.GetString(7),
                            Genre = reader.GetString(8),
                            MovieLength = reader.GetInt32(9)
                        }
                    };
                }
                return movieReview;
            };
        }

        public List<MovieReview> GetAllMovieReviewByUserId(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Select * From [dbo].[MovieReview], [dbo].[Movie] WHERE MovieReview.userId = @id AND MovieReview.movieId = Movie.id", connection);
                connection.Open();

                cmd.Parameters.AddWithValue("id", id);
                var reader = cmd.ExecuteReader();

                List<MovieReview> movieReviews = new List<MovieReview>();

                while (reader.Read())
                {
                    MovieReview mr = new MovieReview()
                    {
                        ReviewId = reader.GetInt32(0),
                        Thoughts = reader.GetString(1),
                        Score = reader.GetInt32(2),
                        Movie = new Movie()
                        {
                            ItemID = reader.GetInt32(3),
                            ItemName = reader.GetString(6),
                            Picture = reader.GetString(7),
                            Genre = reader.GetString(8),
                            MovieLength = reader.GetInt32(9)
                        }
                    };
                    movieReviews.Add(mr);
                }
                return movieReviews;
            };
        }

        public void CreateTvSerieReview(TvSerieReview tsr, int userId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "Insert Into [dbo].[TvSerieReview](thoughts, score, tvSerieId, userId) values(@thoughts, @score, @tvSerieId, @userId)";
                    cmd.Parameters.AddWithValue("thoughts", tsr.Thoughts);
                    cmd.Parameters.AddWithValue("score", tsr.Score);
                    cmd.Parameters.AddWithValue("tvSerieId", tsr.TvSerie.ItemID);
                    cmd.Parameters.AddWithValue("userId", userId);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public TvSerieReview GetTvSerieReviewId(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Select * From [dbo].[TvSerieReview], [dbo].[TvSerie] WHERE TvSerieReview.Id = @id AND TvSerieReview.tvSerieId = TvSerie.id", connection);
                connection.Open();

                cmd.Parameters.AddWithValue("id", id);
                var reader = cmd.ExecuteReader();

                TvSerieReview tvSerieReview = new TvSerieReview();

                while (reader.Read())
                {
                    tvSerieReview = new TvSerieReview()
                    {
                        ReviewId = reader.GetInt32(0),
                        Thoughts = reader.GetString(1),
                        Score = reader.GetInt32(2),
                        TvSerie = new TvSerie()
                        {
                            ItemID = reader.GetInt32(3),
                            ItemName = reader.GetString(6),
                            Picture = reader.GetString(7),
                            Genre = reader.GetString(8),
                            Seasons = reader.GetInt32(9),
                            EpisodeLength = reader.GetInt32(10)
                        }
                    };
                }
                return tvSerieReview;
            };
        }

        public List<TvSerieReview> GetAllTvSerieReviewByUserId(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Select * From [dbo].[TvSerieReview], [dbo].[TvSerie] WHERE TvSerieReview.userId = @id AND TvSerieReview.tvSerieId = TvSerie.id", connection);
                connection.Open();

                cmd.Parameters.AddWithValue("id", id);
                var reader = cmd.ExecuteReader();

                List<TvSerieReview> tvSerieReviews = new List<TvSerieReview>();

                while (reader.Read())
                {
                    TvSerieReview tvr = new TvSerieReview()
                    {
                        ReviewId = reader.GetInt32(0),
                        Thoughts = reader.GetString(1),
                        Score = reader.GetInt32(2),
                        TvSerie = new TvSerie()
                        {
                            ItemID = reader.GetInt32(3),
                            ItemName = reader.GetString(6),
                            Picture = reader.GetString(7),
                            Genre = reader.GetString(8),
                            Seasons = reader.GetInt32(9),
                            EpisodeLength = reader.GetInt32(10)
                        }
                    };
                    tvSerieReviews.Add(tvr);
                }
                return tvSerieReviews;
            };
        }

        public void CreateGameReview(GameReview gr, int userId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "Insert Into [dbo].[GameReview](thoughts, score, gameId, userId) values(@thoughts, @score, @gameId, @userId)";
                    cmd.Parameters.AddWithValue("thoughts", gr.Thoughts);
                    cmd.Parameters.AddWithValue("score", gr.Score);
                    cmd.Parameters.AddWithValue("gameId", gr.Game.ItemID);
                    cmd.Parameters.AddWithValue("userId", userId);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public GameReview GetGameReviewById(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Select * From [dbo].[GameReview], [dbo].[Game] WHERE GameReview.Id = @id AND GameReview.gameId = Game.id", connection);
                connection.Open();

                cmd.Parameters.AddWithValue("id", id);
                var reader = cmd.ExecuteReader();

                GameReview gameReview = new GameReview();

                while (reader.Read())
                {
                    gameReview = new GameReview()
                    {
                        ReviewId = reader.GetInt32(0),
                        Thoughts = reader.GetString(1),
                        Score = reader.GetInt32(2),
                        Game = new Game()
                        {
                            ItemID = reader.GetInt32(3),
                            ItemName = reader.GetString(6),
                            Picture = reader.GetString(7),
                            Genre = reader.GetString(8),
                            PlayedTime = reader.GetInt32(9)
                        }
                    };
                }
                return gameReview;
            };
        }

        public List<GameReview> GetAllGameReviewByUserId(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Select * From [dbo].[GameReview], [dbo].[Game] WHERE GameReview.userId = @id AND GameReview.GameId = Game.id", connection);
                connection.Open();

                cmd.Parameters.AddWithValue("id", id);
                var reader = cmd.ExecuteReader();

                List<GameReview> gameReviews = new List<GameReview>();

                while (reader.Read())
                {
                    GameReview gr = new GameReview()
                    {
                        ReviewId = reader.GetInt32(0),
                        Thoughts = reader.GetString(1),
                        Score = reader.GetInt32(2),
                        Game = new Game()
                        {
                            ItemID = reader.GetInt32(3),
                            ItemName = reader.GetString(6),
                            Picture = reader.GetString(7),
                            Genre = reader.GetString(8),
                            PlayedTime = reader.GetInt32(9)
                        }
                    };
                    gameReviews.Add(gr);
                }
                return gameReviews;
            };
        }
    }
}
