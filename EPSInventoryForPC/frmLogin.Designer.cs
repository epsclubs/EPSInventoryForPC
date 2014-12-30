namespace EPSInventoryForPC
{
    partial class frmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboUserType = new System.Windows.Forms.ComboBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnLog = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select User Type";
            // 
            // comboUserType
            // 
            this.comboUserType.FormattingEnabled = true;
            this.comboUserType.Items.AddRange(new object[] {
            "Administrator",
            "Guest"});
            this.comboUserType.Location = new System.Drawing.Point(136, 6);
            this.comboUserType.Name = "comboUserType";
            this.comboUserType.Size = new System.Drawing.Size(224, 28);
            this.comboUserType.TabIndex = 1;
            this.comboUserType.Text = "Administrator";
            this.comboUserType.SelectedIndexChanged += new System.EventHandler(this.comboUserType_SelectedIndexChanged);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(136, 55);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(224, 27);
            this.txtPass.TabIndex = 2;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(136, 113);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(224, 43);
            this.btnLog.TabIndex = 4;
            this.btnLog.Text = "Log In";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLog;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 168);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.comboUserType);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(387, 206);
            this.MinimumSize = new System.Drawing.Size(387, 206);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboUserType;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Label label2;
    }
}

