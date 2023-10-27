namespace HRMSystem2023ZHU
{
    partial class FormSalaryList
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
            this.dgvSalarySheetItems = new System.Windows.Forms.DataGridView();
            this.buttonSave = new System.Windows.Forms.Button();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelMonth = new System.Windows.Forms.Label();
            this.comboBoxDept = new System.Windows.Forms.ComboBox();
            this.labelDept = new System.Windows.Forms.Label();
            this.buttonSal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalarySheetItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSalarySheetItems
            // 
            this.dgvSalarySheetItems.AllowUserToAddRows = false;
            this.dgvSalarySheetItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalarySheetItems.Location = new System.Drawing.Point(12, 65);
            this.dgvSalarySheetItems.Name = "dgvSalarySheetItems";
            this.dgvSalarySheetItems.RowHeadersWidth = 51;
            this.dgvSalarySheetItems.RowTemplate.Height = 27;
            this.dgvSalarySheetItems.Size = new System.Drawing.Size(870, 352);
            this.dgvSalarySheetItems.TabIndex = 0;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSave.Location = new System.Drawing.Point(755, 438);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(110, 38);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "保存";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxYear.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Location = new System.Drawing.Point(70, 21);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(102, 26);
            this.comboBoxYear.TabIndex = 2;
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMonth.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Location = new System.Drawing.Point(212, 21);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(102, 26);
            this.comboBoxMonth.TabIndex = 3;
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelYear.Location = new System.Drawing.Point(178, 25);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(28, 19);
            this.labelYear.TabIndex = 4;
            this.labelYear.Text = "年";
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelMonth.Location = new System.Drawing.Point(320, 25);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(28, 19);
            this.labelMonth.TabIndex = 5;
            this.labelMonth.Text = "月";
            // 
            // comboBoxDept
            // 
            this.comboBoxDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDept.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxDept.FormattingEnabled = true;
            this.comboBoxDept.Location = new System.Drawing.Point(441, 21);
            this.comboBoxDept.Name = "comboBoxDept";
            this.comboBoxDept.Size = new System.Drawing.Size(140, 26);
            this.comboBoxDept.TabIndex = 6;
            // 
            // labelDept
            // 
            this.labelDept.AutoSize = true;
            this.labelDept.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelDept.Location = new System.Drawing.Point(388, 25);
            this.labelDept.Name = "labelDept";
            this.labelDept.Size = new System.Drawing.Size(47, 19);
            this.labelDept.TabIndex = 7;
            this.labelDept.Text = "部门";
            // 
            // buttonSal
            // 
            this.buttonSal.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSal.Location = new System.Drawing.Point(633, 13);
            this.buttonSal.Name = "buttonSal";
            this.buttonSal.Size = new System.Drawing.Size(129, 41);
            this.buttonSal.TabIndex = 8;
            this.buttonSal.Text = "生成工资单";
            this.buttonSal.UseVisualStyleBackColor = true;
            this.buttonSal.Click += new System.EventHandler(this.buttonSal_Click);
            // 
            // FormSalaryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 488);
            this.Controls.Add(this.buttonSal);
            this.Controls.Add(this.labelDept);
            this.Controls.Add(this.comboBoxDept);
            this.Controls.Add(this.labelMonth);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.comboBoxMonth);
            this.Controls.Add(this.comboBoxYear);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dgvSalarySheetItems);
            this.Name = "FormSalaryList";
            this.Text = "生成工资单";
            this.Load += new System.EventHandler(this.FormSalaryList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalarySheetItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSalarySheetItems;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.ComboBox comboBoxDept;
        private System.Windows.Forms.Label labelDept;
        private System.Windows.Forms.Button buttonSal;
    }
}