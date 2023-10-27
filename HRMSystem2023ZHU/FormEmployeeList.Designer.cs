namespace HRMSystem2023ZHU
{
    partial class FormEmployeeList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployeeList));
            this.groupBoxList = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dtpInDateTo = new System.Windows.Forms.DateTimePicker();
            this.dtpInDateFrom = new System.Windows.Forms.DateTimePicker();
            this.labelDao = new System.Windows.Forms.Label();
            this.comboBoxDept = new System.Windows.Forms.ComboBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.checkBoxTimeIn = new System.Windows.Forms.CheckBox();
            this.checkBoxDept = new System.Windows.Forms.CheckBox();
            this.checkBoxName = new System.Windows.Forms.CheckBox();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbExport = new System.Windows.Forms.ToolStripButton();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.groupBoxList.SuspendLayout();
            this.toolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxList
            // 
            this.groupBoxList.Controls.Add(this.buttonSearch);
            this.groupBoxList.Controls.Add(this.dtpInDateTo);
            this.groupBoxList.Controls.Add(this.dtpInDateFrom);
            this.groupBoxList.Controls.Add(this.labelDao);
            this.groupBoxList.Controls.Add(this.comboBoxDept);
            this.groupBoxList.Controls.Add(this.textBoxName);
            this.groupBoxList.Controls.Add(this.checkBoxTimeIn);
            this.groupBoxList.Controls.Add(this.checkBoxDept);
            this.groupBoxList.Controls.Add(this.checkBoxName);
            this.groupBoxList.Location = new System.Drawing.Point(12, 48);
            this.groupBoxList.Name = "groupBoxList";
            this.groupBoxList.Size = new System.Drawing.Size(985, 163);
            this.groupBoxList.TabIndex = 0;
            this.groupBoxList.TabStop = false;
            this.groupBoxList.Text = "搜索条件";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSearch.Location = new System.Drawing.Point(343, 88);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(158, 53);
            this.buttonSearch.TabIndex = 8;
            this.buttonSearch.Text = "搜索";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // dtpInDateTo
            // 
            this.dtpInDateTo.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpInDateTo.Location = new System.Drawing.Point(710, 43);
            this.dtpInDateTo.Name = "dtpInDateTo";
            this.dtpInDateTo.Size = new System.Drawing.Size(200, 28);
            this.dtpInDateTo.TabIndex = 7;
            // 
            // dtpInDateFrom
            // 
            this.dtpInDateFrom.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpInDateFrom.Location = new System.Drawing.Point(470, 43);
            this.dtpInDateFrom.Name = "dtpInDateFrom";
            this.dtpInDateFrom.Size = new System.Drawing.Size(200, 28);
            this.dtpInDateFrom.TabIndex = 6;
            // 
            // labelDao
            // 
            this.labelDao.AutoSize = true;
            this.labelDao.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelDao.Location = new System.Drawing.Point(676, 52);
            this.labelDao.Name = "labelDao";
            this.labelDao.Size = new System.Drawing.Size(28, 19);
            this.labelDao.TabIndex = 5;
            this.labelDao.Text = "到";
            // 
            // comboBoxDept
            // 
            this.comboBoxDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDept.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxDept.FormattingEnabled = true;
            this.comboBoxDept.Location = new System.Drawing.Point(125, 88);
            this.comboBoxDept.Name = "comboBoxDept";
            this.comboBoxDept.Size = new System.Drawing.Size(144, 26);
            this.comboBoxDept.TabIndex = 4;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxName.Location = new System.Drawing.Point(125, 43);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(144, 28);
            this.textBoxName.TabIndex = 3;
            // 
            // checkBoxTimeIn
            // 
            this.checkBoxTimeIn.AutoSize = true;
            this.checkBoxTimeIn.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxTimeIn.Location = new System.Drawing.Point(343, 48);
            this.checkBoxTimeIn.Name = "checkBoxTimeIn";
            this.checkBoxTimeIn.Size = new System.Drawing.Size(107, 23);
            this.checkBoxTimeIn.TabIndex = 2;
            this.checkBoxTimeIn.Text = "入职时间";
            this.checkBoxTimeIn.UseVisualStyleBackColor = true;
            // 
            // checkBoxDept
            // 
            this.checkBoxDept.AutoSize = true;
            this.checkBoxDept.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxDept.Location = new System.Drawing.Point(37, 91);
            this.checkBoxDept.Name = "checkBoxDept";
            this.checkBoxDept.Size = new System.Drawing.Size(69, 23);
            this.checkBoxDept.TabIndex = 1;
            this.checkBoxDept.Text = "部门";
            this.checkBoxDept.UseVisualStyleBackColor = true;
            // 
            // checkBoxName
            // 
            this.checkBoxName.AutoSize = true;
            this.checkBoxName.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxName.Location = new System.Drawing.Point(37, 48);
            this.checkBoxName.Name = "checkBoxName";
            this.checkBoxName.Size = new System.Drawing.Size(69, 23);
            this.checkBoxName.TabIndex = 0;
            this.checkBoxName.Text = "姓名";
            this.checkBoxName.UseVisualStyleBackColor = true;
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbEdit,
            this.tsbDelete,
            this.tsbExport});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(1009, 32);
            this.toolStripMenu.TabIndex = 1;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.AccessibleDescription = "a";
            this.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAdd.Image = global::HRMSystem2023ZHU.Properties.Resources.add;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(29, 29);
            this.tsbAdd.Text = "添加";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbEdit
            // 
            this.tsbEdit.AccessibleDescription = "a";
            this.tsbEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEdit.Image = global::HRMSystem2023ZHU.Properties.Resources.edit;
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(29, 29);
            this.tsbEdit.Text = "编辑";
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.AccessibleDescription = "a";
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete.Image = global::HRMSystem2023ZHU.Properties.Resources.delete;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(29, 29);
            this.tsbDelete.Text = "删除";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // tsbExport
            // 
            this.tsbExport.AccessibleDescription = "a";
            this.tsbExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExport.Image = global::HRMSystem2023ZHU.Properties.Resources.export;
            this.tsbExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExport.Name = "tsbExport";
            this.tsbExport.Size = new System.Drawing.Size(29, 29);
            this.tsbExport.Text = "导出";
            this.tsbExport.Click += new System.EventHandler(this.tsbExport_Click);
            // 
            // dgvList
            // 
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(12, 232);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersWidth = 51;
            this.dgvList.RowTemplate.Height = 27;
            this.dgvList.Size = new System.Drawing.Size(985, 291);
            this.dgvList.TabIndex = 9;
            // 
            // FormEmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 544);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.toolStripMenu);
            this.Controls.Add(this.groupBoxList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEmployeeList";
            this.Text = "员工列表";
            this.Load += new System.EventHandler(this.FormEmployeeList_Load);
            this.groupBoxList.ResumeLayout(false);
            this.groupBoxList.PerformLayout();
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxList;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DateTimePicker dtpInDateTo;
        private System.Windows.Forms.DateTimePicker dtpInDateFrom;
        private System.Windows.Forms.Label labelDao;
        private System.Windows.Forms.ComboBox comboBoxDept;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.CheckBox checkBoxTimeIn;
        private System.Windows.Forms.CheckBox checkBoxDept;
        private System.Windows.Forms.CheckBox checkBoxName;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbExport;
        private System.Windows.Forms.DataGridView dgvList;
    }
}