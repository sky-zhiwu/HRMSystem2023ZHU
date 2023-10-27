using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMSystem.Model;
using static System.Net.Mime.MediaTypeNames;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.IO;

namespace HRMSystem.DAL
{
    public class EmployeeService
    {
        public DataTable GetEmployeeList(EmployeeSearchWhere esw)
        {
            string sql =
                "select id  编号, number 工号, name 姓名, inday 入职时间, nation 民族, nativeplace 籍贯 from Employee ";

            List<SqlParameter> whereParameters = new List<SqlParameter>();
            if (esw != null)
            {
                string whereStr = null;
                List<string> whereList = new List<string>();
                if (!string.IsNullOrEmpty(esw.Name))
                {
                    whereList.Add(string.Format("Name like N'%' + @Name + '%'"));
                    whereParameters.Add(new SqlParameter("@Name", esw.Name));
                }
                if (esw.ExistDate)
                {
                    whereList.Add("InDay between @DateFrom and  @DateTo");
                    whereParameters.Add(new SqlParameter("@DateFrom", esw.InDateFrom));
                    whereParameters.Add(new SqlParameter("@DateTo", esw.InDateTo));
                }
                if (esw.DeptId != Guid.Empty)
                {
                    whereList.Add("DepartmentId = @DeptId");
                    whereParameters.Add(new SqlParameter("@DeptId", esw.DeptId));
                }
                whereStr = string.Join("and", whereList);
                if(whereStr!= null && whereStr.Length > 0)
                {
                    sql += " where " + whereStr ;
                }
                else
                {
                    sql += " where (IsDeleted is null or IsDeleted = 0)";
                }
                
            }
            else
            {
                sql += " where (IsDeleted is null or IsDeleted = 0)";
            }
            return SqlHelper.GetDataTable(sql, whereParameters.ToArray());
        }

