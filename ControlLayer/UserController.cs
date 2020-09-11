using ModelLayer;
using ModelLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlLayer
{
    public class UserController
    {
        private readonly UserDataAccess uda = new UserDataAccess();
        private readonly ReviewController rCtr = new ReviewController();

        public void CreateUser(string username, string password, string email)
        {
            MELUser user = new MELUser
            {
                UserName = username,
                Password = password,
                Email = email
            };

            uda.CreateUser(user);
        }
        public MELUser GetUserByID(int id)
        {
            MELUser user = uda.GetUserByID(id);
            user.MyEntertainmentList = rCtr.BuildEntertainmentListByUserId(user.UserID);
            return user;
        }

        public MELUser UserLogin(string username, string password)
        {
            MELUser user = uda.UserLogin(username, password);
            user.MyEntertainmentList = rCtr.BuildEntertainmentListByUserId(user.UserID);
            return user;
        }
    }
}
