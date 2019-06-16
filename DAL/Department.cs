using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public class Department
    {
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.Department model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Department(");
            strSql.Append("DepartmentName,HeadOfDepartment,DepartmentPhone)");
            strSql.Append(" values (");
            strSql.Append("@DepartmentName,@HeadOfDepartment,@DepartmentPhone)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@DepartmentName", SqlDbType.NVarChar,50),
					new SqlParameter("@HeadOfDepartment", SqlDbType.NVarChar,50),
					new SqlParameter("@DepartmentPhone", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.DepartmentName;
            parameters[1].Value = model.HeadOfDepartment;
            parameters[2].Value = model.DepartmentPhone;
            int result = 0;
            result = DAL.DBHelper.ExecuteSql(strSql.ToString(), CommandType.Text, parameters);
            if (result > 0)
                return result;
            return result;
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.Department model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Department set ");
            strSql.Append("DepartmentName=@DepartmentName,");
            strSql.Append("HeadOfDepartment=@HeadOfDepartment,");
            strSql.Append("DepartmentPhone=@DepartmentPhone");
            strSql.Append(" where DepartmentID=@DepartmentID");
            SqlParameter[] parameters = {
					new SqlParameter("@DepartmentName", SqlDbType.NVarChar,50),
					new SqlParameter("@HeadOfDepartment", SqlDbType.NVarChar,50),
					new SqlParameter("@DepartmentPhone", SqlDbType.NVarChar,50),
					new SqlParameter("@DepartmentID", SqlDbType.Int,4)};
            parameters[0].Value = model.DepartmentName;
            parameters[1].Value = model.HeadOfDepartment;
            parameters[2].Value = model.DepartmentPhone;
            parameters[3].Value = model.DepartmentID;

            int rows = DBHelper.ExecuteSql(strSql.ToString(), CommandType.Text, parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(Model.Department model)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Department ");
            strSql.Append(" where DepartmentID=@DepartmentID");
            SqlParameter[] parameters = {
					new SqlParameter("@DepartmentID", SqlDbType.Int,4)
			};
            parameters[0].Value = model.DepartmentID;

            int rows = DBHelper.ExecuteSql(strSql.ToString(), CommandType.Text, parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select DepartmentID,DepartmentName,HeadOfDepartment,DepartmentPhone ");
            strSql.Append(" FROM Department ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DBHelper.SelectToDS(strSql.ToString(), CommandType.Text);
        }

        /// <summary>
        /// 获得数据列表，无参数
        /// </summary>
        public DataSet GetList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select DepartmentID,DepartmentName,HeadOfDepartment,DepartmentPhone ");
            strSql.Append(" FROM Department ");
            return DBHelper.SelectToDS(strSql.ToString(),CommandType.Text);
        }
    }
}
