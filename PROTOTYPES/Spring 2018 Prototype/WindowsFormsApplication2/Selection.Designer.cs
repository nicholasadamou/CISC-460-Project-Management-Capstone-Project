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
            this.processes_btn = new System.Windows.Forms.Button();
            this.btn_ProcessDefinitions = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // selection_label
            // 
            this.selection_label.AutoSize = true;
            this.selection_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selection_label.Location = new System.Drawing.Point(90, 28);
            this.selection_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.selection_label.Name = "selection_label";
            this.selection_label.Size = new System.Drawing.Size(202, 36);
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(376, 24);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // availableContractsToolStripMenuItem
            // 
            this.availableContractsToolStripMenuItem.Name = "availableContractsToolStripMenuItem";
            this.availableContractsToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.availableContractsToolStripMenuItem.Text = "Available Contracts";
            this.availableContractsToolStripMenuItem.Click += new System.EventHandler(this.available_contracts_btn_Click);
            // 
            // contractEntryToolStripMenuItem
            // 
            this.contractEntryToolStripMenuItem.Name = "contractEntryToolStripMenuItem";
            this.contractEntryToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.contractEntryToolStripMenuItem.Text = "Contract Entry";
            this.contractEntryToolStripMenuItem.Click += new System.EventHandler(this.contract_entry_btn_Click);
            // 
            // forecastingReportsToolStripMenuItem
            // 
            this.forecastingReportsToolStripMenuItem.Name = "forecastingReportsToolStripMenuItem";
            this.forecastingReportsToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.forecastingReportsToolStripMenuItem.Text = "Forecasting Reports";
            this.forecastingReportsToolStripMenuItem.Click += new System.EventHandler(this.reports_btn_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.exitToolStripMenuItem.Text = "Log Out";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // available_contracts_btn
            // 
            this.available_contracts_btn.Location = new System.Drawing.Point(47, 98);
            this.available_contracts_btn.Margin = new System.Windows.Forms.Padding(2);
            this.available_contracts_btn.Name = "available_contracts_btn";
            this.available_contracts_btn.Size = new System.Drawing.Size(119, 38);
            this.available_contracts_btn.TabIndex = 2;
            this.available_contracts_btn.Text = "Available Contracts";
            this.available_contracts_btn.UseVisualStyleBackColor = true;
            this.available_contracts_btn.Click += new System.EventHandler(this.available_contracts_btn_Click);
            // 
            // contract_entry_btn
            // 
            this.contract_entry_btn.Location = new System.Drawing.Point(47, 161);
            this.contract_entry_btn.Margin = new System.Windows.Forms.Padding(2);
            this.contract_entry_btn.Name = "contract_entry_btn";
            this.contract_entry_btn.Size = new System.Drawing.Size(119, 38);
            this.contract_entry_btn.TabIndex = 3;
            this.contract_entry_btn.Text = "Contract Entry";
            this.contract_entry_btn.UseVisualStyleBackColor = true;
            this.contract_entry_btn.Click += new System.EventHandler(this.contract_entry_btn_Click);
            // 
            // reports_btn
            // 
            this.reports_btn.Location = new System.Drawing.Point(203, 98);
            this.reports_btn.Margin = new System.Windows.Forms.Padding(2);
            this.reports_btn.Name = "reports_btn";
            this.reports_btn.Size = new System.Drawing.Size(119, 38);
            this.reports_btn.TabIndex = 4;
            this.reports_btn.Text = "Forecasting Reports";
            this.reports_btn.UseVisualStyleBackColor = true;
            this.reports_btn.Click += new System.EventHandler(this.reports_btn_Click);
            // 
            // processes_btn
            // 
            this.processes_btn.Location = new System.Drawing.Point(203, 161);
            this.processes_btn.Name = "processes_btn";
            this.processes_btn.Size = new System.Drawing.Size(119, 38);
            this.processes_btn.TabIndex = 5;
            this.processes_btn.Text = "Process Descriptions";
            this.processes_btn.UseVisualStyleBackColor = true;
            this.processes_btn.Click += new System.EventHandler(this.processes_btn_Click);
            // 
            // btn_ProcessDefinitions
            // 
            this.btn_ProcessDefinitions.Location = new System.Drawing.Point(125, 213);
            this.btn_ProcessDefinitions.Name = "btn_ProcessDefinitions";
            this.btn_ProcessDefinitions.Size = new System.Drawing.Size(119, 38);
            this.btn_ProcessDefinitions.TabIndex = 6;
            this.btn_ProcessDefinitions.Text = "Process Definitions";
            this.btn_ProcessDefinitions.UseVisualStyleBackColor = true;
            this.btn_ProcessDefinitions.Click += new System.EventHandler(this.btn_ProcessDefinitions_Click);
            // 
            // Selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 265);
            this.ControlBox = false;
            this.Controls.Add(this.btn_ProcessDefinitions);
            this.Controls.Add(this.processes_btn);
            this.Controls.Add(this.reports_btn);
            this.Controls.Add(this.contract_entry_btn);
            this.Controls.Add(this.available_contracts_btn);
            this.Controls.Add(this.selection_label);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Selection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Selection_Load);
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
        private System.Windows.Forms.Button processes_btn;
        private System.Windows.Forms.Button btn_ProcessDefinitions;
    }
}