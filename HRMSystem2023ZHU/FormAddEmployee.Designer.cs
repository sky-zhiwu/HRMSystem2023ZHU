namespace HRMSystem2023ZHU
{
    partial class FormAddEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddEmployee));
            this.tcBaseInformation = new System.Windows.Forms.TabControl();
            this.tabPageInfo = new System.Windows.Forms.TabPage();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.comboBoxEduBack = new System.Windows.Forms.ComboBox();
            this.comboBoxPolitical = new System.Windows.Forms.ComboBox();
            this.comboBoxDept = new System.Windows.Forms.ComboBox();
            this.textBoxNation = new System.Windows.Forms.TextBox();
            this.comboBoxMarry = new System.Windows.Forms.ComboBox();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.textBoxNativePlace = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.buttonChoosePhoto = new System.Windows.Forms.Button();
            this.richTextBoxRemark = new System.Windows.Forms.RichTextBox();
            this.dtpIndate = new System.Windows.Forms.DateTimePicker();
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelDept = new System.Windows.Forms.Label();
            this.labelPs = new System.Windows.Forms.Label();
            this.labelAdress = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelHome = new System.Windows.Forms.Label();
            this.labelNationality = new System.Windows.Forms.Label();
            this.labelEduBack = new System.Windows.Forms.Label();
            this.labelIndate = new System.Windows.Forms.Label();
            this.labelMarry = new System.Windows.Forms.Label();
            this.labelPolitical = new System.Windows.Forms.Label();
            this.labelPhoto = new System.Windows.Forms.Label();
            this.labelBirth = new System.Windows.Forms.Label();
            this.labelSex = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.tabPageResume = new System.Windows.Forms.TabPage();
            this.richTextBoxResume = new System.Windows.Forms.RichTextBox();
            this.buttonPreserve = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tcBaseInformation.SuspendLayout();
            this.tabPageInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.tabPageResume.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcBaseInformation
            // 
            this.tcBaseInformation.AccessibleName = "";
            this.tcBaseInformation.Controls.Add(this.tabPageInfo);
            this.tcBaseInformation.Controls.Add(this.tabPageResume);
            this.tcBaseInformation.Cursor = System.Windows.Forms.Cursors.Default;
            this.tcBaseInformation.Location = new System.Drawing.Point(12, 12);
            this.tcBaseInformation.Name = "tcBaseInformation";
            this.tcBaseInformation.SelectedIndex = 0;
            this.tcBaseInformation.Size = new System.Drawing.Size(1038, 514);
            this.tcBaseInformation.TabIndex = 0;
            // 
            // tabPageInfo
            // 
            this.tabPageInfo.Controls.Add(this.textBoxPhone);
            this.tabPageInfo.Controls.Add(this.comboBoxEduBack);
            this.tabPageInfo.Controls.Add(this.comboBoxPolitical);
            this.tabPageInfo.Controls.Add(this.comboBoxDept);
            this.tabPageInfo.Controls.Add(this.textBoxNation);
            this.tabPageInfo.Controls.Add(this.comboBoxMarry);
            this.tabPageInfo.Controls.Add(this.comboBoxSex);
            this.tabPageInfo.Controls.Add(this.dtpBirth);
            this.tabPageInfo.Controls.Add(this.textBoxAdress);
            this.tabPageInfo.Controls.Add(this.textBoxEmail);
            this.tabPageInfo.Controls.Add(this.textBoxNumber);
            this.tabPageInfo.Controls.Add(this.textBoxNativePlace);
            this.tabPageInfo.Controls.Add(this.textBoxName);
            this.tabPageInfo.Controls.Add(this.pictureBoxPhoto);
            this.tabPageInfo.Controls.Add(this.buttonChoosePhoto);
            this.tabPageInfo.Controls.Add(this.richTextBoxRemark);
            this.tabPageInfo.Controls.Add(this.dtpIndate);
            this.tabPageInfo.Controls.Add(this.labelNumber);
            this.tabPageInfo.Controls.Add(this.labelDept);
            this.tabPageInfo.Controls.Add(this.labelPs);
            this.tabPageInfo.Controls.Add(this.labelAdress);
            this.tabPageInfo.Controls.Add(this.labelEmail);
            this.tabPageInfo.Controls.Add(this.labelPhone);
            this.tabPageInfo.Controls.Add(this.labelHome);
            this.tabPageInfo.Controls.Add(this.labelNationality);
            this.tabPageInfo.Controls.Add(this.labelEduBack);
            this.tabPageInfo.Controls.Add(this.labelIndate);
            this.tabPageInfo.Controls.Add(this.labelMarry);
            this.tabPageInfo.Controls.Add(this.labelPolitical);
            this.tabPageInfo.Controls.Add(this.labelPhoto);
            this.tabPageInfo.Controls.Add(this.labelBirth);
            this.tabPageInfo.Controls.Add(this.labelSex);
            this.tabPageInfo.Controls.Add(this.labelName);
            this.tabPageInfo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabPageInfo.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPageInfo.Location = new System.Drawing.Point(4, 25);
            this.tabPageInfo.Name = "tabPageInfo";
            this.tabPageInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInfo.Size = new System.Drawing.Size(1030, 485);
            this.tabPageInfo.TabIndex = 0;
            this.tabPageInfo.Text = "基本信息";
            this.tabPageInfo.UseVisualStyleBackColor = true;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(529, 190);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(214, 25);
            this.textBoxPhone.TabIndex = 33;
            // 
            // comboBoxEduBack
            // 
            this.comboBoxEduBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxEduBack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEduBack.FormattingEnabled = true;
            this.comboBoxEduBack.Location = new System.Drawing.Point(611, 104);
            this.comboBoxEduBack.Name = "comboBoxEduBack";
            this.comboBoxEduBack.Size = new System.Drawing.Size(132, 23);
            this.comboBoxEduBack.TabIndex = 32;
            // 
            // comboBoxPolitical
            // 
            this.comboBoxPolitical.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxPolitical.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPolitical.FormattingEnabled = true;
            this.comboBoxPolitical.Location = new System.Drawing.Point(611, 57);
            this.comboBoxPolitical.Name = "comboBoxPolitical";
            this.comboBoxPolitical.Size = new System.Drawing.Size(132, 23);
            this.comboBoxPolitical.TabIndex = 31;
            // 
            // comboBoxDept
            // 
            this.comboBoxDept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDept.FormattingEnabled = true;
            this.comboBoxDept.Location = new System.Drawing.Point(529, 241);
            this.comboBoxDept.Name = "comboBoxDept";
            this.comboBoxDept.Size = new System.Drawing.Size(116, 23);
            this.comboBoxDept.TabIndex = 30;
            // 
            // textBoxNation
            // 
            this.textBoxNation.Location = new System.Drawing.Point(370, 102);
            this.textBoxNation.Name = "textBoxNation";
            this.textBoxNation.Size = new System.Drawing.Size(113, 25);
            this.textBoxNation.TabIndex = 29;
            // 
            // comboBoxMarry
            // 
            this.comboBoxMarry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMarry.FormattingEnabled = true;
            this.comboBoxMarry.Location = new System.Drawing.Point(370, 59);
            this.comboBoxMarry.Name = "comboBoxMarry";
            this.comboBoxMarry.Size = new System.Drawing.Size(113, 23);
            this.comboBoxMarry.TabIndex = 28;
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Location = new System.Drawing.Point(370, 17);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(67, 23);
            this.comboBoxSex.TabIndex = 27;
            // 
            // dtpBirth
            // 
            this.dtpBirth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpBirth.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpBirth.Location = new System.Drawing.Point(611, 15);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(132, 25);
            this.dtpBirth.TabIndex = 26;
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(112, 146);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(631, 25);
            this.textBoxAdress.TabIndex = 25;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(112, 190);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(270, 25);
            this.textBoxEmail.TabIndex = 24;
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(112, 234);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(214, 25);
            this.textBoxNumber.TabIndex = 23;
            // 
            // textBoxNativePlace
            // 
            this.textBoxNativePlace.Location = new System.Drawing.Point(112, 102);
            this.textBoxNativePlace.Name = "textBoxNativePlace";
            this.textBoxNativePlace.Size = new System.Drawing.Size(154, 25);
            this.textBoxNativePlace.TabIndex = 22;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(112, 15);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(154, 25);
            this.textBoxName.TabIndex = 21;
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(815, 48);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(175, 234);
            this.pictureBoxPhoto.TabIndex = 20;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // buttonChoosePhoto
            // 
            this.buttonChoosePhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChoosePhoto.Location = new System.Drawing.Point(854, 288);
            this.buttonChoosePhoto.Name = "buttonChoosePhoto";
            this.buttonChoosePhoto.Size = new System.Drawing.Size(96, 39);
            this.buttonChoosePhoto.TabIndex = 19;
            this.buttonChoosePhoto.Text = "选择照片";
            this.buttonChoosePhoto.UseVisualStyleBackColor = true;
            this.buttonChoosePhoto.Click += new System.EventHandler(this.buttonChoosePhoto_Click);
            // 
            // richTextBoxRemark
            // 
            this.richTextBoxRemark.Location = new System.Drawing.Point(112, 288);
            this.richTextBoxRemark.Name = "richTextBoxRemark";
            this.richTextBoxRemark.Size = new System.Drawing.Size(631, 175);
            this.richTextBoxRemark.TabIndex = 18;
            this.richTextBoxRemark.Text = "";
            // 
            // dtpIndate
            // 
            this.dtpIndate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpIndate.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpIndate.Location = new System.Drawing.Point(112, 57);
            this.dtpIndate.Name = "dtpIndate";
            this.dtpIndate.Size = new System.Drawing.Size(132, 25);
            this.dtpIndate.TabIndex = 17;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelNumber.Location = new System.Drawing.Point(54, 244);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(52, 15);
            this.labelNumber.TabIndex = 16;
            this.labelNumber.Text = "工号：";
            // 
            // labelDept
            // 
            this.labelDept.AutoSize = true;
            this.labelDept.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelDept.Location = new System.Drawing.Point(448, 244);
            this.labelDept.Name = "labelDept";
            this.labelDept.Size = new System.Drawing.Size(52, 15);
            this.labelDept.TabIndex = 15;
            this.labelDept.Text = "部门：";
            // 
            // labelPs
            // 
            this.labelPs.AutoSize = true;
            this.labelPs.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPs.Location = new System.Drawing.Point(54, 288);
            this.labelPs.Name = "labelPs";
            this.labelPs.Size = new System.Drawing.Size(52, 15);
            this.labelPs.TabIndex = 14;
            this.labelPs.Text = "备注：";
            // 
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelAdress.Location = new System.Drawing.Point(24, 156);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(82, 15);
            this.labelAdress.TabIndex = 13;
            this.labelAdress.Text = "联系地址：";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelEmail.Location = new System.Drawing.Point(24, 200);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(82, 15);
            this.labelEmail.TabIndex = 12;
            this.labelEmail.Text = "电子邮件：";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPhone.Location = new System.Drawing.Point(427, 200);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(82, 15);
            this.labelPhone.TabIndex = 11;
            this.labelPhone.Text = "联系电话：";
            // 
            // labelHome
            // 
            this.labelHome.AutoSize = true;
            this.labelHome.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelHome.Location = new System.Drawing.Point(54, 112);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(52, 15);
            this.labelHome.TabIndex = 10;
            this.labelHome.Text = "籍贯：";
            // 
            // labelNationality
            // 
            this.labelNationality.AutoSize = true;
            this.labelNationality.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelNationality.Location = new System.Drawing.Point(312, 112);
            this.labelNationality.Name = "labelNationality";
            this.labelNationality.Size = new System.Drawing.Size(52, 15);
            this.labelNationality.TabIndex = 9;
            this.labelNationality.Text = "民族：";
            // 
            // labelEduBack
            // 
            this.labelEduBack.AutoSize = true;
            this.labelEduBack.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelEduBack.Location = new System.Drawing.Point(533, 112);
            this.labelEduBack.Name = "labelEduBack";
            this.labelEduBack.Size = new System.Drawing.Size(52, 15);
            this.labelEduBack.TabIndex = 8;
            this.labelEduBack.Text = "学历：";
            // 
            // labelIndate
            // 
            this.labelIndate.AutoSize = true;
            this.labelIndate.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelIndate.Location = new System.Drawing.Point(24, 67);
            this.labelIndate.Name = "labelIndate";
            this.labelIndate.Size = new System.Drawing.Size(82, 15);
            this.labelIndate.TabIndex = 7;
            this.labelIndate.Text = "入职日期：";
            // 
            // labelMarry
            // 
            this.labelMarry.AutoSize = true;
            this.labelMarry.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelMarry.Location = new System.Drawing.Point(282, 67);
            this.labelMarry.Name = "labelMarry";
            this.labelMarry.Size = new System.Drawing.Size(82, 15);
            this.labelMarry.TabIndex = 6;
            this.labelMarry.Text = "婚姻状况：";
            // 
            // labelPolitical
            // 
            this.labelPolitical.AutoSize = true;
            this.labelPolitical.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPolitical.Location = new System.Drawing.Point(503, 67);
            this.labelPolitical.Name = "labelPolitical";
            this.labelPolitical.Size = new System.Drawing.Size(82, 15);
            this.labelPolitical.TabIndex = 5;
            this.labelPolitical.Text = "政治面貌：";
            // 
            // labelPhoto
            // 
            this.labelPhoto.AutoSize = true;
            this.labelPhoto.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPhoto.Location = new System.Drawing.Point(812, 25);
            this.labelPhoto.Name = "labelPhoto";
            this.labelPhoto.Size = new System.Drawing.Size(52, 15);
            this.labelPhoto.TabIndex = 4;
            this.labelPhoto.Text = "照片：";
            // 
            // labelBirth
            // 
            this.labelBirth.AutoSize = true;
            this.labelBirth.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBirth.Location = new System.Drawing.Point(503, 25);
            this.labelBirth.Name = "labelBirth";
            this.labelBirth.Size = new System.Drawing.Size(82, 15);
            this.labelBirth.TabIndex = 2;
            this.labelBirth.Text = "出生年月：";
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSex.Location = new System.Drawing.Point(312, 25);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(52, 15);
            this.labelSex.TabIndex = 1;
            this.labelSex.Text = "性别：";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelName.Location = new System.Drawing.Point(54, 25);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(52, 15);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "姓名：";
            // 
            // tabPageResume
            // 
            this.tabPageResume.Controls.Add(this.richTextBoxResume);
            this.tabPageResume.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPageResume.Location = new System.Drawing.Point(4, 25);
            this.tabPageResume.Name = "tabPageResume";
            this.tabPageResume.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageResume.Size = new System.Drawing.Size(1030, 485);
            this.tabPageResume.TabIndex = 1;
            this.tabPageResume.Text = "简历";
            this.tabPageResume.UseVisualStyleBackColor = true;
            // 
            // richTextBoxResume
            // 
            this.richTextBoxResume.Location = new System.Drawing.Point(6, 6);
            this.richTextBoxResume.Name = "richTextBoxResume";
            this.richTextBoxResume.Size = new System.Drawing.Size(1021, 476);
            this.richTextBoxResume.TabIndex = 0;
            this.richTextBoxResume.Text = "";
            // 
            // buttonPreserve
            // 
            this.buttonPreserve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPreserve.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonPreserve.Location = new System.Drawing.Point(773, 532);
            this.buttonPreserve.Name = "buttonPreserve";
            this.buttonPreserve.Size = new System.Drawing.Size(107, 37);
            this.buttonPreserve.TabIndex = 1;
            this.buttonPreserve.Text = "保存";
            this.buttonPreserve.UseVisualStyleBackColor = true;
            this.buttonPreserve.Click += new System.EventHandler(this.buttonPreserve_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCancel.Location = new System.Drawing.Point(912, 532);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(109, 37);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 603);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonPreserve);
            this.Controls.Add(this.tcBaseInformation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddEmployee";
            this.Text = "添加员工";
            this.Load += new System.EventHandler(this.FormAddEmployee_Load);
            this.tcBaseInformation.ResumeLayout(false);
            this.tabPageInfo.ResumeLayout(false);
            this.tabPageInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.tabPageResume.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcBaseInformation;
        private System.Windows.Forms.TabPage tabPageInfo;
        private System.Windows.Forms.DateTimePicker dtpIndate;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelDept;
        private System.Windows.Forms.Label labelPs;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelHome;
        private System.Windows.Forms.Label labelNationality;
        private System.Windows.Forms.Label labelEduBack;
        private System.Windows.Forms.Label labelIndate;
        private System.Windows.Forms.Label labelMarry;
        private System.Windows.Forms.Label labelPolitical;
        private System.Windows.Forms.Label labelPhoto;
        private System.Windows.Forms.Label labelBirth;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TabPage tabPageResume;
        private System.Windows.Forms.Button buttonPreserve;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.ComboBox comboBoxEduBack;
        private System.Windows.Forms.ComboBox comboBoxPolitical;
        private System.Windows.Forms.ComboBox comboBoxDept;
        private System.Windows.Forms.TextBox textBoxNation;
        private System.Windows.Forms.ComboBox comboBoxMarry;
        private System.Windows.Forms.ComboBox comboBoxSex;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxNativePlace;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.Button buttonChoosePhoto;
        private System.Windows.Forms.RichTextBox richTextBoxRemark;
        private System.Windows.Forms.RichTextBox richTextBoxResume;
    }
}