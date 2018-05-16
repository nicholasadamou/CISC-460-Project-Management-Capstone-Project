namespace WindowsFormsApplication2
{
    partial class ArchivedContracts
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
            this.select_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.archived_rchtxtxbx = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archived_contracts_lbl = new System.Windows.Forms.Label();
            this.maskedtxtbx_Selection = new System.Windows.Forms.MaskedTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // select_btn
            // 
            this.select_btn.Location = new System.Drawing.Point(120, 549);
            this.select_btn.Name = "select_btn";
            this.select_btn.Size = new System.Drawing.Size(75, 23);
            this.select_btn.TabIndex = 0;
            this.select_btn.Text = "&Select";
            this.select_btn.UseVisualStyleBackColor = true;
            this.select_btn.Click += new System.EventHandler(this.select_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(231, 549);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(75, 23);
            this.exit_btn.TabIndex = 1;
            this.exit_btn.Text = "&Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 504);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Contract Selection";
            // 
            // archived_rchtxtxbx
            // 
            this.archived_rchtxtxbx.Enabled = false;
            this.archived_rchtxtxbx.Location = new System.Drawing.Point(12, 80);
            this.archived_rchtxtxbx.Name = "archived_rchtxtxbx";
            this.archived_rchtxtxbx.ReadOnly = true;
            this.archived_rchtxtxbx.Size = new System.Drawing.Size(405, 412);
            this.archived_rchtxtxbx.TabIndex = 3;
            this.archived_rchtxtxbx.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(429, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.selectToolStripMenuItem.Text = "Select";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // archived_contracts_lbl
            // 
            this.archived_contracts_lbl.AutoSize = true;
            this.archived_contracts_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archived_contracts_lbl.Location = new System.Drawing.Point(80, 41);
            this.archived_contracts_lbl.Name = "archived_contracts_lbl";
            this.archived_contracts_lbl.Size = new System.Drawing.Size(268, 36);
            this.archived_contracts_lbl.TabIndex = 5;
            this.archived_contracts_lbl.Text = "Archived Contracts";
            // 
            // maskedtxtbx_Selection
            // 
            this.maskedtxtbx_Selection.Location = new System.Drawing.Point(158, 506);
            this.maskedtxtbx_Selection.Mask = "000000000";
            this.maskedtxtbx_Selection.Name = "maskedtxtbx_Selection";
            this.maskedtxtbx_Selection.Size = new System.Drawing.Size(63, 20);
            this.maskedtxtbx_Selection.TabIndex = 6;
            // 
            // ArchivedContracts
            // 
            this.AcceptButton = this.select_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 595);
            this.ControlBox = false;
            this.Controls.Add(this.maskedtxtbx_Selection);
            this.Controls.Add(this.archived_contracts_lbl);
            this.Controls.Add(this.archived_rchtxtxbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.select_btn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ArchivedContracts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ArchivedContracts_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button select_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox archived_rchtxtxbx;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label archived_contracts_lbl;
        private System.Windows.Forms.MaskedTextBox maskedtxtbx_Selection;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}