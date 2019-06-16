using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public partial class Check
    {
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.Check model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into CheckInfo(");
            strSql.Append("EmployeeID,EmployeeName,DepartmentName,CheckContent,CheckResult,CheckPeople,CheckDate,Remarks)");
            strSql.Append(" values (");
            strSql.Append("@EmployeeID,@EmployeeName,@DepartmentName,@CheckContent,@CheckResult,@CheckPeople,@CheckDate,@Remarks)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@EmployeeID", SqlDbType.NVarChar,50),
					new SqlParameter("@EmployeeName", SqlDbType.NVarChar,50),
					new SqlParameter("@DepartmentName", SqlDbType.NVarChar,50),
					new SqlParameter("@CheckContent", SqlDbType.NVarChar,50),
					new SqlParameter("@CheckResult", SqlDbType.NVarChar,50),
					new SqlParameter("@CheckPeople", SqlDbType.NVarChar,50),
					new SqlParameter("@CheckDate", SqlDbType.DateTime),
					new SqlParameter("@Remarks", SqlDbType.NVarChar,-1)};
            parameters[0].Value = model.EmployeeID;
            parameters[1].Value = model.EmployeeName;
            parameters[2].Value = model.DepartmentName;
            parameters[3].Value = model.CheckContent;
            parameters[4].Value = model.CheckResult;
            parameters[5].Value = model.CheckPeople;
            parameters[6].Value = model.CheckDate;
            parameters[7].Value = model.Remarks;
            int result = 0;
            result = DAL.DBHelper.ExecuteSql(strSql.ToString(), CommandType.Text, parameters);
            if (result > 0)
                return result;
            return result;
            
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.Check model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update CheckInfo set ");
            strSql.Append("EmployeeID=@EmployeeID,");
            strSql.Append("EmployeeName=@EmployeeName,");
            strSql.Append("DepartmentName=@DepartmentName,");
            strSql.Append("CheckContent=@CheckContent,");
            strSql.Append("CheckResult=@CheckResult,");
            strSql.Append("CheckPeople=@CheckPeople,");
            strSql.Append("CheckDate=@CheckDate,");
            strSql.Append("Remarks=@Remarks");
            strSql.Append(" where CheckID=@CheckID");
            SqlParameter[] parameters = {
					new SqlParameter("@EmployeeID", SqlDbType.NVarChar,50),
					new SqlParameter("@EmployeeName", SqlDbType.NVarChar,50),
					new SqlParameter("@DepartmentName", SqlDbType.NVarChar,50),
					new SqlParameter("@CheckContent", SqlDbType.NVarChar,50),
					new SqlParameter("@CheckResult", SqlDbType.NVarChar,50),
					new SqlParameter("@CheckPeople", SqlDbType.NVarChar,50),
					new SqlParameter("@CheckDate", SqlDbType.DateTime),
					new SqlParameter("@Remarks", SqlDbType.NVarChar,-1),
					new SqlParameter("@CheckID", SqlDbType.Int,4)};
            parameters[0].Value = model.EmployeeID;
            parameters[1].Value = model.EmployeeName;
            parameters[2].Value = model.DepartmentName;
            parameters[3].Value = model.CheckContent;
            parameters[4].Value = model.CheckResult;
            parameters[5].Value = model.CheckPeople;
            parameters[6].Value = model.CheckDate;
            parameters[7].Value = model.Remarks;
            parameters[8].Value = model.CheckID;

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
        public bool Delete(Model.Check model)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from CheckInfo ");
            strSql.Append(" where CheckID=@CheckID");
            SqlParameter[] parameters = {
					new SqlParameter("@CheckID", SqlDbType.Int,4)
			};
            parameters[0].Value = model.CheckID;

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
            strSql.Append("select CheckID,EmployeeID,EmployeeName,DepartmentName,CheckContent,CheckResult,CheckPeople,CheckDate,Remarks ");
            strSql.Append(" FROM CheckInfo ");
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
            strSql.Append("select CheckID,EmployeeID,EmployeeName,DepartmentName,CheckContent,CheckResult,CheckPeople,CheckDate,Remarks ");
            strSql.Append(" FROM CheckInfo ");
            return DBHelper.SelectToDS(strSql.ToString(), CommandType.Text);
        }
    }
}
