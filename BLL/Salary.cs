using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    public partial class Salary
    {
        private readonly DAL.Salary dal = new DAL.Salary();

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.Salary model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.Salary model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(Model.Salary model)
        {
            return dal.Delete(model);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        //public Model.Salary GetModel(int SalaryID)
        //{
        //    return dal.GetModel(SalaryID);
        //}

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
