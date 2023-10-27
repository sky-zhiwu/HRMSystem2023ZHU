namespace HRMSystem2023ZHU
{
    partial class FormDeptList
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
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.groupBoxDelete = new System.Windows.Forms.GroupBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelAddDept = new System.Windows.Forms.Label();
            this.groupBoxRevise = new System.Windows.Forms.GroupBox();
            this.buttonRevise = new System.Windows.Forms.Button();
            this.textBoxReviseName = new System.Windows.Forms.TextBox();
            this.labelnewDname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.groupBoxSearch.SuspendLayout();
            this.groupBoxDelete.SuspendLayout();
            this.groupBoxAdd.SuspendLayout();
            this.groupBoxRevise.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(20, 29);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersWidth = 51;
            this.dgvList.RowTemplate.Height = 27;
            this.dgvList.Size = new System.Drawing.Size(332, 408);
            this.dgvList.TabIndex = 12;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(66, 34);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(67, 15);
            this.labelSearch.TabIndex = 13;
            this.labelSearch.Text = "关键字：";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(139, 24);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 25);
            this.textBoxSearch.TabIndex = 14;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(91, 66);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(71, 35);
            this.buttonSearch.TabIndex = 15;
            this.buttonSearch.Text = "查询";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.buttonSearch);
            this.groupBoxSearch.Controls.Add(this.textBoxSearch);
            this.groupBoxSearch.Controls.Add(this.labelSearch);
            this.groupBoxSearch.Location = new System.Drawing.Point(390, 29);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(267, 121);
            this.groupBoxSearch.TabIndex = 16;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "查询区";
            // 
            // groupBoxDelete
            // 
            this.groupBoxDelete.Controls.Add(this.buttonDelete);
            this.groupBoxDelete.Location = new System.Drawing.Point(689, 180);
            this.groupBoxDelete.Name = "groupBoxDelete";
            this.groupBoxDelete.Size = new System.Drawing.Size(162, 113);
            this.groupBoxDelete.TabIndex = 18;
            this.groupBoxDelete.TabStop = false;
            this.groupBoxDelete.Text = "删除区";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(28, 35);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(90, 52);
            this.buttonDelete.TabIndex = 15;
            this.buttonDelete.Text = "删除";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.Controls.Add(this.buttonAdd);
            this.groupBoxAdd.Controls.Add(this.textBoxName);
            this.groupBoxAdd.Controls.Add(this.labelAddDept);
            this.groupBoxAdd.Location = new System.Drawing.Point(689, 29);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Size = new System.Drawing.Size(267, 121);
            this.groupBoxAdd.TabIndex = 19;
            this.groupBoxAdd.TabStop = false;
            this.groupBoxAdd.Text = "添加区";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(91, 70);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(71, 35);
            this.buttonAdd.TabIndex = 15;
            this.buttonAdd.Text = "添加";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(113, 24);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 25);
            this.textBoxName.TabIndex = 14;
            // 
            // labelAddDept
            // 
            this.labelAddDept.AutoSize = true;
            this.labelAddDept.Location = new System.Drawing.Point(25, 34);
            this.labelAddDept.Name = "labelAddDept";
            this.labelAddDept.Size = new System.Drawing.Size(82, 15);
            this.labelAddDept.TabIndex = 13;
            this.labelAddDept.Text = "部门名称：";
            // 
            // groupBoxRevise
            // 
            this.groupBoxRevise.Controls.Add(this.buttonRevise);
            this.groupBoxRevise.Controls.Add(this.textBoxReviseName);
            this.groupBoxRevise.Controls.Add(this.labelnewDname);
            this.groupBoxRevise.Location = new System.Drawing.Point(390, 172);
            this.groupBoxRevise.Name = "groupBoxRevise";
            this.groupBoxRevise.Size = new System.Drawing.Size(267, 121);
            this.groupBoxRevise.TabIndex = 20;
            this.groupBoxRevise.TabStop = false;
            this.groupBoxRevise.Text = "修改区";
            // 
            // buttonRevise
            // 
            this.buttonRevise.Location = new System.Drawing.Point(91, 70);
            this.buttonRevise.Name = "buttonRevise";
            this.buttonRevise.Size = new System.Drawing.Size(71, 35);
            this.buttonRevise.TabIndex = 15;
            this.buttonRevise.Text = "修改";
            this.buttonRevise.UseVisualStyleBackColor = true;
            this.buttonRevise.Click += new System.EventHandler(this.buttonRevise_Click);
            // 
            // textBoxReviseName
            // 
            this.textBoxReviseName.Location = new System.Drawing.Point(139, 24);
            this.textBoxReviseName.Name = "textBoxReviseName";
            this.textBoxReviseName.Size = new System.Drawing.Size(100, 25);
            this.textBoxReviseName.TabIndex = 14;
            // 
            // labelnewDname
            // 
            this.labelnewDname.AutoSize = true;
            this.labelnewDname.Location = new System.Drawing.Point(21, 34);
            this.labelnewDname.Name = "labelnewDname";
            this.labelnewDname.Size = new System.Drawing.Size(112, 15);
            this.labelnewDname.TabIndex = 13;
            this.labelnewDname.Text = "新的部门名称：";
            // 
            // FormDeptList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 468);
            this.Controls.Add(this.groupBoxRevise);
            this.Controls.Add(this.groupBoxAdd);
            this.Controls.Add(this.groupBoxDelete);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.dgvList);
            this.Name = "FormDeptList";
            this.Text = "部门列表";
            this.Load += new System.EventHandler(this.FormDeptList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.groupBoxDelete.ResumeLayout(false);
            this.groupBoxAdd.ResumeLayout(false);
            this.groupBoxAdd.PerformLayout();
            this.groupBoxRevise.ResumeLayout(false);
            this.groupBoxRevise.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.GroupBox groupBoxDelete;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelAddDept;
        private System.Windows.Forms.GroupBox groupBoxRevise;
        private System.Windows.Forms.Button buttonRevise;
        private System.Windows.Forms.TextBox textBoxReviseName;
        private System.Windows.Forms.Label labelnewDname;
    }
}