namespace HRMSystem2023ZHU
{
    partial class FormLogQuery
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
            this.labelPositionPage = new System.Windows.Forms.Label();
            this.labelNextPage = new System.Windows.Forms.Label();
            this.labelBefore = new System.Windows.Forms.Label();
            this.labelEndPage = new System.Windows.Forms.Label();
            this.labelBegin = new System.Windows.Forms.Label();
            this.labelPages = new System.Windows.Forms.Label();
            this.dgvLog = new System.Windows.Forms.DataGridView();
            this.dtpTranslation = new System.Windows.Forms.DateTimePicker();
            this.labelddl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonTranOk = new System.Windows.Forms.Button();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpBeginDate = new System.Windows.Forms.DateTimePicker();
            this.groupBoxSeaLog = new System.Windows.Forms.GroupBox();
            this.checkBoxBeginDate = new System.Windows.Forms.CheckBox();
            this.checkBoxEndDate = new System.Windows.Forms.CheckBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.comboBoxDescription = new System.Windows.Forms.ComboBox();
            this.checkBoxDescription = new System.Windows.Forms.CheckBox();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.checkBoxName = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxSeaLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPositionPage
            // 
            this.labelPositionPage.AutoSize = true;
            this.labelPositionPage.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPositionPage.Location = new System.Drawing.Point(66, 320);
            this.labelPositionPage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPositionPage.Name = "labelPositionPage";
            this.labelPositionPage.Size = new System.Drawing.Size(67, 19);
            this.labelPositionPage.TabIndex = 14;
            this.labelPositionPage.Text = "第0页 ";
            // 
            // labelNextPage
            // 
            this.labelNextPage.AutoSize = true;
            this.labelNextPage.BackColor = System.Drawing.SystemColors.Control;
            this.labelNextPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelNextPage.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelNextPage.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelNextPage.Location = new System.Drawing.Point(367, 320);
            this.labelNextPage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNextPage.Name = "labelNextPage";
            this.labelNextPage.Size = new System.Drawing.Size(66, 19);
            this.labelNextPage.TabIndex = 13;
            this.labelNextPage.Text = "下一页";
            this.labelNextPage.Click += new System.EventHandler(this.labelNextPage_Click);
            // 
            // labelBefore
            // 
            this.labelBefore.AutoSize = true;
            this.labelBefore.BackColor = System.Drawing.SystemColors.Control;
            this.labelBefore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelBefore.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBefore.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelBefore.Location = new System.Drawing.Point(291, 320);
            this.labelBefore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBefore.Name = "labelBefore";
            this.labelBefore.Size = new System.Drawing.Size(66, 19);
            this.labelBefore.TabIndex = 12;
            this.labelBefore.Text = "上一页";
            this.labelBefore.Click += new System.EventHandler(this.labelBefore_Click);
            // 
            // labelEndPage
            // 
            this.labelEndPage.AutoSize = true;
            this.labelEndPage.BackColor = System.Drawing.SystemColors.Control;
            this.labelEndPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelEndPage.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelEndPage.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelEndPage.Location = new System.Drawing.Point(230, 320);
            this.labelEndPage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEndPage.Name = "labelEndPage";
            this.labelEndPage.Size = new System.Drawing.Size(47, 19);
            this.labelEndPage.TabIndex = 11;
            this.labelEndPage.Text = "末页";
            this.labelEndPage.Click += new System.EventHandler(this.labelEndPage_Click);
            // 
            // labelBegin
            // 
            this.labelBegin.AutoSize = true;
            this.labelBegin.BackColor = System.Drawing.SystemColors.Control;
            this.labelBegin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelBegin.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBegin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelBegin.Location = new System.Drawing.Point(168, 320);
            this.labelBegin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBegin.Name = "labelBegin";
            this.labelBegin.Size = new System.Drawing.Size(47, 19);
            this.labelBegin.TabIndex = 10;
            this.labelBegin.Text = "首页";
            this.labelBegin.Click += new System.EventHandler(this.labelBegin_Click);
            // 
            // labelPages
            // 
            this.labelPages.AutoSize = true;
            this.labelPages.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPages.Location = new System.Drawing.Point(11, 320);
            this.labelPages.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPages.Name = "labelPages";
            this.labelPages.Size = new System.Drawing.Size(67, 19);
            this.labelPages.TabIndex = 9;
            this.labelPages.Text = "共0页 ";
            // 
            // dgvLog
            // 
            this.dgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLog.Location = new System.Drawing.Point(9, 10);
            this.dgvLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvLog.Name = "dgvLog";
            this.dgvLog.RowHeadersWidth = 51;
            this.dgvLog.RowTemplate.Height = 27;
            this.dgvLog.Size = new System.Drawing.Size(424, 281);
            this.dgvLog.TabIndex = 8;
            // 
            // dtpTranslation
            // 
            this.dtpTranslation.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpTranslation.Location = new System.Drawing.Point(87, 19);
            this.dtpTranslation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpTranslation.Name = "dtpTranslation";
            this.dtpTranslation.Size = new System.Drawing.Size(116, 28);
            this.dtpTranslation.TabIndex = 16;
            // 
            // labelddl
            // 
            this.labelddl.AutoSize = true;
            this.labelddl.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelddl.Location = new System.Drawing.Point(4, 26);
            this.labelddl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelddl.Name = "labelddl";
            this.labelddl.Size = new System.Drawing.Size(104, 19);
            this.labelddl.TabIndex = 17;
            this.labelddl.Text = "截止日期：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonTranOk);
            this.groupBox1.Controls.Add(this.dtpTranslation);
            this.groupBox1.Controls.Add(this.labelddl);
            this.groupBox1.Location = new System.Drawing.Point(462, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(215, 86);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "日志迁移";
            // 
            // buttonTranOk
            // 
            this.buttonTranOk.Location = new System.Drawing.Point(87, 58);
            this.buttonTranOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonTranOk.Name = "buttonTranOk";
            this.buttonTranOk.Size = new System.Drawing.Size(47, 24);
            this.buttonTranOk.TabIndex = 18;
            this.buttonTranOk.Text = "确定";
            this.buttonTranOk.UseVisualStyleBackColor = true;
            this.buttonTranOk.Click += new System.EventHandler(this.buttonTranOk_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpEndDate.Location = new System.Drawing.Point(116, 54);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(116, 28);
            this.dtpEndDate.TabIndex = 19;
            // 
            // dtpBeginDate
            // 
            this.dtpBeginDate.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpBeginDate.Location = new System.Drawing.Point(116, 19);
            this.dtpBeginDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpBeginDate.Name = "dtpBeginDate";
            this.dtpBeginDate.Size = new System.Drawing.Size(116, 28);
            this.dtpBeginDate.TabIndex = 20;
            // 
            // groupBoxSeaLog
            // 
            this.groupBoxSeaLog.Controls.Add(this.checkBoxBeginDate);
            this.groupBoxSeaLog.Controls.Add(this.checkBoxEndDate);
            this.groupBoxSeaLog.Controls.Add(this.buttonSearch);
            this.groupBoxSeaLog.Controls.Add(this.comboBoxDescription);
            this.groupBoxSeaLog.Controls.Add(this.checkBoxDescription);
            this.groupBoxSeaLog.Controls.Add(this.comboBoxName);
            this.groupBoxSeaLog.Controls.Add(this.checkBoxName);
            this.groupBoxSeaLog.Controls.Add(this.dtpBeginDate);
            this.groupBoxSeaLog.Controls.Add(this.dtpEndDate);
            this.groupBoxSeaLog.Location = new System.Drawing.Point(462, 101);
            this.groupBoxSeaLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxSeaLog.Name = "groupBoxSeaLog";
            this.groupBoxSeaLog.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxSeaLog.Size = new System.Drawing.Size(251, 238);
            this.groupBoxSeaLog.TabIndex = 23;
            this.groupBoxSeaLog.TabStop = false;
            this.groupBoxSeaLog.Text = "日志查询";
            // 
            // checkBoxBeginDate
            // 
            this.checkBoxBeginDate.AutoSize = true;
            this.checkBoxBeginDate.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxBeginDate.Location = new System.Drawing.Point(8, 24);
            this.checkBoxBeginDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxBeginDate.Name = "checkBoxBeginDate";
            this.checkBoxBeginDate.Size = new System.Drawing.Size(126, 23);
            this.checkBoxBeginDate.TabIndex = 29;
            this.checkBoxBeginDate.Text = "开始日期：";
            this.checkBoxBeginDate.UseVisualStyleBackColor = true;
            // 
            // checkBoxEndDate
            // 
            this.checkBoxEndDate.AutoSize = true;
            this.checkBoxEndDate.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxEndDate.Location = new System.Drawing.Point(8, 58);
            this.checkBoxEndDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxEndDate.Name = "checkBoxEndDate";
            this.checkBoxEndDate.Size = new System.Drawing.Size(126, 23);
            this.checkBoxEndDate.TabIndex = 28;
            this.checkBoxEndDate.Text = "截止日期：";
            this.checkBoxEndDate.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSearch.Location = new System.Drawing.Point(176, 147);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(55, 43);
            this.buttonSearch.TabIndex = 27;
            this.buttonSearch.Text = "查询";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // comboBoxDescription
            // 
            this.comboBoxDescription.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDescription.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxDescription.FormattingEnabled = true;
            this.comboBoxDescription.Location = new System.Drawing.Point(8, 194);
            this.comboBoxDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxDescription.Name = "comboBoxDescription";
            this.comboBoxDescription.Size = new System.Drawing.Size(156, 26);
            this.comboBoxDescription.TabIndex = 26;
            // 
            // checkBoxDescription
            // 
            this.checkBoxDescription.AutoSize = true;
            this.checkBoxDescription.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxDescription.Location = new System.Drawing.Point(8, 161);
            this.checkBoxDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxDescription.Name = "checkBoxDescription";
            this.checkBoxDescription.Size = new System.Drawing.Size(145, 23);
            this.checkBoxDescription.TabIndex = 25;
            this.checkBoxDescription.Text = "操作描述关键";
            this.checkBoxDescription.UseVisualStyleBackColor = true;
            // 
            // comboBoxName
            // 
            this.comboBoxName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxName.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(8, 125);
            this.comboBoxName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(156, 26);
            this.comboBoxName.TabIndex = 24;
            // 
            // checkBoxName
            // 
            this.checkBoxName.AutoSize = true;
            this.checkBoxName.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxName.Location = new System.Drawing.Point(8, 91);
            this.checkBoxName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxName.Name = "checkBoxName";
            this.checkBoxName.Size = new System.Drawing.Size(107, 23);
            this.checkBoxName.TabIndex = 23;
            this.checkBoxName.Text = "真实姓名";
            this.checkBoxName.UseVisualStyleBackColor = true;
            // 
            // FormLogQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 357);
            this.Controls.Add(this.groupBoxSeaLog);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelPositionPage);
            this.Controls.Add(this.labelNextPage);
            this.Controls.Add(this.labelBefore);
            this.Controls.Add(this.labelEndPage);
            this.Controls.Add(this.labelBegin);
            this.Controls.Add(this.labelPages);
            this.Controls.Add(this.dgvLog);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormLogQuery";
            this.Text = "查看日志";
            this.Load += new System.EventHandler(this.FormLogQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxSeaLog.ResumeLayout(false);
            this.groupBoxSeaLog.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPositionPage;
        private System.Windows.Forms.Label labelNextPage;
        private System.Windows.Forms.Label labelBefore;
        private System.Windows.Forms.Label labelEndPage;
        private System.Windows.Forms.Label labelBegin;
        private System.Windows.Forms.Label labelPages;
        private System.Windows.Forms.DataGridView dgvLog;
        private System.Windows.Forms.DateTimePicker dtpTranslation;
        private System.Windows.Forms.Label labelddl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonTranOk;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpBeginDate;
        private System.Windows.Forms.GroupBox groupBoxSeaLog;
        private System.Windows.Forms.CheckBox checkBoxBeginDate;
        private System.Windows.Forms.CheckBox checkBoxEndDate;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ComboBox comboBoxDescription;
        private System.Windows.Forms.CheckBox checkBoxDescription;
        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.CheckBox checkBoxName;
    }
}