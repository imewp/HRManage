using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class UserInfo
    {
        #region Model
        private string _username;
        private string _userpassword;
        private string _usertype;
        /// <summary>
        /// 用户姓名
        /// </summary>
        public string UserName
        {
            set { _username = value; }
            get { return _username; }
        }
        /// <summary>
        /// 用户密码
        /// </summary>
        public string UserPassword
        {
            set { _userpassword = value; }
            get { return _userpassword; }
        }
        /// <summary>
        /// 用户类型
        /// </summary>
        public string UserType
        {
            set { _usertype = value; }
            get { return _usertype; }
        }
        #endregion Model
    }
}
