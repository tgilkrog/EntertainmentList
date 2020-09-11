using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models
{
    public class EntertaintmentList
    {
        public List<MovieReview> Movies { get; set; }
        public List<TvSerieReview> TvSeries { get; set; }
        public List<GameReview> Games { get; set; }
    }
}
