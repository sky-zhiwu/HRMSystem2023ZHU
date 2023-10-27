using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMSystem2023ZHU
{
    public class CommonHelper
    {
        public static string GetMD5(string str)//加密
        {
            MD5 md5 = MD5.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(str);
            byte[] md5Bytes = md5.ComputeHash(bytes);
            StringBuilder sb = new StringBuilder();
            foreach (byte b in md5Bytes)
            {
                sb.Append(b.ToString("x2"));
            }
            return sb.ToString();
        }
        

        /// <summary>
        /// 二进制转为图片
        /// </summary>
        /// <param name="streamByte"></param>
        /// <returns></returns>
        public static System.Drawing.Image ReturnPhoto(byte[] streamByte)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream(streamByte);
            System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
            return img;
        }
        //图片转二进制
        public static byte[] ReturnByte(Image imgPhoto)
        {
            //将Image转换成流数据，并保存为byte[] 
            MemoryStream mstream = new MemoryStream();
            imgPhoto.Save(mstream, System.Drawing.Imaging.ImageFormat.Bmp);
            byte[] byData = new Byte[mstream.Length];
            mstream.Position = 0;
            mstream.Read(byData, 0, byData.Length);
            mstream.Close();
            return byData;
        }

        public static void SuccessMessageBox(string msg)
        {
            MessageBox.Show(msg, "操作成功提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ErrorMessageBox(string msg)
        {
            MessageBox.Show(msg, "操作失败提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void WarnMessageBox(string msg)
        {
            MessageBox.Show(msg, "操作注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static DialogResult YesOrNoMessageBox(string msg)
        {
            return MessageBox.Show(msg, "操作确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        
        
    }
}
