namespace WindowsFormsApplication2
{
    partial class Selection
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
            this.selection_label = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.availableContractsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contractEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forecastingReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.available_contracts_btn = new System.Windows.Forms.Button();
            this.contract_entry_btn = new System.Windows.Forms.Button();
            this.reports_btn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // selection_label
            // 
            this.selection_label.AutoSize = true;
            this.selection_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selection_label.Location = new System.Drawing.Point(127, 9);
            this.selection_label.Name = "selection_label";
            this.selection_label.Size = new System.Drawing.Size(261, 44);
            this.selection_label.TabIndex = 0;
            this.selection_label.Text = "Select A Form";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(502, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.availableContractsToolStripMenuItem,
            this.contractEntryToolStripMenuItem,
            this.forecastingReportsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // availableContractsToolStripMenuItem
            // 
            this.availableContractsToolStripMenuItem.Name = "availableContractsToolStripMenuItem";
            this.availableContractsToolStripMenuItem.Size = new System.Drawing.Size(209, 24);
            this.availableContractsToolStripMenuItem.Text = "Available Contracts";
            this.availableContractsToolStripMenuItem.Click += new System.EventHandler(this.available_contracts_btn_Click);
            // 
            // contractEntryToolStripMenuItem
            // 
            this.contractEntryToolStripMenuItem.Name = "contractEntryToolStripMenuItem";
            this.contractEntryToolStripMenuItem.Size = new System.Drawing.Size(209, 24);
            this.contractEntryToolStripMenuItem.Text = "Contract Entry";
            this.contractEntryToolStripMenuItem.Click += new System.EventHandler(this.contract_entry_btn_Click);
            // 
            // forecastingReportsToolStripMenuItem
            // 
            this.forecastingReportsToolStripMenuItem.Name = "forecastingReportsToolStripMenuItem";
            this.forecastingReportsToolStripMenuItem.Size = new System.Drawing.Size(209, 24);
            this.forecastingReportsToolStripMenuItem.Text = "Forecasting Reports";
            this.forecastingReportsToolStripMenuItem.Click += new System.EventHandler(this.reports_btn_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(209, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // available_contracts_btn
            // 
            this.available_contracts_btn.Location = new System.Drawing.Point(175, 75);
            this.available_contracts_btn.Name = "available_contracts_btn";
            this.available_contracts_btn.Size = new System.Drawing.Size(150, 47);
            this.available_contracts_btn.TabIndex = 2;
            this.available_contracts_btn.Text = "Available Contracts";
            this.available_contracts_btn.UseVisualStyleBackColor = true;
            this.available_contracts_btn.Click += new System.EventHandler(this.available_contracts_btn_Click);
            // 
            // contract_entry_btn
            // 
            this.contract_entry_btn.Location = new System.Drawing.Point(175, 147);
            this.contract_entry_btn.Name = "contract_entry_btn";
            this.contract_entry_btn.Size = new System.Drawing.Size(150, 47);
            this.contract_entry_btn.TabIndex = 3;
            this.contract_entry_btn.Text = "Contract Entry";
            this.contract_entry_btn.UseVisualStyleBackColor = true;
            this.contract_entry_btn.Click += new System.EventHandler(this.contract_entry_btn_Click);
            // 
            // reports_btn
            // 
            this.reports_btn.Location = new System.Drawing.Point(175, 221);
            this.reports_btn.Name = "reports_btn";
            this.reports_btn.Size = new System.Drawing.Size(150, 47);
            this.reports_btn.TabIndex = 4;
            this.reports_btn.Text = "Forecasting Reports";
            this.reports_btn.UseVisualStyleBackColor = true;
            this.reports_btn.Click += new System.EventHandler(this.reports_btn_Click);
            // 
            // Selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 310);
            this.ControlBox = false;
            this.Controls.Add(this.reports_btn);
            this.Controls.Add(this.contract_entry_btn);
            this.Controls.Add(this.available_contracts_btn);
            this.Controls.Add(this.selection_label);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Selection";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selection_label;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem availableContractsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contractEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forecastingReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button available_contracts_btn;
        private System.Windows.Forms.Button contract_entry_btn;
        private System.Windows.Forms.Button reports_btn;
    }
}