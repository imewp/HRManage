using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    public partial class Department
    {
        private readonly DAL.Department dal = new DAL.Department();

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.Department model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.Department model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int DepartmentID)
        {
            return dal.Delete(DepartmentID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.Department GetModel(int DepartmentID)
        {
            return dal.GetModel(DepartmentID);
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
