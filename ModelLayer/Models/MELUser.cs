using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLayer
{
    public class MELUser
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public EntertainmentList MyEntertainmentList { get; set; }
    }
}
