using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data;
using System.IO;
namespace Systems_Analysis_Final_Project_by_Victor_Besson
{
    public class User
    {
        private int userID;
        private string userName;
        private string password;
        private string email;
        private string joinDate;
        private int numPosts;
        private int numPages;
        private int numComments;
        private bool banned;
        private Bitmap avatar;
        private bool admin = false;
        public User(DataTable userInfo)
        {
            userID = (int)userInfo.Rows[0]["UserID"];
            userName = userInfo.Rows[0]["Username"].ToString();
            password = userInfo.Rows[0]["Password"].ToString();
            email = userInfo.Rows[0]["Email"].ToString();
            joinDate = userInfo.Rows[0]["JoinDate"].ToString();
            numPosts = (int)userInfo.Rows[0]["NumPosts"];
            numPages = (int)userInfo.Rows[0]["NumPages"];
            numComments = (int)userInfo.Rows[0]["NumComments"];
            banned = (bool)userInfo.Rows[0]["Banned"];
            avatar = db.ByteArrayToImage((byte[])userInfo.Rows[0]["AvatarImage"]);
            if ((int)userInfo.Rows[0]["Admin"] == 0)
                admin = false;
            else
                admin = true;
        }
        public Bitmap Avatar { get { return avatar; } }
        public string UserName { get { return userName; } }
        public bool Admin { get { return admin; } }
        public string UserID { get { return userID.ToString(); } }
        public bool Banned { get { return banned; } }
    }
}
