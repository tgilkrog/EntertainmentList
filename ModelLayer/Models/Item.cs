using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models
{
    public abstract class Item
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string Picture { get; set; }
        public string Genre { get; set; }
    }
}
