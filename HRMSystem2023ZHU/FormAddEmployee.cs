using HRMSystem.DAL;
using HRMSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMSystem2023ZHU
{
    public partial class FormAddEmployee : Form
    {
        public FormAddEmployee()
        {
            InitializeComponent();
        }
        private DictionaryService ds = new DictionaryService();
        private DepartmentService dServ = new DepartmentService();
        private EmployeeService empServ = new EmployeeService();
        private void FormAddEmployee_Load(object sender, EventArgs e)
        {
            //显示字典中信息ComboBox
            comboBoxSex.DataSource = ds.GetSex();
            comboBoxPolitical.DataSource = ds.GetParty();
            comboBoxMarry.DataSource = ds.GetMarrige();
            comboBoxEduBack.DataSource = ds.GetEduBack();
            comboBoxDept.DataSource = dServ.GetDepartments();
            comboBoxDept.DisplayMember = "Name";
            comboBoxDept.ValueMember = "Id";
            comboBoxDept.SelectedIndex = -1;
            comboBoxSex.DisplayMember = comboBoxEduBack.DisplayMember = comboBoxMarry.DisplayMember = comboBoxPolitical.DisplayMember = "Name";
            comboBoxSex.ValueMember  = comboBoxEduBack.ValueMember = comboBoxMarry.ValueMember = comboBoxPolitical.ValueMember = "Id";
            comboBoxSex.SelectedIndex = comboBoxEduBack.SelectedIndex = comboBoxMarry.SelectedIndex = comboBoxPolitical.SelectedIndex = -1;
        }
        private string pathname = string.Empty;
        private void buttonChoosePhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = ".";
            file.Filter = "JPG图片|*.jpg|GIF图片|*.gif|位图|*.bmp|PNG图片|*.png"; //"所有文件(*.*)|*.*"
            file.ShowDialog();
            if (file.FileName != string.Empty)
            {
                try
                {
                    pathname = file.FileName;   //获得文件的绝对路径
                    this.pictureBoxPhoto.Load(pathname);
                    pictureBoxPhoto.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureBoxPhoto.SizeMode = PictureBoxSizeMode.StretchImage; 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }  
        }

        private void buttonPreserve_Click(object sender, EventArgs e)
        {
            Employee em = new Employee();
            em.Id = Guid.NewGuid();
            em.Number = textBoxNumber.Text.Trim();
            if (string.IsNullOrEmpty(em.Number))
            {
                CommonHelper.ErrorMessageBox("请输入员工工号！");
                return;
            }
            em.Name = textBoxName.Text.Trim();
            if (string.IsNullOrEmpty(em.Name))
            {
                CommonHelper.ErrorMessageBox("请输入员工姓名！");
                return;
            }
            em.BirthDay = dtpBirth.Value;
            em.InDay = dtpIndate.Value;
            em.MarriageId = (Guid)comboBoxMarry.SelectedValue;
            em.PartyId = (Guid)comboBoxPolitical.SelectedValue;
            em.EducationId = (Guid)comboBoxEduBack.SelectedValue;
            em.GenderId = (Guid)comboBoxSex.SelectedValue;
            em.DepartmentId = (Guid)comboBoxDept.SelectedValue;
            em.TelePhone = textBoxPhone.Text.Trim();
            if (string.IsNullOrEmpty(em.TelePhone))
            {
                CommonHelper.ErrorMessageBox("请输入员工联系方式！");
                return;
            }
            em.Address = textBoxAdress.Text.Trim();
            if (string.IsNullOrEmpty(em.Address))
            {
                CommonHelper.ErrorMessageBox("请输入员工联系地址！");
                return;
            }
            em.Email = textBoxEmail.Text.Trim();
            if (string.IsNullOrEmpty(em.Email))
            {
                CommonHelper.ErrorMessageBox("请输入员工电子邮箱！");
                return;
            }
            em.Remarks = richTextBoxRemark.Text.Trim();
            em.Resume = richTextBoxResume.Text.Trim();
            if(pictureBoxPhoto.Image != null)
            {
                em.Photo = CommonHelper.ReturnByte(pictureBoxPhoto.Image);
            }
            em.Nation = textBoxNation.Text.Trim();
            if (string.IsNullOrEmpty(em.Nation))
            {
                CommonHelper.ErrorMessageBox("请输入员工民族！");
                return;
            }
            em.NativePlace = textBoxNativePlace.Text.Trim();
            if (string.IsNullOrEmpty(em.NativePlace))
            {
                CommonHelper.ErrorMessageBox("请输入员工户籍！");
                return;
            }
            if (empServ.AddEmployee(em))
            {
                CommonHelper.SuccessMessageBox("添加成功！");
                this.DialogResult = DialogResult.OK;
                
            }
            else
            {
                CommonHelper.SuccessMessageBox("添加失败！");
                this.DialogResult = DialogResult.Cancel;

            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
