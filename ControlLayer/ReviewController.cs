using ModelLayer;
using ModelLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlLayer
{
    public class ReviewController
    {
        ReviewDataAccess rda = new ReviewDataAccess();

        public MovieReview GetMovieReviewById(int id)
        {
            return rda.GetMovieReviewById(id);
        }

        public void CreateMovieReview(string thoughts, int score, int movieId, int userId)
        {
            MovieReview mr = new MovieReview
            {
                Thoughts = thoughts,
                Score = score
            };
            Movie m = new Movie
            {
                ItemID = movieId
            };
            mr.Movie = m;

            rda.CreateMovieReview(mr, userId);
        }

        public TvSerieReview GetTvSerieReviewById(int id)
        {
            return rda.GetTvSerieReviewId(id);
        }

        public void CreateTvSerieReview(string thoughts, int score, int tvSerieId, int userId)
        {
            TvSerieReview tsr = new TvSerieReview
            {
                Thoughts = thoughts,
                Score = score
            };
            TvSerie t = new TvSerie
            {
                ItemID = tvSerieId
            };
            tsr.TvSerie = t;

            rda.CreateTvSerieReview(tsr, userId);
        }


        public GameReview GetGameReviewById(int id)
        {
            return rda.GetGameReviewById(id);
        }

        public void CreateGameReview(string thoughts, int score, int gameId, int userId)
        {
            GameReview gr = new GameReview
            {
                Thoughts = thoughts,
                Score = score
            };
            Game g = new Game
            {
                ItemID = gameId
            };
            gr.Game = g;

            rda.CreateGameReview(gr, userId);
        }

        public List<MovieReview> GetAllMovieReviewByUserId(int id)
        {
            return rda.GetAllMovieReviewByUserId(id);
        }

        public EntertaintmentList BuildEntertainmentListByUserId(int id)
        {
            EntertaintmentList et = new EntertaintmentList();
            et.Movies = rda.GetAllMovieReviewByUserId(id);
            et.TvSeries = rda.GetAllTvSerieReviewByUserId(id);
            et.Games = rda.GetAllGameReviewByUserId(id);

            return et;
        }
    }
}
