using ModelLayer.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewLayer.Controllers
{
    public class ReviewController : Controller
    {
        readonly ControlLayer.ReviewController rCtr = new ControlLayer.ReviewController();
        // GET: Review
        public ActionResult ReviewDetails(int id)
        {
            return View(rCtr.GetMovieReviewById(id));
        }

        [HttpPost]
        public ActionResult CreateMovieReview(string thoughts, int score, int movieId)
        {
            int userId = Convert.ToInt32(Session["userID"]);
            rCtr.CreateMovieReview(thoughts, score, movieId, userId);
            
            return RedirectToAction("AllMovies", "Item");
        }

        public ActionResult TvSerieReviewDetails(int id)
        {
            return View(rCtr.GetTvSerieReviewById(id));
        }

        [HttpPost]
        public ActionResult CreateTvSerieReview(string thoughts, int score, int tvSerieId)
        {
            int userId = Convert.ToInt32(Session["userID"]);
            rCtr.CreateTvSerieReview(thoughts, score, tvSerieId, userId);

            return RedirectToAction("AllTvSeries", "Item");
        }

        public ActionResult GameReviewDetails(int id)
        {
            return View(rCtr.GetGameReviewById(id));
        }

        [HttpPost]
        public ActionResult CreateGameReview(string thoughts, int score, int gameId)
        {
            int userId = Convert.ToInt32(Session["userID"]);
            rCtr.CreateGameReview(thoughts, score, gameId, userId);

            return RedirectToAction("AllTvSeries", "Item");
        }
    }
}