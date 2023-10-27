namespace HRMSystem2023ZHU
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmiAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOpManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLogQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmlOther = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChangePwd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEmployeeList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeptManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeptList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSalaryManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSalary = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPrintSalList = new System.Windows.Forms.ToolStripMenuItem();
            this.stasBottom = new System.Windows.Forms.StatusStrip();
            this.tsslInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.msMain.SuspendLayout();
            this.stasBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.msMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAdmin,
            this.tsmiOpManage,
            this.tsmiDeptManage,
            this.tsmiSalaryManage,
            this.tsmlOther});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.msMain.Size = new System.Drawing.Size(936, 31);
            this.msMain.TabIndex = 8;
            this.msMain.Text = "menuStrip1";
            // 
            // tsmiAdmin
            // 
            this.tsmiAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmOpManage,
            this.tsmiLogQuery});
            this.tsmiAdmin.Name = "tsmiAdmin";
            this.tsmiAdmin.Size = new System.Drawing.Size(75, 27);
            this.tsmiAdmin.Text = "管理员";
            // 
            // tsmOpManage
            // 
            this.tsmOpManage.Name = "tsmOpManage";
            this.tsmOpManage.Size = new System.Drawing.Size(179, 28);
            this.tsmOpManage.Text = "操作员管理";
            this.tsmOpManage.Click += new System.EventHandler(this.tsmOpManage_Click);
            // 
            // tsmiLogQuery
            // 
            this.tsmiLogQuery.Name = "tsmiLogQuery";
            this.tsmiLogQuery.Size = new System.Drawing.Size(179, 28);
            this.tsmiLogQuery.Text = "日志管理";
            this.tsmiLogQuery.Click += new System.EventHandler(this.tsmiLogQuery_Click);
            // 
            // tsmlOther
            // 
            this.tsmlOther.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiChangePwd});
            this.tsmlOther.Name = "tsmlOther";
            this.tsmlOther.Size = new System.Drawing.Size(58, 27);
            this.tsmlOther.Text = "其他";
            // 
            // tsmiChangePwd
            // 
            this.tsmiChangePwd.Name = "tsmiChangePwd";
            this.tsmiChangePwd.Size = new System.Drawing.Size(224, 28);
            this.tsmiChangePwd.Text = "修改密码";
            this.tsmiChangePwd.Click += new System.EventHandler(this.tsmiChangePwd_Click);
            // 
            // tsmiOpManage
            // 
            this.tsmiOpManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEmployeeList});
            this.tsmiOpManage.Name = "tsmiOpManage";
            this.tsmiOpManage.Size = new System.Drawing.Size(92, 27);
            this.tsmiOpManage.Text = "员工管理";
            // 
            // tsmiEmployeeList
            // 
            this.tsmiEmployeeList.Name = "tsmiEmployeeList";
            this.tsmiEmployeeList.Size = new System.Drawing.Size(224, 28);
            this.tsmiEmployeeList.Text = "员工列表";
            this.tsmiEmployeeList.Click += new System.EventHandler(this.tsmiOpList_Click);
            // 
            // tsmiDeptManage
            // 
            this.tsmiDeptManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDeptList});
            this.tsmiDeptManage.Name = "tsmiDeptManage";
            this.tsmiDeptManage.Size = new System.Drawing.Size(92, 27);
            this.tsmiDeptManage.Text = "部门管理";
            // 
            // tsmiDeptList
            // 
            this.tsmiDeptList.Name = "tsmiDeptList";
            this.tsmiDeptList.Size = new System.Drawing.Size(162, 28);
            this.tsmiDeptList.Text = "部门列表";
            this.tsmiDeptList.Click += new System.EventHandler(this.tsmiDeptList_Click);
            // 
            // tsmiSalaryManage
            // 
            this.tsmiSalaryManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSalary,
            this.tsmiPrintSalList});
            this.tsmiSalaryManage.Name = "tsmiSalaryManage";
            this.tsmiSalaryManage.Size = new System.Drawing.Size(92, 27);
            this.tsmiSalaryManage.Text = "薪资管理";
            // 
            // tsmiSalary
            // 
            this.tsmiSalary.Name = "tsmiSalary";
            this.tsmiSalary.Size = new System.Drawing.Size(224, 28);
            this.tsmiSalary.Text = "生成工资单";
            this.tsmiSalary.Click += new System.EventHandler(this.tsmiSalary_Click);
            // 
            // tsmiPrintSalList
            // 
            this.tsmiPrintSalList.Name = "tsmiPrintSalList";
            this.tsmiPrintSalList.Size = new System.Drawing.Size(224, 28);
            this.tsmiPrintSalList.Text = "打印工资单";
            this.tsmiPrintSalList.Click += new System.EventHandler(this.tsmiPrintSalList_Click);
            // 
            // stasBottom
            // 
            this.stasBottom.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stasBottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslInfo});
            this.stasBottom.Location = new System.Drawing.Point(0, 538);
            this.stasBottom.Name = "stasBottom";
            this.stasBottom.Padding = new System.Windows.Forms.Padding(1, 0, 21, 0);
            this.stasBottom.Size = new System.Drawing.Size(936, 22);
            this.stasBottom.TabIndex = 10;
            this.stasBottom.Text = "statusStrip1";
            // 
            // tsslInfo
            // 
            this.tsslInfo.Name = "tsslInfo";
            this.tsslInfo.Size = new System.Drawing.Size(0, 16);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 560);
            this.Controls.Add(this.stasBottom);
            this.Controls.Add(this.msMain);
            this.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.Text = "人力资源管理系统";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.stasBottom.ResumeLayout(false);
            this.stasBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdmin;
        private System.Windows.Forms.ToolStripMenuItem tsmOpManage;
        private System.Windows.Forms.ToolStripMenuItem tsmlOther;
        private System.Windows.Forms.ToolStripMenuItem tsmiLogQuery;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangePwd;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiEmployeeList;
        private System.Windows.Forms.StatusStrip stasBottom;
        private System.Windows.Forms.ToolStripStatusLabel tsslInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeptManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeptList;
        private System.Windows.Forms.ToolStripMenuItem tsmiSalaryManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiSalary;
        private System.Windows.Forms.ToolStripMenuItem tsmiPrintSalList;
    }
}