using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string Thoughts { get; set; }
        public int Score { get; set; }
    }

    public class GameReview : Review
    {
        public Game Game { get; set; }
    }

    public class MovieReview : Review
    {
        public Movie Movie { get; set; }
    }

    public class TvSerieReview : Review
    {
        public TvSerie TvSerie { get; set; }
    }
}
