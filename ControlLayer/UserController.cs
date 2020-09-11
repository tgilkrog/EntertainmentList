using ModelLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControlLayer
{
    public class UserController
    {
        UserDataAccess uda = new UserDataAccess();
        public MELUser GetUserByID(int id)
        {
            return uda.GetUserByID(1);
        }
    }
}
