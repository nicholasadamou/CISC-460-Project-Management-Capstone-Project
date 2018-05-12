namespace WindowsFormsApplication2
{
    partial class AvailableContracts
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
            this.available_contracts_label = new System.Windows.Forms.Label();
            this.available_rchtxtbx = new System.Windows.Forms.RichTextBox();
            this.exit_btn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contract_num_label = new System.Windows.Forms.Label();
            this.select_btn = new System.Windows.Forms.Button();
            this.selection_mskedtxtbx = new System.Windows.Forms.MaskedTextBox();
            this.delinquent_chkbx = new System.Windows.Forms.CheckBox();
            this.btn_UpdateArchive = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // available_contracts_label
            // 
            this.available_contracts_label.AutoSize = true;
            this.available_contracts_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.available_contracts_label.Location = new System.Drawing.Point(75, 36);
            this.available_contracts_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.available_contracts_label.Name = "available_contracts_label";
            this.available_contracts_label.Size = new System.Drawing.Size(272, 36);
            this.available_contracts_label.TabIndex = 0;
            this.available_contracts_label.Text = "Available Contracts";
            // 
            // available_rchtxtbx
            // 
            this.available_rchtxtbx.Location = new System.Drawing.Point(10, 78);
            this.available_rchtxtbx.Margin = new System.Windows.Forms.Padding(2);
            this.available_rchtxtbx.Name = "available_rchtxtbx";
            this.available_rchtxtbx.ReadOnly = true;
            this.available_rchtxtbx.Size = new System.Drawing.Size(399, 386);
            this.available_rchtxtbx.TabIndex = 1;
            this.available_rchtxtbx.Text = "";
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(222, 578);
            this.exit_btn.Margin = new System.Windows.Forms.Padding(2);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(57, 28);
            this.exit_btn.TabIndex = 2;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(417, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // contract_num_label
            // 
            this.contract_num_label.AutoSize = true;
            this.contract_num_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contract_num_label.Location = new System.Drawing.Point(9, 506);
            this.contract_num_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contract_num_label.Name = "contract_num_label";
            this.contract_num_label.Size = new System.Drawing.Size(140, 20);
            this.contract_num_label.TabIndex = 4;
            this.contract_num_label.Text = "Contract Selection";
            // 
            // select_btn
            // 
            this.select_btn.Location = new System.Drawing.Point(136, 578);
            this.select_btn.Margin = new System.Windows.Forms.Padding(2);
            this.select_btn.Name = "select_btn";
            this.select_btn.Size = new System.Drawing.Size(57, 28);
            this.select_btn.TabIndex = 6;
            this.select_btn.Text = "Select";
            this.select_btn.UseVisualStyleBackColor = true;
            this.select_btn.Click += new System.EventHandler(this.select_btn_Click);
            // 
            // selection_mskedtxtbx
            // 
            this.selection_mskedtxtbx.Location = new System.Drawing.Point(153, 508);
            this.selection_mskedtxtbx.Margin = new System.Windows.Forms.Padding(2);
            this.selection_mskedtxtbx.Mask = "000000000";
            this.selection_mskedtxtbx.Name = "selection_mskedtxtbx";
            this.selection_mskedtxtbx.Size = new System.Drawing.Size(64, 20);
            this.selection_mskedtxtbx.TabIndex = 7;
            // 
            // delinquent_chkbx
            // 
            this.delinquent_chkbx.AutoSize = true;
            this.delinquent_chkbx.Location = new System.Drawing.Point(282, 511);
            this.delinquent_chkbx.Name = "delinquent_chkbx";
            this.delinquent_chkbx.Size = new System.Drawing.Size(77, 17);
            this.delinquent_chkbx.TabIndex = 8;
            this.delinquent_chkbx.Text = "Delinquent";
            this.delinquent_chkbx.UseVisualStyleBackColor = true;
            this.delinquent_chkbx.CheckedChanged += new System.EventHandler(this.delinquent_chkbx_CheckedChanged);
            // 
            // btn_UpdateArchive
            // 
            this.btn_UpdateArchive.Location = new System.Drawing.Point(13, 583);
            this.btn_UpdateArchive.Name = "btn_UpdateArchive";
            this.btn_UpdateArchive.Size = new System.Drawing.Size(75, 42);
            this.btn_UpdateArchive.TabIndex = 9;
            this.btn_UpdateArchive.Text = "Update Archive";
            this.btn_UpdateArchive.UseVisualStyleBackColor = true;
            this.btn_UpdateArchive.Click += new System.EventHandler(this.btn_UpdateArchive_Click);
            // 
            // AvailableContracts
            // 
            this.AcceptButton = this.select_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 637);
            this.ControlBox = false;
            this.Controls.Add(this.btn_UpdateArchive);
            this.Controls.Add(this.delinquent_chkbx);
            this.Controls.Add(this.selection_mskedtxtbx);
            this.Controls.Add(this.select_btn);
            this.Controls.Add(this.contract_num_label);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.available_rchtxtbx);
            this.Controls.Add(this.available_contracts_label);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AvailableContracts";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AvailableContracts_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label available_contracts_label;
        private System.Windows.Forms.RichTextBox available_rchtxtbx;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label contract_num_label;
        private System.Windows.Forms.Button select_btn;
        private System.Windows.Forms.MaskedTextBox selection_mskedtxtbx;
        private System.Windows.Forms.CheckBox delinquent_chkbx;
        private System.Windows.Forms.Button btn_UpdateArchive;
    }
}