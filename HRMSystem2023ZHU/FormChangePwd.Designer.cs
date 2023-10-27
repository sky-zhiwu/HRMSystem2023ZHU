namespace HRMSystem2023ZHU
{
    partial class FormChangePwd
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
            this.buttonChangepwd = new System.Windows.Forms.Button();
            this.textBoxChangepwd = new System.Windows.Forms.TextBox();
            this.textBoxYespwd = new System.Windows.Forms.TextBox();
            this.labelChangepwd = new System.Windows.Forms.Label();
            this.label1Yespwd = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonChangepwd
            // 
            this.buttonChangepwd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonChangepwd.Location = new System.Drawing.Point(33, 130);
            this.buttonChangepwd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonChangepwd.Name = "buttonChangepwd";
            this.buttonChangepwd.Size = new System.Drawing.Size(76, 47);
            this.buttonChangepwd.TabIndex = 21;
            this.buttonChangepwd.Text = "确定";
            this.buttonChangepwd.UseVisualStyleBackColor = true;
            this.buttonChangepwd.Click += new System.EventHandler(this.buttonChangepwd_Click);
            // 
            // textBoxChangepwd
            // 
            this.textBoxChangepwd.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxChangepwd.Location = new System.Drawing.Point(98, 27);
            this.textBoxChangepwd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxChangepwd.Name = "textBoxChangepwd";
            this.textBoxChangepwd.PasswordChar = '*';
            this.textBoxChangepwd.Size = new System.Drawing.Size(121, 28);
            this.textBoxChangepwd.TabIndex = 20;
            this.textBoxChangepwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxChangepwd_KeyPress);
            // 
            // textBoxYespwd
            // 
            this.textBoxYespwd.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxYespwd.Location = new System.Drawing.Point(98, 70);
            this.textBoxYespwd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxYespwd.Name = "textBoxYespwd";
            this.textBoxYespwd.PasswordChar = '*';
            this.textBoxYespwd.Size = new System.Drawing.Size(121, 28);
            this.textBoxYespwd.TabIndex = 19;
            // 
            // labelChangepwd
            // 
            this.labelChangepwd.AutoSize = true;
            this.labelChangepwd.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelChangepwd.Location = new System.Drawing.Point(16, 34);
            this.labelChangepwd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelChangepwd.Name = "labelChangepwd";
            this.labelChangepwd.Size = new System.Drawing.Size(85, 19);
            this.labelChangepwd.TabIndex = 17;
            this.labelChangepwd.Text = "修改密码";
            // 
            // label1Yespwd
            // 
            this.label1Yespwd.AutoSize = true;
            this.label1Yespwd.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1Yespwd.Location = new System.Drawing.Point(16, 77);
            this.label1Yespwd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1Yespwd.Name = "label1Yespwd";
            this.label1Yespwd.Size = new System.Drawing.Size(85, 19);
            this.label1Yespwd.TabIndex = 16;
            this.label1Yespwd.Text = "确认密码";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCancel.Location = new System.Drawing.Point(151, 130);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(76, 47);
            this.buttonCancel.TabIndex = 22;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormChangePwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 226);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonChangepwd);
            this.Controls.Add(this.textBoxChangepwd);
            this.Controls.Add(this.textBoxYespwd);
            this.Controls.Add(this.labelChangepwd);
            this.Controls.Add(this.label1Yespwd);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormChangePwd";
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.FormChangePwd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonChangepwd;
        private System.Windows.Forms.TextBox textBoxChangepwd;
        private System.Windows.Forms.TextBox textBoxYespwd;
        private System.Windows.Forms.Label labelChangepwd;
        private System.Windows.Forms.Label label1Yespwd;
        private System.Windows.Forms.Button buttonCancel;
    }
}