using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Model;

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
        public bool Add(Model.UserInfo model)
        {
            return dal.Add(model);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Update(Model.UserInfo model)
        {
            return dal.Update(model);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        /// <param name="UserName"></param>
        /// <returns></returns>
        public bool Delete(string UserName)
        {
            return dal.Delete(UserName);
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        /// <param name="UserName"></param>
        /// <returns></returns>
        public Model.UserInfo GetModel(string UserName)
        {
            return dal.GetModel(UserName);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <returns></returns>
        public DataSet GetList()
        {
            return dal.GetList();
        }
    }
}
