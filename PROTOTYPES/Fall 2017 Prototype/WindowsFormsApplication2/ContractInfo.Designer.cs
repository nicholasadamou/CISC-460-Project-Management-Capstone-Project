namespace WindowsFormsApplication2
{
    partial class ContractInfo
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
            this.contract_num_grpbx = new System.Windows.Forms.GroupBox();
            this.expected_mskdtxtbx = new System.Windows.Forms.MaskedTextBox();
            this.expected_label = new System.Windows.Forms.Label();
            this.entry_date_mskdtxtbx = new System.Windows.Forms.MaskedTextBox();
            this.entry_date_label = new System.Windows.Forms.Label();
            this.due_date_mskdtxtbx = new System.Windows.Forms.MaskedTextBox();
            this.due_date_label = new System.Windows.Forms.Label();
            this.contract_num_textbx = new System.Windows.Forms.TextBox();
            this.contract_num_label = new System.Windows.Forms.Label();
            this.location_grpbx = new System.Windows.Forms.GroupBox();
            this.processes_rchtxtbx = new System.Windows.Forms.RichTextBox();
            this.processes_label = new System.Windows.Forms.Label();
            this.start_location_textbx = new System.Windows.Forms.TextBox();
            this.start_location_label = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectContractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.submitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.select_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.submit_btn = new System.Windows.Forms.Button();
            this.contract_num_grpbx.SuspendLayout();
            this.location_grpbx.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contract Information";
            // 
            // contract_num_grpbx
            // 
            this.contract_num_grpbx.Controls.Add(this.expected_mskdtxtbx);
            this.contract_num_grpbx.Controls.Add(this.expected_label);
            this.contract_num_grpbx.Controls.Add(this.entry_date_mskdtxtbx);
            this.contract_num_grpbx.Controls.Add(this.entry_date_label);
            this.contract_num_grpbx.Controls.Add(this.due_date_mskdtxtbx);
            this.contract_num_grpbx.Controls.Add(this.due_date_label);
            this.contract_num_grpbx.Controls.Add(this.contract_num_textbx);
            this.contract_num_grpbx.Controls.Add(this.contract_num_label);
            this.contract_num_grpbx.Location = new System.Drawing.Point(23, 131);
            this.contract_num_grpbx.Name = "contract_num_grpbx";
            this.contract_num_grpbx.Size = new System.Drawing.Size(454, 186);
            this.contract_num_grpbx.TabIndex = 1;
            this.contract_num_grpbx.TabStop = false;
            // 
            // expected_mskdtxtbx
            // 
            this.expected_mskdtxtbx.Location = new System.Drawing.Point(307, 141);
            this.expected_mskdtxtbx.Mask = "00/00/0000";
            this.expected_mskdtxtbx.Name = "expected_mskdtxtbx";
            this.expected_mskdtxtbx.ReadOnly = true;
            this.expected_mskdtxtbx.Size = new System.Drawing.Size(125, 22);
            this.expected_mskdtxtbx.TabIndex = 7;
            this.expected_mskdtxtbx.ValidatingType = typeof(System.DateTime);
            // 
            // expected_label
            // 
            this.expected_label.AutoSize = true;
            this.expected_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expected_label.Location = new System.Drawing.Point(7, 139);
            this.expected_label.Name = "expected_label";
            this.expected_label.Size = new System.Drawing.Size(244, 25);
            this.expected_label.TabIndex = 6;
            this.expected_label.Text = "Expected Completion Date";
            // 
            // entry_date_mskdtxtbx
            // 
            this.entry_date_mskdtxtbx.Location = new System.Drawing.Point(307, 106);
            this.entry_date_mskdtxtbx.Mask = "00/00/0000";
            this.entry_date_mskdtxtbx.Name = "entry_date_mskdtxtbx";
            this.entry_date_mskdtxtbx.ReadOnly = true;
            this.entry_date_mskdtxtbx.Size = new System.Drawing.Size(125, 22);
            this.entry_date_mskdtxtbx.TabIndex = 5;
            this.entry_date_mskdtxtbx.ValidatingType = typeof(System.DateTime);
            // 
            // entry_date_label
            // 
            this.entry_date_label.AutoSize = true;
            this.entry_date_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entry_date_label.Location = new System.Drawing.Point(7, 103);
            this.entry_date_label.Name = "entry_date_label";
            this.entry_date_label.Size = new System.Drawing.Size(103, 25);
            this.entry_date_label.TabIndex = 4;
            this.entry_date_label.Text = "Entry Date";
            // 
            // due_date_mskdtxtbx
            // 
            this.due_date_mskdtxtbx.Location = new System.Drawing.Point(307, 67);
            this.due_date_mskdtxtbx.Mask = "00/00/0000";
            this.due_date_mskdtxtbx.Name = "due_date_mskdtxtbx";
            this.due_date_mskdtxtbx.ReadOnly = true;
            this.due_date_mskdtxtbx.Size = new System.Drawing.Size(125, 22);
            this.due_date_mskdtxtbx.TabIndex = 3;
            this.due_date_mskdtxtbx.ValidatingType = typeof(System.DateTime);
            // 
            // due_date_label
            // 
            this.due_date_label.AutoSize = true;
            this.due_date_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.due_date_label.Location = new System.Drawing.Point(7, 64);
            this.due_date_label.Name = "due_date_label";
            this.due_date_label.Size = new System.Drawing.Size(94, 25);
            this.due_date_label.TabIndex = 2;
            this.due_date_label.Text = "Due Date";
            // 
            // contract_num_textbx
            // 
            this.contract_num_textbx.Location = new System.Drawing.Point(307, 25);
            this.contract_num_textbx.Name = "contract_num_textbx";
            this.contract_num_textbx.ReadOnly = true;
            this.contract_num_textbx.Size = new System.Drawing.Size(125, 22);
            this.contract_num_textbx.TabIndex = 1;
            // 
            // contract_num_label
            // 
            this.contract_num_label.AutoSize = true;
            this.contract_num_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contract_num_label.Location = new System.Drawing.Point(7, 22);
            this.contract_num_label.Name = "contract_num_label";
            this.contract_num_label.Size = new System.Drawing.Size(160, 25);
            this.contract_num_label.TabIndex = 0;
            this.contract_num_label.Text = "Contract Number";
            // 
            // location_grpbx
            // 
            this.location_grpbx.Controls.Add(this.processes_rchtxtbx);
            this.location_grpbx.Controls.Add(this.processes_label);
            this.location_grpbx.Controls.Add(this.start_location_textbx);
            this.location_grpbx.Controls.Add(this.start_location_label);
            this.location_grpbx.Location = new System.Drawing.Point(532, 131);
            this.location_grpbx.Name = "location_grpbx";
            this.location_grpbx.Size = new System.Drawing.Size(482, 186);
            this.location_grpbx.TabIndex = 2;
            this.location_grpbx.TabStop = false;
            // 
            // processes_rchtxtbx
            // 
            this.processes_rchtxtbx.Location = new System.Drawing.Point(240, 68);
            this.processes_rchtxtbx.Name = "processes_rchtxtbx";
            this.processes_rchtxtbx.ReadOnly = true;
            this.processes_rchtxtbx.Size = new System.Drawing.Size(221, 96);
            this.processes_rchtxtbx.TabIndex = 3;
            this.processes_rchtxtbx.Text = "";
            // 
            // processes_label
            // 
            this.processes_label.AutoSize = true;
            this.processes_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processes_label.Location = new System.Drawing.Point(6, 64);
            this.processes_label.Name = "processes_label";
            this.processes_label.Size = new System.Drawing.Size(202, 25);
            this.processes_label.TabIndex = 2;
            this.processes_label.Text = "Necessary Processes";
            // 
            // start_location_textbx
            // 
            this.start_location_textbx.Location = new System.Drawing.Point(240, 25);
            this.start_location_textbx.Name = "start_location_textbx";
            this.start_location_textbx.ReadOnly = true;
            this.start_location_textbx.Size = new System.Drawing.Size(125, 22);
            this.start_location_textbx.TabIndex = 1;
            // 
            // start_location_label
            // 
            this.start_location_label.AutoSize = true;
            this.start_location_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_location_label.Location = new System.Drawing.Point(6, 22);
            this.start_location_label.Name = "start_location_label";
            this.start_location_label.Size = new System.Drawing.Size(132, 25);
            this.start_location_label.TabIndex = 0;
            this.start_location_label.Text = "Start Location";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1047, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectContractToolStripMenuItem,
            this.printToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.submitToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // selectContractToolStripMenuItem
            // 
            this.selectContractToolStripMenuItem.Name = "selectContractToolStripMenuItem";
            this.selectContractToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.selectContractToolStripMenuItem.Text = "Select Contract";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.updateToolStripMenuItem.Text = "Update";
            // 
            // submitToolStripMenuItem
            // 
            this.submitToolStripMenuItem.Name = "submitToolStripMenuItem";
            this.submitToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.submitToolStripMenuItem.Text = "Submit";
            this.submitToolStripMenuItem.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // select_btn
            // 
            this.select_btn.Location = new System.Drawing.Point(23, 348);
            this.select_btn.Name = "select_btn";
            this.select_btn.Size = new System.Drawing.Size(118, 41);
            this.select_btn.TabIndex = 4;
            this.select_btn.Text = "Select Contract";
            this.select_btn.UseVisualStyleBackColor = true;
            this.select_btn.Click += new System.EventHandler(this.select_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(875, 348);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(118, 41);
            this.exit_btn.TabIndex = 5;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(189, 348);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(118, 41);
            this.update_btn.TabIndex = 6;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // submit_btn
            // 
            this.submit_btn.Location = new System.Drawing.Point(359, 348);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(118, 41);
            this.submit_btn.TabIndex = 7;
            this.submit_btn.Text = "Submit";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // ContractInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 453);
            this.ControlBox = false;
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.select_btn);
            this.Controls.Add(this.location_grpbx);
            this.Controls.Add(this.contract_num_grpbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ContractInfo";
            this.Load += new System.EventHandler(this.ContractInfo_Load);
            this.contract_num_grpbx.ResumeLayout(false);
            this.contract_num_grpbx.PerformLayout();
            this.location_grpbx.ResumeLayout(false);
            this.location_grpbx.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox contract_num_grpbx;
        private System.Windows.Forms.TextBox contract_num_textbx;
        private System.Windows.Forms.Label contract_num_label;
        private System.Windows.Forms.Label due_date_label;
        private System.Windows.Forms.MaskedTextBox expected_mskdtxtbx;
        private System.Windows.Forms.Label expected_label;
        private System.Windows.Forms.MaskedTextBox entry_date_mskdtxtbx;
        private System.Windows.Forms.Label entry_date_label;
        private System.Windows.Forms.MaskedTextBox due_date_mskdtxtbx;
        private System.Windows.Forms.GroupBox location_grpbx;
        private System.Windows.Forms.RichTextBox processes_rchtxtbx;
        private System.Windows.Forms.Label processes_label;
        private System.Windows.Forms.TextBox start_location_textbx;
        private System.Windows.Forms.Label start_location_label;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectContractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button select_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem submitToolStripMenuItem;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button submit_btn;
    }
}