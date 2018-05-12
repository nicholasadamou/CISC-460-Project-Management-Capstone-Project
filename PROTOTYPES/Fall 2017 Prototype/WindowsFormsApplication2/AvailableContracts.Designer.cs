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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // available_contracts_label
            // 
            this.available_contracts_label.AutoSize = true;
            this.available_contracts_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.available_contracts_label.Location = new System.Drawing.Point(116, 9);
            this.available_contracts_label.Name = "available_contracts_label";
            this.available_contracts_label.Size = new System.Drawing.Size(348, 44);
            this.available_contracts_label.TabIndex = 0;
            this.available_contracts_label.Text = "Available Contracts";
            // 
            // available_rchtxtbx
            // 
            this.available_rchtxtbx.Location = new System.Drawing.Point(13, 56);
            this.available_rchtxtbx.Name = "available_rchtxtbx";
            this.available_rchtxtbx.ReadOnly = true;
            this.available_rchtxtbx.Size = new System.Drawing.Size(531, 474);
            this.available_rchtxtbx.TabIndex = 1;
            this.available_rchtxtbx.Text = "";
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(309, 672);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(76, 34);
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
            this.menuStrip1.Size = new System.Drawing.Size(556, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // contract_num_label
            // 
            this.contract_num_label.AutoSize = true;
            this.contract_num_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contract_num_label.Location = new System.Drawing.Point(12, 584);
            this.contract_num_label.Name = "contract_num_label";
            this.contract_num_label.Size = new System.Drawing.Size(172, 25);
            this.contract_num_label.TabIndex = 4;
            this.contract_num_label.Text = "Contract Selection";
            // 
            // select_btn
            // 
            this.select_btn.Location = new System.Drawing.Point(195, 672);
            this.select_btn.Name = "select_btn";
            this.select_btn.Size = new System.Drawing.Size(76, 34);
            this.select_btn.TabIndex = 6;
            this.select_btn.Text = "Select";
            this.select_btn.UseVisualStyleBackColor = true;
            this.select_btn.Click += new System.EventHandler(this.select_btn_Click);
            // 
            // selection_mskedtxtbx
            // 
            this.selection_mskedtxtbx.Location = new System.Drawing.Point(195, 586);
            this.selection_mskedtxtbx.Mask = "000000000";
            this.selection_mskedtxtbx.Name = "selection_mskedtxtbx";
            this.selection_mskedtxtbx.Size = new System.Drawing.Size(100, 22);
            this.selection_mskedtxtbx.TabIndex = 7;
            // 
            // AvailableContracts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 718);
            this.ControlBox = false;
            this.Controls.Add(this.selection_mskedtxtbx);
            this.Controls.Add(this.select_btn);
            this.Controls.Add(this.contract_num_label);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.available_rchtxtbx);
            this.Controls.Add(this.available_contracts_label);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AvailableContracts";
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
    }
}