        public Employee GetEmployee(Guid id) //通过id找到员工
        {
            string sql = "select * from employee where id = @Id and (IsDeleted is null or IsDeleted = 0)";
            SqlParameter paraId = new SqlParameter("@Id", id);
            
            using (SqlDataReader reader = SqlHelper.ExecuteReader(sql, paraId))
            {
                Employee employee = null;
                if (reader.Read())
                {
                    employee = new Employee();
                    employee.Number = reader["Number"].ToString();
                    employee.Name = reader["Name"].ToString();
                    employee.BirthDay = (DateTime)reader["BirthDay"];
                    employee.InDay = (DateTime)reader["InDay"];
                    employee.MarriageId = (Guid)reader["MarriageId"];
                    employee.PartyId = (Guid)reader["PartyId"];
                    employee.EducationId = (Guid)reader["EducationId"];
                    employee.GenderId = (Guid)reader["GenderId"];
                    employee.DepartmentId = (Guid)reader["DepartmentId"];
                    employee.TelePhone = reader["TelePhone"].ToString();
                    employee.Address = reader["Address"].ToString();
                    employee.Email = reader["Email"].ToString(); 
                    employee.Remarks = reader["Remarks"].ToString();
                    employee.Resume = reader["Resume"].ToString();
                    employee.IsDeleted = bool.Parse(reader["IsDeleted"].ToString());
                    if(reader["Photo"] != DBNull.Value)
                    {
                        employee.Photo = (byte[])reader["Photo"];
                    }
                    else
                    {
                        employee.Photo = null;
                    }
                    employee.Nation = reader["Nation"].ToString();
                    employee.NativePlace = reader["NativePlace"].ToString();
                    
                }
               
                return employee;
            }
        }
        public int GetEmployeeCount(Guid deptId) //通过部门id获取员工个数
        {
            string sql = "select count(*) from employee where departmentid = @deptId and (IsDeleted is null or IsDeleted = 0) ";
            SqlParameter pataid = new SqlParameter("@deptId", deptId);
            return (int)SqlHelper.ExecuteScalar(sql, pataid);
        }
        public bool AddEmployee(Employee employee)//添加员工
        {
            string sql =
                "insert into employee values (@Id, @Number, @Name, @BirthDay, @InDay, @MarriageId, @PartyId, @EducationId, @GenderId, @DepartmentId, @TelePhone, @Address, @Email, @Remarks, @Resume, @Photo,  @Nation, @NativePlace, 0);";
            SqlParameter paraPhoto = new SqlParameter("@Photo", SqlDbType.Image);
            if(employee.Photo == null)
            {
                paraPhoto.Value = DBNull.Value;
            }
            else
            {
                paraPhoto.Value = employee.Photo;
            }
            SqlParameter[] parameters =
            {
                new SqlParameter("@Id",employee.Id),
                new SqlParameter("@Number",employee.Number),
                new SqlParameter("@Name", employee.Name),
                new SqlParameter("@BirthDay",employee.BirthDay),
                new SqlParameter("@InDay",employee.InDay),
                new SqlParameter("@MarriageId",employee.MarriageId),
                new SqlParameter("@PartyId",employee.PartyId),
                new SqlParameter("@EducationId",employee.EducationId),
                new SqlParameter("@GenderId",employee.GenderId),
                new SqlParameter("@DepartmentId",employee.DepartmentId),
                new SqlParameter("@TelePhone",employee.TelePhone),
                new SqlParameter("@Address",employee.Address),
                new SqlParameter("@Email",employee.Email),
                new SqlParameter("@Remarks",employee.Remarks),
                new SqlParameter("@Resume",employee.Resume),
                paraPhoto,
            //    new SqlParameter("@Photo",employee.Photo),
                new SqlParameter("@Nation", employee.Nation),
                new SqlParameter("@NativePlace",employee.NativePlace)
            };
            return SqlHelper.ExecuteNonQuery(sql,parameters) > 0;
        }
        public bool EditEmployee(Employee employee)//编辑员工
        {
            
            string sql =
                "update employee set number = @Number, name = @Name, birthday = @BirthDay, inday = @InDay, marriageid = @MarriageId, partyid = @PartyId, educationid = @EducationId, genderid = @GenderId, departmentid = @DepartmentId, telephone = @TelePhone, address = @Address, email = @Email, remarks = @Remarks, resume = @Resume, photo = @Photo,  nation = @Nation, nativeplace = @NativePlace where id = @Id";
           // SqlParameter paraPhoto = new SqlParameter("@Photo", SqlDbType.Image);
            /**if (employee.Photo == null)
            {
                
                paraPhoto.Value = DBNull.Value;
            }
            else
            {
                paraPhoto.Value = employee.Photo;
            }*/
            SqlParameter[] parameters =
            {
                new SqlParameter("@Id",employee.Id),
                new SqlParameter("@Number",employee.Number),
                new SqlParameter("@Name",employee.Name),
                new SqlParameter("@BirthDay",employee.BirthDay),
                new SqlParameter("@InDay",employee.InDay),
                new SqlParameter("@MarriageId",employee.MarriageId),
                new SqlParameter("@PartyId",employee.PartyId),
                new SqlParameter("@EducationId",employee.EducationId),
                new SqlParameter("@GenderId",employee.GenderId),
                new SqlParameter("@DepartmentId",employee.DepartmentId),
                new SqlParameter("@TelePhone",employee.TelePhone),
                new SqlParameter("@Address",employee.Address),
                new SqlParameter("@Email",employee.Email),
                new SqlParameter("@Remarks",employee.Remarks),
                new SqlParameter("@Resume",employee.Resume),
              //  paraPhoto,
                new SqlParameter("@Photo",employee.Photo),
                new SqlParameter("@Nation", employee.Nation),
                new SqlParameter("@NativePlace",employee.NativePlace)
            };
            int count = SqlHelper.ExecuteNonQuery(sql, parameters);
            return  count> 0;
        }
        public bool DeleteEmployee(Guid id)//删除员工
        {
            string sql = "UPDATE  Employee SET IsDeleted = 1 WHERE id = @Id";
            SqlParameter paraId = new SqlParameter("@Id", id);
            return SqlHelper.ExecuteNonQuery(sql, paraId)>0;
        }
        public bool ExportEmployees(List<ExportEmployees>ees, string filename)//导出员工
        {
            IWorkbook workbook;
            string fileext = Path.GetExtension(filename).ToLower();
            if (fileext == ".xlsx")
            {
                workbook = new XSSFWorkbook();
            }
            else if (fileext == ".xls")
            {
                workbook = new HSSFWorkbook();
            }
            else
            {
                workbook = null;
                return false;
            }
            ISheet sheet = workbook.CreateSheet("员工信息");//创建表格
            sheet.SetColumnWidth(2, 15 * 256);

            //日期格式
            ICellStyle dateStyle = workbook.CreateCellStyle(); 
            IDataFormat df = workbook.CreateDataFormat();
            dateStyle.DataFormat = df.GetFormat("yyyy年mm月dd日");

            //表头
            IRow headerRow = sheet.CreateRow(0);
            ICellStyle headerStyle = workbook.CreateCellStyle();
            IFont headerFont = workbook.CreateFont();
            headerFont.Boldweight = (short)FontBoldWeight.BOLD;//加粗
            headerFont.FontName = "宋体";
            headerStyle.SetFont(headerFont);
            headerStyle.Alignment = HorizontalAlignment.CENTER;
            headerRow.CreateCell(0).SetCellValue("工号"); 
            headerRow.CreateCell(1).SetCellValue("姓名");
            headerRow.CreateCell(2).SetCellValue("入职时间");
            headerRow.CreateCell(3).SetCellValue("民族");
            headerRow.CreateCell(4).SetCellValue("籍贯");
            foreach (ICell cell in headerRow.Cells)
            {
                cell.CellStyle = headerStyle;
            }

            //数据
            int i = 1;
            ICell cell02 = null;
            foreach(ExportEmployees ee in ees)
            {
                IRow row = sheet.CreateRow(i);
                row.CreateCell(0).SetCellValue(ee.No);
                row.CreateCell(1).SetCellValue(ee.Name);
                cell02 = row.CreateCell(2);
                cell02.SetCellValue(ee.InDay);
                cell02.CellStyle = dateStyle;
                row.CreateCell(3).SetCellValue(ee.Nation);
                row.CreateCell(4).SetCellValue(ee.NativePlace);
                i++;
            }

            //保存为Excel文件  
            try
            {
                using (FileStream fs = File.OpenWrite(filename))
                {
                    workbook.Write(fs);
                }
                return true;
            }
            catch
            {
                return false;
            }
            
        }

    }  
        
}
