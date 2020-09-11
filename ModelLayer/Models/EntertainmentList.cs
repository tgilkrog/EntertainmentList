using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLayer
{
    public class EntertainmentList
    {
        public int ELID { get; set; }
        public List<Game> Game { get; set; }
        public List<Movie> Movie { get; set; }
        public List<TVSerie> TVSerie { get; set; }
    }
}
