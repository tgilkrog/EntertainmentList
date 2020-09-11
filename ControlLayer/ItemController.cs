using ModelLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlLayer
{
    public class ItemController
    {
        readonly ItemDataAccess ida = new ItemDataAccess();

        public Movie GetMovieById(int id)
        {
            return ida.GetMovieByID(id);
        }

        public List<Movie> GetAllMovies()
        {
            var sortedList = ida.GetAllMovies().OrderBy(x => x.ItemName).ToList();
            return sortedList;
        }

        public TvSerie GetTvSerieById(int id)
        {
            return ida.GetTvSerieByID(id);
        }

        public List<TvSerie> GetAllTvSeries()
        {

            var sortedList = ida.GetAllTvSeries().OrderBy(x => x.ItemName).ToList();
            return sortedList;
        }

        public Game GetGameById(int id)
        {
            return ida.GetGameByID(id);
        }

        public List<Game> GetAllGames()
        {
            var sortedList = ida.GetAllGames().OrderBy(x => x.ItemName).ToList();
            return sortedList;
        }
    }
}
