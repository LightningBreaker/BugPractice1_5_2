using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugPractice1_4
{
    public class Global_Userinfo
    {
        public static string userid = "13";
        public static string username = "jiugechangba";
        public static int type = PROJECT_MANAGER;
        public static bool isLogined = true;

        public const int USER_NOT_VERIFIED = 0;
        public const int ADMINISTRATOR = 1;
        public const int PROJECT_MANAGER = 2;
        public const int TESTER = 3;
        public const int DEVELOPER = 4;



    }
}
