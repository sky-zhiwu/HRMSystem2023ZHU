namespace HRMSystem2023ZHU
{
    partial class FormPrintSalarySheet
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
            this.buttonSearchSalarySheet = new System.Windows.Forms.Button();
            this.labelDept = new System.Windows.Forms.Label();
            this.comboBoxDept = new System.Windows.Forms.ComboBox();
            this.labelMonth = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.rvPrintSalary = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // buttonSearchSalarySheet
            // 
            this.buttonSearchSalarySheet.Location = new System.Drawing.Point(698, 18);
            this.buttonSearchSalarySheet.Name = "buttonSearchSalarySheet";
            this.buttonSearchSalarySheet.Size = new System.Drawing.Size(135, 33);
            this.buttonSearchSalarySheet.TabIndex = 1;
            this.buttonSearchSalarySheet.Text = "查询工资单";
            this.buttonSearchSalarySheet.UseVisualStyleBackColor = true;
            this.buttonSearchSalarySheet.Click += new System.EventHandler(this.buttonSearchSalarySheet_Click);
            // 
            // labelDept
            // 
            this.labelDept.AutoSize = true;
            this.labelDept.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelDept.Location = new System.Drawing.Point(364, 29);
            this.labelDept.Name = "labelDept";
            this.labelDept.Size = new System.Drawing.Size(47, 19);
            this.labelDept.TabIndex = 13;
            this.labelDept.Text = "部门";
            // 
            // comboBoxDept
            // 
            this.comboBoxDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDept.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxDept.FormattingEnabled = true;
            this.comboBoxDept.Location = new System.Drawing.Point(417, 25);
            this.comboBoxDept.Name = "comboBoxDept";
            this.comboBoxDept.Size = new System.Drawing.Size(140, 26);
            this.comboBoxDept.TabIndex = 12;
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelMonth.Location = new System.Drawing.Point(296, 29);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(28, 19);
            this.labelMonth.TabIndex = 11;
            this.labelMonth.Text = "月";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelYear.Location = new System.Drawing.Point(154, 29);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(28, 19);
            this.labelYear.TabIndex = 10;
            this.labelYear.Text = "年";
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMonth.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Location = new System.Drawing.Point(188, 25);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(102, 26);
            this.comboBoxMonth.TabIndex = 9;
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxYear.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Location = new System.Drawing.Point(46, 25);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(102, 26);
            this.comboBoxYear.TabIndex = 8;
            // 
            // rvPrintSalary
            // 
            this.rvPrintSalary.LocalReport.ReportEmbeddedResource = "HRMSystem2023ZHU.ReportSalary.rdlc";
            this.rvPrintSalary.Location = new System.Drawing.Point(12, 75);
            this.rvPrintSalary.Name = "rvPrintSalary";
            this.rvPrintSalary.ServerReport.BearerToken = null;
            this.rvPrintSalary.Size = new System.Drawing.Size(970, 498);
            this.rvPrintSalary.TabIndex = 14;
            // 
            // FormPrintSalarySheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 596);
            this.Controls.Add(this.rvPrintSalary);
            this.Controls.Add(this.labelDept);
            this.Controls.Add(this.comboBoxDept);
            this.Controls.Add(this.labelMonth);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.comboBoxMonth);
            this.Controls.Add(this.comboBoxYear);
            this.Controls.Add(this.buttonSearchSalarySheet);
            this.Name = "FormPrintSalarySheet";
            this.Text = "打印工资单";
            this.Load += new System.EventHandler(this.FormPrintSalarySheet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSearchSalarySheet;
        private System.Windows.Forms.Label labelDept;
        private System.Windows.Forms.ComboBox comboBoxDept;
        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private Microsoft.Reporting.WinForms.ReportViewer rvPrintSalary;
    }
}