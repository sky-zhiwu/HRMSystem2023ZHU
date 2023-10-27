using HRMSystem.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.DAL
{
    public class DictionaryService
    {
        public List<Dict> GetSex()//得到性别
        {
            List<Dict> dics = new List<Dict>();
            string sql = "select * from dictionary where category = N'性别'";
            using (SqlDataReader reader = SqlHelper.ExecuteReader(sql))
            {
                Dict dc = null;
                while (reader.Read())
                {
                    dc = new Dict();
                    dc.Id = (Guid)reader["Id"];
                    dc.Name = reader["Name"].ToString();
                    dc.Category = reader["Category"].ToString();
                    dics.Add(dc);
                }
            }
            return dics;
        }
        public List<Dict> GetParty()//得到政治面貌
        {
            List<Dict> dics = new List<Dict>();
            string sql = "select * from dictionary where category = N'政治面貌'";
            using (SqlDataReader reader = SqlHelper.ExecuteReader(sql))
            {
                Dict dc = null;
                while (reader.Read())
                {
                    dc = new Dict();
                    dc.Id = (Guid)reader["Id"];
                    dc.Name = reader["Name"].ToString();
                    dc.Category = reader["Category"].ToString();
                    dics.Add(dc);
                }
            }
            return dics;
        }
        public List<Dict> GetEduBack()//得到学历
        {
            List<Dict> dics = new List<Dict>();
            string sql = "select * from dictionary where category = N'学历'";
            using (SqlDataReader reader = SqlHelper.ExecuteReader(sql))
            {
                Dict dc = null;
                while (reader.Read())
                {
                    dc = new Dict();
                    dc.Id = (Guid)reader["Id"];
                    dc.Name = reader["Name"].ToString();
                    dc.Category = reader["Category"].ToString();
                    dics.Add(dc);
                }
            }
            return dics;
        }
        public List<Dict> GetMarrige()//得到婚姻信息
        {
            List<Dict> dics = new List<Dict>();
            string sql = "select * from dictionary where category = N'婚姻状况'";
            using (SqlDataReader reader = SqlHelper.ExecuteReader(sql))
            {
                Dict dc = null;
                while (reader.Read())
                {
                    dc = new Dict();
                    dc.Id = (Guid)reader["Id"];
                    dc.Name = reader["Name"].ToString();
                    dc.Category = reader["Category"].ToString();
                    dics.Add(dc);
                }
            }
            return dics;
        }

    }
}
