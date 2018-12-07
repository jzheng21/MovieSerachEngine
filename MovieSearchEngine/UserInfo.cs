using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSearchEngine
{
    public class UserInfo
    {
        private int UserId { get; set; }
        private string UserName { get; set; }
        private string UserPassword { get; set; }

        public int Login(string un, string pw)
        {
            if(un == UserName)
            {
                if(pw == UserPassword)
                {
                    return UserId;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                return 0;
            }
        }
    }
}
