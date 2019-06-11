using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    public partial class Employee
    {
        private readonly DAL.Employee dal = new DAL.Employee();

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Model.Employee model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.Employee model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string EmployeeID)
        {
            return dal.Delete(EmployeeID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.Employee GetModel(string EmployeeID)
        {
            return dal.GetModel(EmployeeID);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }

        /// <summary>
        /// 获得数据列表，无参数
        /// </summary>
        public DataSet GetList()
        {
            return dal.GetList();
        }
    }
}
