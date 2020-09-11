using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models
{
    public class MELUser
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string ProfilePicture { get; set; }
        public string FavoriteCategory { get; set; }
        public EntertaintmentList MyEntertainmentList { get; set; }
    }
}
