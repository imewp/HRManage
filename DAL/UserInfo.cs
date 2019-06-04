using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class UserInfo
    {
        /// <summary>
        /// 增加一条语句
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Add(Model.UserInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into UserInfo(");
            strSql.Append("UserName,UserPassword,UserType)");
            strSql.Append(" values (");
            strSql.Append("@UserName,@UserPassword,@UserType)");
            SqlParameter[] parameters = {
					new SqlParameter("@UserName", SqlDbType.NVarChar,50),
					new SqlParameter("@UserPassword", SqlDbType.NVarChar,50),
					new SqlParameter("@UserType", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.UserName;
            parameters[1].Value = model.UserPassword;
            parameters[2].Value = model.UserType;

            int rows = DBHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool Update(Model.UserInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update UserInfo set ");
            strSql.Append("UserPassword=@UserPassword,");
            strSql.Append("UserType=@UserType");
            strSql.Append(" where UserName=@UserName ");
            SqlParameter[] parameters = {
					new SqlParameter("@UserPassword", SqlDbType.NVarChar,50),
					new SqlParameter("@UserType", SqlDbType.NVarChar,50),
					new SqlParameter("@UserName", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.UserPassword;
            parameters[1].Value = model.UserType;
            parameters[2].Value = model.UserName;

            int rows = DBHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool Delete(string UserName)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from UserInfo ");
            strSql.Append(" where UserName=@UserName ");
            SqlParameter[] parameters = {
					new SqlParameter("@UserName", SqlDbType.NVarChar,50)			};
            parameters[0].Value = UserName;

            int rows = DBHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
        public Model.UserInfo GetModel(string UserName)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 UserName,UserPassword,UserType from UserInfo ");
            strSql.Append(" where UserName=@UserName ");
            SqlParameter[] parameters = {
					new SqlParameter("@UserName", SqlDbType.NVarChar,50)			};
            parameters[0].Value = UserName;

            Model.UserInfo model = new Model.UserInfo();
            DataSet ds = DBHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.UserInfo DataRowToModel(DataRow row)
        {
            Model.UserInfo model = new Model.UserInfo();
            if (row != null)
            {
                if (row["UserName"] != null)
                {
                    model.UserName = row["UserName"].ToString();
                }
                if (row["UserPassword"] != null)
                {
                    model.UserPassword = row["UserPassword"].ToString();
                }
                if (row["UserType"] != null)
                {
                    model.UserType = row["UserType"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select UserName,UserPassword,UserType ");
            strSql.Append(" FROM UserInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DBHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表，无参数
        /// </summary>
        public DataSet GetList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select UserName,UserPassword,UserType ");
            strSql.Append(" FROM UserInfo ");
            return DBHelperSQL.Query(strSql.ToString());
        }
    }
}
