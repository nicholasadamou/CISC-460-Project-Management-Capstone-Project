namespace WindowsFormsApplication2
{
    partial class ProcessDescriptions
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
            this.code_mskedtxtbx = new System.Windows.Forms.MaskedTextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInformation = new System.Windows.Forms.Label();
            this.information_rchtxtbx = new System.Windows.Forms.RichTextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // code_mskedtxtbx
            // 
            this.code_mskedtxtbx.Location = new System.Drawing.Point(83, 40);
            this.code_mskedtxtbx.Mask = "000";
            this.code_mskedtxtbx.Name = "code_mskedtxtbx";
            this.code_mskedtxtbx.Size = new System.Drawing.Size(24, 20);
            this.code_mskedtxtbx.TabIndex = 0;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(12, 43);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(65, 13);
            this.lblCode.TabIndex = 1;
            this.lblCode.Text = "3-Digit Code";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(82, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(120, 13);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Process Description";
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Location = new System.Drawing.Point(12, 73);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(59, 13);
            this.lblInformation.TabIndex = 3;
            this.lblInformation.Text = "Information";
            // 
            // information_rchtxtbx
            // 
            this.information_rchtxtbx.Location = new System.Drawing.Point(83, 70);
            this.information_rchtxtbx.Name = "information_rchtxtbx";
            this.information_rchtxtbx.Size = new System.Drawing.Size(179, 154);
            this.information_rchtxtbx.TabIndex = 4;
            this.information_rchtxtbx.Text = "";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(25, 240);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(187, 240);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(106, 240);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ProcessDescriptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 275);
            this.ControlBox = false;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.information_rchtxtbx);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.code_mskedtxtbx);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ProcessDescriptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ProcessDescriptions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox code_mskedtxtbx;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.RichTextBox information_rchtxtbx;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
    }
}