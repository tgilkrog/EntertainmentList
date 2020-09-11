using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLayer
{
    public abstract class Item
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string ItemPicture { get; set; }
        public string ItemGenre { get; set; }
        public int ItemScore { get; set; }
        public string ItemThoughts { get; set; }
    }        
}
