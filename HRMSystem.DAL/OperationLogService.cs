using HRMSystem.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using NPOI.SS.Formula.Functions;

namespace HRMSystem.DAL
{
    public class OperationLogService
    {

        public bool Add(OperationLog log)
        {
            string sql = "INSERT INTO OperationLog VALUES (@Id, @OperatorId, @ActionDate, @ActionDesc)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@Id", log.Id),
                new SqlParameter("@OperatorId", log.OperatorId),
                new SqlParameter("@ActionDate", log.ActionDate),
                new SqlParameter("@ActionDesc", log.ActionDesc)
            };
            return SqlHelper.ExecuteNonQuery(sql, parameters) > 0;
        }
        //public DataTable GetLogList(int pageNo, int numPerPage)
        //{
        //    string sql =
        //        "SELECT Temp.Id AS 编号,Operator.RealName AS 操作员, Temp.ActionDate AS 操作时间, Temp.ActionDesc AS 描述 FROM (SELECT TOP(@LogNum) * FROM OperationLog WHERE Id NOT IN(SELECT TOP(@BeforeNum) Id FROM OperationLog)) AS Temp, Operator WHERE Temp.OperatorId = Operator.Id";
        //    SqlParameter[] parameters =
        //    {
        //        new SqlParameter("@LogNum", numPerPage ),
        //        new SqlParameter("@BeforeNum", (pageNo - 1) * numPerPage)
        //    };
        //    return SqlHelper.GetDataTable(sql, parameters);
        //}
        public int GetLogCount(LogSearchWhere lsw)  //按条件获取总记录数
        {
            string sql = "SELECT COUNT(*) FROM OperationLog ";
            List<SqlParameter> whereParameters = new List<SqlParameter>();
            if (lsw != null)
            {
                string whereStr ;
                List<string> whereList = new List<string>();
                if (!string.IsNullOrEmpty(lsw.Name))
                {
                    whereList.Add(string.Format(" operatorid = (select id from operator where RealName = @Name)"));
                    whereParameters.Add(new SqlParameter("@Name", lsw.Name));
                }
                if (lsw.ExistBeginDate)
                {
                    whereList.Add("ActionDate >= @DateFrom");
                    whereParameters.Add(new SqlParameter("@DateFrom", lsw.InDateFrom));
                }
                if (lsw.ExistEndDate)
                {
                    whereList.Add("ActionDate <= @DateTo");
                    whereParameters.Add(new SqlParameter("@DateTo", lsw.InDateTo));
                }
                if (!string.IsNullOrEmpty(lsw.OperationKey))
                {
                    whereList.Add("ActionDesc = @OperationKey");
                    whereParameters.Add(new SqlParameter("@OperationKey", lsw.OperationKey));
                }
                whereStr = string.Join(" and ", whereList);
                if (whereStr != null && whereStr.Length > 0)
                {
                    sql += " where " + whereStr;
                }

            } 
            return (int)SqlHelper.ExecuteScalar(sql, whereParameters.ToArray());
        }
        public  bool TransactionLog(DateTime dateTime)  //日志迁移
        {
            List<string> strSQL = new List<string>();
            strSQL.Add("insert into OperationLogBackup( id, operatorId, actiondate, actiondesc) (select id, operatorId, actiondate, actiondesc from operationlog where actiondate < @Datetime);");
            strSQL.Add("delete from operationlog where actiondate <= @Datetime;") ;
            SqlParameter paradate = new SqlParameter("@Datetime", dateTime);
            return SqlHelper.ExcuteTransactionSQL(strSQL, paradate);
        }
        public List<string> SearchName() //得到日志查询的真实姓名
        {
            List<string> snames = new List<string>();
            string sql = "select distinct(realname) from operator op, operationlog oplog where op.id = oplog.operatorid";
            using (SqlDataReader read = SqlHelper.ExecuteReader(sql))
            {
                while (read.Read())
                {
                    string str = read[0].ToString();
                    snames.Add(str);
                }
            }
            return snames;
        }

        //按条件查询日志
        public DataTable GetLogList(int pageNo, int numPerPage,LogSearchWhere lsw)
        {
            /* string sql = 
                 "SELECT Temp.Id AS 编号,Operator.RealName AS 操作员, Temp.ActionDate AS 操作时间, Temp.ActionDesc AS 描述 " + 
                 "FROM (SELECT TOP(@LogNum) * FROM OperationLog WHERE Id NOT IN(SELECT TOP(@BeforeNum) Id FROM OperationLog))"+
                 " AS Temp, Operator" + 
                 " WHERE Temp.OperatorId = Operator.Id ";*/
            string alllog =
                "SELECT Temp.Id AS 编号,Operator.RealName AS 操作员, Temp.ActionDate AS 操作时间, Temp.ActionDesc AS 描述 " +
                "FROM (SELECT  * FROM OperationLog )" +
                " AS Temp, Operator" +
                " WHERE Temp.OperatorId = Operator.Id ";

            List<SqlParameter> whereParameters = new List<SqlParameter>();
            if (lsw != null)
            {
                List<string> whereList = new List<string>();
                if (!string.IsNullOrEmpty(lsw.Name))
                {
                    whereList.Add(string.Format(" operator.realname = @Name "));
                    whereParameters.Add(new SqlParameter("@Name", lsw.Name));
                }
                if (lsw.ExistBeginDate)
                {
                    whereList.Add("Temp.ActionDate >= @DateFrom");
                    whereParameters.Add(new SqlParameter("@DateFrom", lsw.InDateFrom));
                }
                if (lsw.ExistEndDate)
                {
                    whereList.Add("Temp.ActionDate <= @DateTo");
                    whereParameters.Add(new SqlParameter("@DateTo", lsw.InDateTo));
                }
                if (!string.IsNullOrEmpty(lsw.OperationKey))
                {
                    whereList.Add("Temp.ActionDesc = @OperationKey");
                    whereParameters.Add(new SqlParameter("@OperationKey", lsw.OperationKey));
                }
                string whereStr = string.Join(" and ", whereList);
                if (whereStr != null && whereStr.Length > 0)
                {
                    alllog += " and " + whereStr;
                }
                
            }
            string sql =
                    string.Format("select top(@LogNum) * from ({0}) alllog " +
                    "where alllog.编号 NOT IN(SELECT TOP(@BeforeNum) 编号 FROM " +
                    "({0}) alllog)",alllog);
            whereParameters.Add(new SqlParameter("@LogNum", numPerPage));
            whereParameters.Add(new SqlParameter("@BeforeNum", (pageNo - 1) * numPerPage));
            return SqlHelper.GetDataTable(sql, whereParameters.ToArray());
        }
    }
}
