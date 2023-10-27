namespace HRMSystem2023ZHU
{
    partial class FormManageOp
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
            this.groupBoxManage = new System.Windows.Forms.GroupBox();
            this.buttonEmpty = new System.Windows.Forms.Button();
            this.labelOkpwd = new System.Windows.Forms.Label();
            this.textBoxOkpwd = new System.Windows.Forms.TextBox();
            this.labelPwd = new System.Windows.Forms.Label();
            this.textBoxDespwd = new System.Windows.Forms.TextBox();
            this.checkBoxManage = new System.Windows.Forms.CheckBox();
            this.checkBoxLock = new System.Windows.Forms.CheckBox();
            this.checkBoxDel = new System.Windows.Forms.CheckBox();
            this.labelRn = new System.Windows.Forms.Label();
            this.textBoxRn = new System.Windows.Forms.TextBox();
            this.labelUn = new System.Windows.Forms.Label();
            this.textBoxUn = new System.Windows.Forms.TextBox();
            this.buttonInquire = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonLock = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.groupBoxManage.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxManage
            // 
            this.groupBoxManage.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxManage.Controls.Add(this.buttonEmpty);
            this.groupBoxManage.Controls.Add(this.labelOkpwd);
            this.groupBoxManage.Controls.Add(this.textBoxOkpwd);
            this.groupBoxManage.Controls.Add(this.labelPwd);
            this.groupBoxManage.Controls.Add(this.textBoxDespwd);
            this.groupBoxManage.Controls.Add(this.checkBoxManage);
            this.groupBoxManage.Controls.Add(this.checkBoxLock);
            this.groupBoxManage.Controls.Add(this.checkBoxDel);
            this.groupBoxManage.Controls.Add(this.labelRn);
            this.groupBoxManage.Controls.Add(this.textBoxRn);
            this.groupBoxManage.Controls.Add(this.labelUn);
            this.groupBoxManage.Controls.Add(this.textBoxUn);
            this.groupBoxManage.Controls.Add(this.buttonInquire);
            this.groupBoxManage.Controls.Add(this.buttonAdd);
            this.groupBoxManage.Controls.Add(this.buttonLock);
            this.groupBoxManage.Controls.Add(this.buttonDel);
            this.groupBoxManage.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxManage.Location = new System.Drawing.Point(12, 12);
            this.groupBoxManage.Name = "groupBoxManage";
            this.groupBoxManage.Size = new System.Drawing.Size(592, 458);
            this.groupBoxManage.TabIndex = 6;
            this.groupBoxManage.TabStop = false;
            this.groupBoxManage.Text = "管理区";
            // 
            // buttonEmpty
            // 
            this.buttonEmpty.Location = new System.Drawing.Point(375, 352);
            this.buttonEmpty.Name = "buttonEmpty";
            this.buttonEmpty.Size = new System.Drawing.Size(128, 61);
            this.buttonEmpty.TabIndex = 16;
            this.buttonEmpty.Text = "清空";
            this.buttonEmpty.UseVisualStyleBackColor = true;
            this.buttonEmpty.Click += new System.EventHandler(this.buttonEmpty_Click);
            // 
            // labelOkpwd
            // 
            this.labelOkpwd.AutoSize = true;
            this.labelOkpwd.Location = new System.Drawing.Point(24, 245);
            this.labelOkpwd.Name = "labelOkpwd";
            this.labelOkpwd.Size = new System.Drawing.Size(89, 20);
            this.labelOkpwd.TabIndex = 15;
            this.labelOkpwd.Text = "确认密码";
            // 
            // textBoxOkpwd
            // 
            this.textBoxOkpwd.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxOkpwd.Location = new System.Drawing.Point(151, 233);
            this.textBoxOkpwd.Name = "textBoxOkpwd";
            this.textBoxOkpwd.PasswordChar = '*';
            this.textBoxOkpwd.Size = new System.Drawing.Size(175, 32);
            this.textBoxOkpwd.TabIndex = 14;
            // 
            // labelPwd
            // 
            this.labelPwd.AutoSize = true;
            this.labelPwd.Location = new System.Drawing.Point(64, 191);
            this.labelPwd.Name = "labelPwd";
            this.labelPwd.Size = new System.Drawing.Size(49, 20);
            this.labelPwd.TabIndex = 13;
            this.labelPwd.Text = "密码";
            // 
            // textBoxDespwd
            // 
            this.textBoxDespwd.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxDespwd.Location = new System.Drawing.Point(151, 179);
            this.textBoxDespwd.Name = "textBoxDespwd";
            this.textBoxDespwd.PasswordChar = '*';
            this.textBoxDespwd.Size = new System.Drawing.Size(175, 32);
            this.textBoxDespwd.TabIndex = 12;
            this.textBoxDespwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDespwd_KeyPress);
            // 
            // checkBoxManage
            // 
            this.checkBoxManage.AutoSize = true;
            this.checkBoxManage.Location = new System.Drawing.Point(28, 391);
            this.checkBoxManage.Name = "checkBoxManage";
            this.checkBoxManage.Size = new System.Drawing.Size(111, 24);
            this.checkBoxManage.TabIndex = 11;
            this.checkBoxManage.Text = "管理标记";
            this.checkBoxManage.UseVisualStyleBackColor = true;
            // 
            // checkBoxLock
            // 
            this.checkBoxLock.AutoSize = true;
            this.checkBoxLock.Location = new System.Drawing.Point(28, 345);
            this.checkBoxLock.Name = "checkBoxLock";
            this.checkBoxLock.Size = new System.Drawing.Size(111, 24);
            this.checkBoxLock.TabIndex = 9;
            this.checkBoxLock.Text = "锁定标记";
            this.checkBoxLock.UseVisualStyleBackColor = true;
            // 
            // checkBoxDel
            // 
            this.checkBoxDel.AutoSize = true;
            this.checkBoxDel.Location = new System.Drawing.Point(28, 299);
            this.checkBoxDel.Name = "checkBoxDel";
            this.checkBoxDel.Size = new System.Drawing.Size(111, 24);
            this.checkBoxDel.TabIndex = 8;
            this.checkBoxDel.Text = "删除标记";
            this.checkBoxDel.UseVisualStyleBackColor = true;
            // 
            // labelRn
            // 
            this.labelRn.AutoSize = true;
            this.labelRn.Location = new System.Drawing.Point(24, 137);
            this.labelRn.Name = "labelRn";
            this.labelRn.Size = new System.Drawing.Size(89, 20);
            this.labelRn.TabIndex = 7;
            this.labelRn.Text = "真实姓名";
            // 
            // textBoxRn
            // 
            this.textBoxRn.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxRn.Location = new System.Drawing.Point(151, 125);
            this.textBoxRn.Name = "textBoxRn";
            this.textBoxRn.Size = new System.Drawing.Size(175, 32);
            this.textBoxRn.TabIndex = 6;
            this.textBoxRn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRn_KeyPress);
            // 
            // labelUn
            // 
            this.labelUn.AutoSize = true;
            this.labelUn.Location = new System.Drawing.Point(24, 83);
            this.labelUn.Name = "labelUn";
            this.labelUn.Size = new System.Drawing.Size(89, 20);
            this.labelUn.TabIndex = 5;
            this.labelUn.Text = "用户姓名";
            // 
            // textBoxUn
            // 
            this.textBoxUn.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxUn.Location = new System.Drawing.Point(151, 71);
            this.textBoxUn.Name = "textBoxUn";
            this.textBoxUn.Size = new System.Drawing.Size(175, 32);
            this.textBoxUn.TabIndex = 1;
            this.textBoxUn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUn_KeyPress);
            // 
            // buttonInquire
            // 
            this.buttonInquire.Location = new System.Drawing.Point(375, 127);
            this.buttonInquire.Name = "buttonInquire";
            this.buttonInquire.Size = new System.Drawing.Size(128, 61);
            this.buttonInquire.TabIndex = 4;
            this.buttonInquire.Text = "查询";
            this.buttonInquire.UseVisualStyleBackColor = true;
            this.buttonInquire.Click += new System.EventHandler(this.buttonInquire_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(375, 52);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(128, 61);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "添加";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonLock
            // 
            this.buttonLock.Location = new System.Drawing.Point(375, 202);
            this.buttonLock.Name = "buttonLock";
            this.buttonLock.Size = new System.Drawing.Size(128, 61);
            this.buttonLock.TabIndex = 3;
            this.buttonLock.Text = "锁定";
            this.buttonLock.UseVisualStyleBackColor = true;
            this.buttonLock.Click += new System.EventHandler(this.buttonLock_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(375, 277);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(128, 61);
            this.buttonDel.TabIndex = 2;
            this.buttonDel.Text = "删除";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // FormManageOp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 505);
            this.Controls.Add(this.groupBoxManage);
            this.Name = "FormManageOp";
            this.Text = "操作员管理";
            this.groupBoxManage.ResumeLayout(false);
            this.groupBoxManage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxManage;
        private System.Windows.Forms.Button buttonEmpty;
        private System.Windows.Forms.Label labelOkpwd;
        private System.Windows.Forms.TextBox textBoxOkpwd;
        private System.Windows.Forms.Label labelPwd;
        private System.Windows.Forms.TextBox textBoxDespwd;
        private System.Windows.Forms.CheckBox checkBoxManage;
        private System.Windows.Forms.CheckBox checkBoxLock;
        private System.Windows.Forms.CheckBox checkBoxDel;
        private System.Windows.Forms.Label labelRn;
        private System.Windows.Forms.TextBox textBoxRn;
        private System.Windows.Forms.Label labelUn;
        private System.Windows.Forms.TextBox textBoxUn;
        private System.Windows.Forms.Button buttonInquire;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonLock;
        private System.Windows.Forms.Button buttonDel;
    }
}