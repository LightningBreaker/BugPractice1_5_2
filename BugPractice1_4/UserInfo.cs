using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugPractice1_4
{
   public class UserInfo
    {
        private int user_id;
        private string  user_name;
        private int type;
        private string telephone;
        private string email;
        private string password;
        private char is_verified = '0';

        public int User_id { get => user_id; set => user_id = value; }
        public string User_name { get => user_name; set => user_name = value; }
        public int Type { get => type; set => type = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }

        public UserInfo(int a_user_id,string a_user_name,int a_type,string a_telephone,string a_email)
        {
            this.User_id = a_user_id;
            this.User_name = a_user_name;
            this.Type = a_type;
            this.Telephone = a_telephone;
            this.Email = a_email;
        }
        public UserInfo()
        {

        }




    }
}
