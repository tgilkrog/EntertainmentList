﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models
{
    public class TvSerie : Item
    {
        public int Seasons { get; set; }
        public int EpisodeLength { get; set; }
    }
}
