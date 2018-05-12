namespace WindowsFormsApplication2
{
    partial class ForecastingReport
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
            this.forecast_period_label = new System.Windows.Forms.Label();
            this.forecast_period_textbx = new System.Windows.Forms.TextBox();
            this.revenue_label = new System.Windows.Forms.Label();
            this.revenue_mskdtxtbx = new System.Windows.Forms.MaskedTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.submitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projected_contracts_label = new System.Windows.Forms.Label();
            this.projected_contracts_textbx = new System.Windows.Forms.TextBox();
            this.projected_grpbx = new System.Windows.Forms.GroupBox();
            this.ytd_grpbx = new System.Windows.Forms.GroupBox();
            this.ytd_textbx = new System.Windows.Forms.TextBox();
            this.contracts_ytd_label = new System.Windows.Forms.Label();
            this.ytd_revenue_mskdtxtbx = new System.Windows.Forms.MaskedTextBox();
            this.revenue_ytd_label = new System.Windows.Forms.Label();
            this.submit_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.entry_grpbx = new System.Windows.Forms.GroupBox();
            this.entered_by_textbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.entry_textbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.projected_grpbx.SuspendLayout();
            this.ytd_grpbx.SuspendLayout();
            this.entry_grpbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forecasting Report";
            // 
            // forecast_period_label
            // 
            this.forecast_period_label.AutoSize = true;
            this.forecast_period_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecast_period_label.Location = new System.Drawing.Point(4, 73);
            this.forecast_period_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.forecast_period_label.Name = "forecast_period_label";
            this.forecast_period_label.Size = new System.Drawing.Size(142, 20);
            this.forecast_period_label.TabIndex = 1;
            this.forecast_period_label.Text = "Forecasting Period";
            // 
            // forecast_period_textbx
            // 
            this.forecast_period_textbx.Location = new System.Drawing.Point(233, 75);
            this.forecast_period_textbx.Margin = new System.Windows.Forms.Padding(2);
            this.forecast_period_textbx.MaxLength = 32769;
            this.forecast_period_textbx.Name = "forecast_period_textbx";
            this.forecast_period_textbx.Size = new System.Drawing.Size(99, 20);
            this.forecast_period_textbx.TabIndex = 2;
            // 
            // revenue_label
            // 
            this.revenue_label.AutoSize = true;
            this.revenue_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenue_label.Location = new System.Drawing.Point(4, 15);
            this.revenue_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.revenue_label.Name = "revenue_label";
            this.revenue_label.Size = new System.Drawing.Size(144, 20);
            this.revenue_label.TabIndex = 3;
            this.revenue_label.Text = "Projected Revenue";
            // 
            // revenue_mskdtxtbx
            // 
            this.revenue_mskdtxtbx.Location = new System.Drawing.Point(233, 17);
            this.revenue_mskdtxtbx.Margin = new System.Windows.Forms.Padding(2);
            this.revenue_mskdtxtbx.Mask = "0000000000.00";
            this.revenue_mskdtxtbx.Name = "revenue_mskdtxtbx";
            this.revenue_mskdtxtbx.Size = new System.Drawing.Size(99, 20);
            this.revenue_mskdtxtbx.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(413, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submitToolStripMenuItem,
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // submitToolStripMenuItem
            // 
            this.submitToolStripMenuItem.Name = "submitToolStripMenuItem";
            this.submitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.submitToolStripMenuItem.Text = "Submit";
            this.submitToolStripMenuItem.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
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
            // projected_contracts_label
            // 
            this.projected_contracts_label.AutoSize = true;
            this.projected_contracts_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projected_contracts_label.Location = new System.Drawing.Point(4, 53);
            this.projected_contracts_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.projected_contracts_label.Name = "projected_contracts_label";
            this.projected_contracts_label.Size = new System.Drawing.Size(227, 20);
            this.projected_contracts_label.TabIndex = 6;
            this.projected_contracts_label.Text = "Number of Projected Contracts";
            // 
            // projected_contracts_textbx
            // 
            this.projected_contracts_textbx.Location = new System.Drawing.Point(233, 55);
            this.projected_contracts_textbx.Margin = new System.Windows.Forms.Padding(2);
            this.projected_contracts_textbx.Name = "projected_contracts_textbx";
            this.projected_contracts_textbx.Size = new System.Drawing.Size(99, 20);
            this.projected_contracts_textbx.TabIndex = 7;
            // 
            // projected_grpbx
            // 
            this.projected_grpbx.Controls.Add(this.revenue_label);
            this.projected_grpbx.Controls.Add(this.projected_contracts_textbx);
            this.projected_grpbx.Controls.Add(this.revenue_mskdtxtbx);
            this.projected_grpbx.Controls.Add(this.projected_contracts_label);
            this.projected_grpbx.Location = new System.Drawing.Point(5, 281);
            this.projected_grpbx.Margin = new System.Windows.Forms.Padding(2);
            this.projected_grpbx.Name = "projected_grpbx";
            this.projected_grpbx.Padding = new System.Windows.Forms.Padding(2);
            this.projected_grpbx.Size = new System.Drawing.Size(361, 81);
            this.projected_grpbx.TabIndex = 8;
            this.projected_grpbx.TabStop = false;
            // 
            // ytd_grpbx
            // 
            this.ytd_grpbx.Controls.Add(this.ytd_textbx);
            this.ytd_grpbx.Controls.Add(this.contracts_ytd_label);
            this.ytd_grpbx.Controls.Add(this.ytd_revenue_mskdtxtbx);
            this.ytd_grpbx.Controls.Add(this.revenue_ytd_label);
            this.ytd_grpbx.Location = new System.Drawing.Point(5, 196);
            this.ytd_grpbx.Margin = new System.Windows.Forms.Padding(2);
            this.ytd_grpbx.Name = "ytd_grpbx";
            this.ytd_grpbx.Padding = new System.Windows.Forms.Padding(2);
            this.ytd_grpbx.Size = new System.Drawing.Size(361, 81);
            this.ytd_grpbx.TabIndex = 9;
            this.ytd_grpbx.TabStop = false;
            // 
            // ytd_textbx
            // 
            this.ytd_textbx.Location = new System.Drawing.Point(233, 58);
            this.ytd_textbx.Margin = new System.Windows.Forms.Padding(2);
            this.ytd_textbx.Name = "ytd_textbx";
            this.ytd_textbx.Size = new System.Drawing.Size(99, 20);
            this.ytd_textbx.TabIndex = 3;
            // 
            // contracts_ytd_label
            // 
            this.contracts_ytd_label.AutoSize = true;
            this.contracts_ytd_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contracts_ytd_label.Location = new System.Drawing.Point(4, 58);
            this.contracts_ytd_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contracts_ytd_label.Name = "contracts_ytd_label";
            this.contracts_ytd_label.Size = new System.Drawing.Size(195, 20);
            this.contracts_ytd_label.TabIndex = 2;
            this.contracts_ytd_label.Text = "Number Of Contracts YTD";
            // 
            // ytd_revenue_mskdtxtbx
            // 
            this.ytd_revenue_mskdtxtbx.Location = new System.Drawing.Point(233, 15);
            this.ytd_revenue_mskdtxtbx.Margin = new System.Windows.Forms.Padding(2);
            this.ytd_revenue_mskdtxtbx.Mask = "000000000.00";
            this.ytd_revenue_mskdtxtbx.Name = "ytd_revenue_mskdtxtbx";
            this.ytd_revenue_mskdtxtbx.Size = new System.Drawing.Size(100, 20);
            this.ytd_revenue_mskdtxtbx.TabIndex = 1;
            // 
            // revenue_ytd_label
            // 
            this.revenue_ytd_label.AutoSize = true;
            this.revenue_ytd_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenue_ytd_label.Location = new System.Drawing.Point(4, 15);
            this.revenue_ytd_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.revenue_ytd_label.Name = "revenue_ytd_label";
            this.revenue_ytd_label.Size = new System.Drawing.Size(109, 20);
            this.revenue_ytd_label.TabIndex = 0;
            this.revenue_ytd_label.Text = "YTD Revenue";
            // 
            // submit_btn
            // 
            this.submit_btn.Location = new System.Drawing.Point(14, 389);
            this.submit_btn.Margin = new System.Windows.Forms.Padding(2);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(56, 28);
            this.submit_btn.TabIndex = 10;
            this.submit_btn.Text = "Submit";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(86, 390);
            this.exit_btn.Margin = new System.Windows.Forms.Padding(2);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(56, 28);
            this.exit_btn.TabIndex = 11;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // entry_grpbx
            // 
            this.entry_grpbx.Controls.Add(this.entered_by_textbx);
            this.entry_grpbx.Controls.Add(this.label3);
            this.entry_grpbx.Controls.Add(this.entry_textbx);
            this.entry_grpbx.Controls.Add(this.label2);
            this.entry_grpbx.Controls.Add(this.forecast_period_textbx);
            this.entry_grpbx.Controls.Add(this.forecast_period_label);
            this.entry_grpbx.Location = new System.Drawing.Point(5, 91);
            this.entry_grpbx.Name = "entry_grpbx";
            this.entry_grpbx.Size = new System.Drawing.Size(361, 100);
            this.entry_grpbx.TabIndex = 12;
            this.entry_grpbx.TabStop = false;
            // 
            // entered_by_textbx
            // 
            this.entered_by_textbx.Location = new System.Drawing.Point(233, 16);
            this.entered_by_textbx.Margin = new System.Windows.Forms.Padding(2);
            this.entered_by_textbx.MaxLength = 32769;
            this.entered_by_textbx.Name = "entered_by_textbx";
            this.entered_by_textbx.Size = new System.Drawing.Size(99, 20);
            this.entered_by_textbx.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Entered By";
            // 
            // entry_textbx
            // 
            this.entry_textbx.Location = new System.Drawing.Point(234, 44);
            this.entry_textbx.Margin = new System.Windows.Forms.Padding(2);
            this.entry_textbx.MaxLength = 32769;
            this.entry_textbx.Name = "entry_textbx";
            this.entry_textbx.Size = new System.Drawing.Size(99, 20);
            this.entry_textbx.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Entry Date";
            // 
            // ForecastingReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 445);
            this.ControlBox = false;
            this.Controls.Add(this.entry_grpbx);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.ytd_grpbx);
            this.Controls.Add(this.projected_grpbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ForecastingReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.projected_grpbx.ResumeLayout(false);
            this.projected_grpbx.PerformLayout();
            this.ytd_grpbx.ResumeLayout(false);
            this.ytd_grpbx.PerformLayout();
            this.entry_grpbx.ResumeLayout(false);
            this.entry_grpbx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label forecast_period_label;
        private System.Windows.Forms.TextBox forecast_period_textbx;
        private System.Windows.Forms.Label revenue_label;
        private System.Windows.Forms.MaskedTextBox revenue_mskdtxtbx;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem submitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label projected_contracts_label;
        private System.Windows.Forms.TextBox projected_contracts_textbx;
        private System.Windows.Forms.GroupBox projected_grpbx;
        private System.Windows.Forms.GroupBox ytd_grpbx;
        private System.Windows.Forms.TextBox ytd_textbx;
        private System.Windows.Forms.Label contracts_ytd_label;
        private System.Windows.Forms.MaskedTextBox ytd_revenue_mskdtxtbx;
        private System.Windows.Forms.Label revenue_ytd_label;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.GroupBox entry_grpbx;
        private System.Windows.Forms.TextBox entered_by_textbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox entry_textbx;
        private System.Windows.Forms.Label label2;
    }
}