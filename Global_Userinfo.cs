using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugPractice1_4
{
    public class Global_Userinfo
    {
        public static string userid;
        public static string username;
        public static int type;
        public static bool isLogined;

        public const int USER_NOT_VERIFIED = 0;
        public const int ADMINISTRATOR = 1;
        public const int PROJECT_MANAGER = 2;
        public const int TESTER = 3;
        public const int DEVELOPER = 4;


    }
}
