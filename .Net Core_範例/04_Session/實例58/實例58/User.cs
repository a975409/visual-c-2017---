using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 實例58
{
    class User
    {
        string _username;
        public string Username
        {
            get { return _username; }
            set
            {
                if(value.Length>15)
                {
                    throw new ArgumentException("使用者名稱長度不能超過15個字元");
                }
                _username = value;
            }
        }

        string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                if(value.Length<8)
                {
                    throw new ArgumentException("密碼長度至少8位");
                }
                _password = value;
            }
        }
    }
}
