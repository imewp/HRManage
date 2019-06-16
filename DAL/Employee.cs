using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public partial class Employee
    {
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Model.Employee model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Employee(");
            strSql.Append("EmployeeID,EmployeeName,Sex,Birthday,Phone,HireDate,Education,DepartmentID,Position,Remarks)");
            strSql.Append(" values (");
            strSql.Append("@EmployeeID,@EmployeeName,@Sex,@Birthday,@Phone,@HireDate,@Education,@DepartmentID,@Position,@Remarks)");
            SqlParameter[] parameters = {
					new SqlParameter("@EmployeeID", SqlDbType.NVarChar,50),
					new SqlParameter("@EmployeeName", SqlDbType.NVarChar,50),
					new SqlParameter("@Sex", SqlDbType.NChar,2),
					new SqlParameter("@Birthday", SqlDbType.DateTime),
					new SqlParameter("@Phone", SqlDbType.NVarChar,20),
					new SqlParameter("@HireDate", SqlDbType.DateTime),
					new SqlParameter("@Education", SqlDbType.NVarChar,20),
					new SqlParameter("@DepartmentID", SqlDbType.Int,4),
					new SqlParameter("@Position", SqlDbType.NVarChar,20),
					new SqlParameter("@Remarks", SqlDbType.NVarChar,-1)};
            parameters[0].Value = model.EmployeeID;
            parameters[1].Value = model.EmployeeName;
            parameters[2].Value = model.Sex;
            parameters[3].Value = model.Birthday;
            parameters[4].Value = model.Phone;
            parameters[5].Value = model.HireDate;
            parameters[6].Value = model.Education;
            parameters[7].Value = model.DepartmentID;
            parameters[8].Value = model.Position;
            parameters[9].Value = model.Remarks;

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
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.Employee model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Employee set ");
            strSql.Append("EmployeeName=@EmployeeName,");
            strSql.Append("Sex=@Sex,");
            strSql.Append("Birthday=@Birthday,");
            strSql.Append("Phone=@Phone,");
            strSql.Append("HireDate=@HireDate,");
            strSql.Append("Education=@Education,");
            strSql.Append("DepartmentID=@DepartmentID,");
            strSql.Append("Position=@Position,");
            strSql.Append("Remarks=@Remarks");
            strSql.Append(" where EmployeeID=@EmployeeID ");
            SqlParameter[] parameters = {
					new SqlParameter("@EmployeeName", SqlDbType.NVarChar,50),
					new SqlParameter("@Sex", SqlDbType.NChar,2),
					new SqlParameter("@Birthday", SqlDbType.DateTime),
					new SqlParameter("@Phone", SqlDbType.NVarChar,20),
					new SqlParameter("@HireDate", SqlDbType.DateTime),
					new SqlParameter("@Education", SqlDbType.NVarChar,20),
					new SqlParameter("@DepartmentID", SqlDbType.Int,4),
					new SqlParameter("@Position", SqlDbType.NVarChar,20),
					new SqlParameter("@Remarks", SqlDbType.NVarChar,-1),
					new SqlParameter("@EmployeeID", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.EmployeeName;
            parameters[1].Value = model.Sex;
            parameters[2].Value = model.Birthday;
            parameters[3].Value = model.Phone;
            parameters[4].Value = model.HireDate;
            parameters[5].Value = model.Education;
            parameters[6].Value = model.DepartmentID;
            parameters[7].Value = model.Position;
            parameters[8].Value = model.Remarks;
            parameters[9].Value = model.EmployeeID;

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
        public bool Delete(Model.Employee model)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Employee ");
            strSql.Append(" where EmployeeID=@EmployeeID ");
            SqlParameter[] parameters = {
					new SqlParameter("@EmployeeID", SqlDbType.NVarChar,50)			};
            parameters[0].Value = model.EmployeeID;

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
        /// 得到一个对象实体
        /// </summary>
        //public Model.Employee GetModel(string EmployeeID)
        //{

        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append("select  top 1 EmployeeID,EmployeeName,Sex,Birthday,Phone,HireDate,Education,DepartmentID,Position,Remarks from Employee ");
        //    strSql.Append(" where EmployeeID=@EmployeeID ");
        //    SqlParameter[] parameters = {
        //            new SqlParameter("@EmployeeID", SqlDbType.NVarChar,50)			};
        //    parameters[0].Value = EmployeeID;

        //    Model.Employee model = new Model.Employee();
        //    DataSet ds = DBHelperSQL.Query(strSql.ToString(), parameters);
        //    if (ds.Tables[0].Rows.Count > 0)
        //    {
        //        return DataRowToModel(ds.Tables[0].Rows[0]);
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        //public Model.Employee DataRowToModel(DataRow row)
        //{
        //    Model.Employee model = new Model.Employee();
        //    if (row != null)
        //    {
        //        if (row["EmployeeID"] != null)
        //        {
        //            model.EmployeeID = row["EmployeeID"].ToString();
        //        }
        //        if (row["EmployeeName"] != null)
        //        {
        //            model.EmployeeName = row["EmployeeName"].ToString();
        //        }
        //        if (row["Sex"] != null)
        //        {
        //            model.Sex = row["Sex"].ToString();
        //        }
        //        if (row["Birthday"] != null && row["Birthday"].ToString() != "")
        //        {
        //            model.Birthday = DateTime.Parse(row["Birthday"].ToString());
        //        }
        //        if (row["Phone"] != null)
        //        {
        //            model.Phone = row["Phone"].ToString();
        //        }
        //        if (row["HireDate"] != null && row["HireDate"].ToString() != "")
        //        {
        //            model.HireDate = DateTime.Parse(row["HireDate"].ToString());
        //        }
        //        if (row["Education"] != null)
        //        {
        //            model.Education = row["Education"].ToString();
        //        }
        //        if (row["DepartmentID"] != null && row["DepartmentID"].ToString() != "")
        //        {
        //            model.DepartmentID = int.Parse(row["DepartmentID"].ToString());
        //        }
        //        if (row["Position"] != null)
        //        {
        //            model.Position = row["Position"].ToString();
        //        }
        //        if (row["Remarks"] != null)
        //        {
        //            model.Remarks = row["Remarks"].ToString();
        //        }
        //    }
        //    return model;
        //}

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select EmployeeID,EmployeeName,Sex,Birthday,Phone,HireDate,Education,DepartmentID,Position,Remarks ");
            strSql.Append(" FROM Employee ");
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
            strSql.Append("select EmployeeID,EmployeeName,Sex,Birthday,Phone,HireDate,Education,DepartmentID,Position,Remarks ");
            strSql.Append(" FROM Employee ");
            return DBHelper.SelectToDS(strSql.ToString(), CommandType.Text);
        }
    }
}
