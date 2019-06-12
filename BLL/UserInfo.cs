using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Model;
using System.Security.Cryptography;

namespace BLL
{
    public partial class UserInfo
    {
        private readonly DAL.UserInfo dal = new DAL.UserInfo();
        /// <summary>
        /// 增加一条数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Add(Model.UserInfo userInfo)
        {
            return dal.Add(userInfo);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Update(Model.UserInfo userInfo)
        {
            return dal.Update(userInfo);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        /// <param name="UserName"></param>
        /// <returns></returns>
        public bool Delete(Model.UserInfo userInfo)
        {
            return dal.Delete(userInfo);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataSet GetList(Model.UserInfo userInfo)
        {
            return dal.GetList(userInfo);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <returns></returns>
        public DataSet GetList()
        {
            return dal.GetList();
        }
        public Model.UserInfo ToMD5(Model.UserInfo userInfo)
        {
            byte[] mingwen = Encoding.UTF8.GetBytes(userInfo.UserPassword);
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] miwen = md5.ComputeHash(mingwen);
            userInfo.UserPassword = BitConverter.ToString(miwen).Replace("-", "");
            return userInfo;
        }
    }
}
