using ModelLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewLayer.Controllers
{
    public class ItemController : Controller
    {
        ControlLayer.ItemController iCtr = new ControlLayer.ItemController();

        public ActionResult MovieDetails(int id)
        {
            return View(iCtr.GetMovieById(id));
        }

        public ActionResult AllMovies()
        {
            return View(iCtr.GetAllMovies());
        }

        public ActionResult TvSerieDetails(int id)
        {
            return View(iCtr.GetTvSerieById(id));
        }

        public ActionResult AllTvSeries()
        {
            return View(iCtr.GetAllTvSeries());
        }

        public ActionResult GameDetails(int id)
        {
            return View(iCtr.GetGameById(id));
        }

        public ActionResult AllGames()
        {
            return View(iCtr.GetAllGames());
        }
    }
}