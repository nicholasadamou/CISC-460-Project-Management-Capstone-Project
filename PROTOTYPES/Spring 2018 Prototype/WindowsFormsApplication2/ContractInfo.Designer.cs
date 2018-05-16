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
            this.dueDate_dtetimepckr = new System.Windows.Forms.DateTimePicker();
            this.entryDate_dtetimepckr = new System.Windows.Forms.DateTimePicker();
            this.expComplDate_dtetimepckr = new System.Windows.Forms.DateTimePicker();
            this.expected_label = new System.Windows.Forms.Label();
            this.entry_date_label = new System.Windows.Forms.Label();
            this.due_date_label = new System.Windows.Forms.Label();
            this.contract_num_textbx = new System.Windows.Forms.TextBox();
            this.contract_num_label = new System.Windows.Forms.Label();
            this.location_grpbx = new System.Windows.Forms.GroupBox();
            this.currentLocationMsked = new System.Windows.Forms.MaskedTextBox();
            this.startLocation_textbx = new System.Windows.Forms.TextBox();
            this.currentlocation_lbl = new System.Windows.Forms.Label();
            this.processes_rchtxtbx = new System.Windows.Forms.RichTextBox();
            this.processes_label = new System.Windows.Forms.Label();
            this.start_location_label = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectContractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.submitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.select_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(436, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contract Information";
            // 
            // contract_num_grpbx
            // 
            this.contract_num_grpbx.Controls.Add(this.dueDate_dtetimepckr);
            this.contract_num_grpbx.Controls.Add(this.entryDate_dtetimepckr);
            this.contract_num_grpbx.Controls.Add(this.expComplDate_dtetimepckr);
            this.contract_num_grpbx.Controls.Add(this.expected_label);
            this.contract_num_grpbx.Controls.Add(this.entry_date_label);
            this.contract_num_grpbx.Controls.Add(this.due_date_label);
            this.contract_num_grpbx.Controls.Add(this.contract_num_textbx);
            this.contract_num_grpbx.Controls.Add(this.contract_num_label);
            this.contract_num_grpbx.Location = new System.Drawing.Point(42, 135);
            this.contract_num_grpbx.Margin = new System.Windows.Forms.Padding(2);
            this.contract_num_grpbx.Name = "contract_num_grpbx";
            this.contract_num_grpbx.Padding = new System.Windows.Forms.Padding(2);
            this.contract_num_grpbx.Size = new System.Drawing.Size(446, 151);
            this.contract_num_grpbx.TabIndex = 1;
            this.contract_num_grpbx.TabStop = false;
            // 
            // dueDate_dtetimepckr
            // 
            this.dueDate_dtetimepckr.Enabled = false;
            this.dueDate_dtetimepckr.Location = new System.Drawing.Point(230, 52);
            this.dueDate_dtetimepckr.Name = "dueDate_dtetimepckr";
            this.dueDate_dtetimepckr.Size = new System.Drawing.Size(200, 20);
            this.dueDate_dtetimepckr.TabIndex = 9;
            // 
            // entryDate_dtetimepckr
            // 
            this.entryDate_dtetimepckr.Enabled = false;
            this.entryDate_dtetimepckr.Location = new System.Drawing.Point(230, 83);
            this.entryDate_dtetimepckr.Name = "entryDate_dtetimepckr";
            this.entryDate_dtetimepckr.Size = new System.Drawing.Size(200, 20);
            this.entryDate_dtetimepckr.TabIndex = 8;
            // 
            // expComplDate_dtetimepckr
            // 
            this.expComplDate_dtetimepckr.Enabled = false;
            this.expComplDate_dtetimepckr.Location = new System.Drawing.Point(230, 113);
            this.expComplDate_dtetimepckr.Name = "expComplDate_dtetimepckr";
            this.expComplDate_dtetimepckr.Size = new System.Drawing.Size(200, 20);
            this.expComplDate_dtetimepckr.TabIndex = 7;
            // 
            // expected_label
            // 
            this.expected_label.AutoSize = true;
            this.expected_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expected_label.Location = new System.Drawing.Point(5, 113);
            this.expected_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.expected_label.Name = "expected_label";
            this.expected_label.Size = new System.Drawing.Size(199, 20);
            this.expected_label.TabIndex = 6;
            this.expected_label.Text = "Expected Completion Date";
            // 
            // entry_date_label
            // 
            this.entry_date_label.AutoSize = true;
            this.entry_date_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entry_date_label.Location = new System.Drawing.Point(5, 84);
            this.entry_date_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.entry_date_label.Name = "entry_date_label";
            this.entry_date_label.Size = new System.Drawing.Size(85, 20);
            this.entry_date_label.TabIndex = 4;
            this.entry_date_label.Text = "Entry Date";
            // 
            // due_date_label
            // 
            this.due_date_label.AutoSize = true;
            this.due_date_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.due_date_label.Location = new System.Drawing.Point(5, 52);
            this.due_date_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.due_date_label.Name = "due_date_label";
            this.due_date_label.Size = new System.Drawing.Size(78, 20);
            this.due_date_label.TabIndex = 2;
            this.due_date_label.Text = "Due Date";
            // 
            // contract_num_textbx
            // 
            this.contract_num_textbx.Enabled = false;
            this.contract_num_textbx.Location = new System.Drawing.Point(230, 20);
            this.contract_num_textbx.Margin = new System.Windows.Forms.Padding(2);
            this.contract_num_textbx.Name = "contract_num_textbx";
            this.contract_num_textbx.ReadOnly = true;
            this.contract_num_textbx.Size = new System.Drawing.Size(95, 20);
            this.contract_num_textbx.TabIndex = 1;
            // 
            // contract_num_label
            // 
            this.contract_num_label.AutoSize = true;
            this.contract_num_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contract_num_label.Location = new System.Drawing.Point(5, 18);
            this.contract_num_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contract_num_label.Name = "contract_num_label";
            this.contract_num_label.Size = new System.Drawing.Size(130, 20);
            this.contract_num_label.TabIndex = 0;
            this.contract_num_label.Text = "Contract Number";
            // 
            // location_grpbx
            // 
            this.location_grpbx.Controls.Add(this.currentLocationMsked);
            this.location_grpbx.Controls.Add(this.startLocation_textbx);
            this.location_grpbx.Controls.Add(this.currentlocation_lbl);
            this.location_grpbx.Controls.Add(this.processes_rchtxtbx);
            this.location_grpbx.Controls.Add(this.processes_label);
            this.location_grpbx.Controls.Add(this.start_location_label);
            this.location_grpbx.Location = new System.Drawing.Point(510, 135);
            this.location_grpbx.Margin = new System.Windows.Forms.Padding(2);
            this.location_grpbx.Name = "location_grpbx";
            this.location_grpbx.Padding = new System.Windows.Forms.Padding(2);
            this.location_grpbx.Size = new System.Drawing.Size(568, 183);
            this.location_grpbx.TabIndex = 2;
            this.location_grpbx.TabStop = false;
            // 
            // currentLocationMsked
            // 
            this.currentLocationMsked.Enabled = false;
            this.currentLocationMsked.Location = new System.Drawing.Point(180, 54);
            this.currentLocationMsked.Mask = "000";
            this.currentLocationMsked.Name = "currentLocationMsked";
            this.currentLocationMsked.Size = new System.Drawing.Size(95, 20);
            this.currentLocationMsked.TabIndex = 6;
            // 
            // startLocation_textbx
            // 
            this.startLocation_textbx.Enabled = false;
            this.startLocation_textbx.Location = new System.Drawing.Point(180, 20);
            this.startLocation_textbx.Margin = new System.Windows.Forms.Padding(2);
            this.startLocation_textbx.Name = "startLocation_textbx";
            this.startLocation_textbx.ReadOnly = true;
            this.startLocation_textbx.Size = new System.Drawing.Size(95, 20);
            this.startLocation_textbx.TabIndex = 5;
            // 
            // currentlocation_lbl
            // 
            this.currentlocation_lbl.AutoSize = true;
            this.currentlocation_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentlocation_lbl.Location = new System.Drawing.Point(4, 55);
            this.currentlocation_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentlocation_lbl.Name = "currentlocation_lbl";
            this.currentlocation_lbl.Size = new System.Drawing.Size(127, 20);
            this.currentlocation_lbl.TabIndex = 4;
            this.currentlocation_lbl.Text = "Current Location";
            // 
            // processes_rchtxtbx
            // 
            this.processes_rchtxtbx.Enabled = false;
            this.processes_rchtxtbx.Location = new System.Drawing.Point(180, 90);
            this.processes_rchtxtbx.Margin = new System.Windows.Forms.Padding(2);
            this.processes_rchtxtbx.Name = "processes_rchtxtbx";
            this.processes_rchtxtbx.Size = new System.Drawing.Size(364, 79);
            this.processes_rchtxtbx.TabIndex = 3;
            this.processes_rchtxtbx.Text = "";
            // 
            // processes_label
            // 
            this.processes_label.AutoSize = true;
            this.processes_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processes_label.Location = new System.Drawing.Point(4, 87);
            this.processes_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.processes_label.Name = "processes_label";
            this.processes_label.Size = new System.Drawing.Size(161, 20);
            this.processes_label.TabIndex = 2;
            this.processes_label.Text = "Necessary Processes";
            // 
            // start_location_label
            // 
            this.start_location_label.AutoSize = true;
            this.start_location_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_location_label.Location = new System.Drawing.Point(4, 18);
            this.start_location_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.start_location_label.Name = "start_location_label";
            this.start_location_label.Size = new System.Drawing.Size(109, 20);
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1106, 24);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // selectContractToolStripMenuItem
            // 
            this.selectContractToolStripMenuItem.Name = "selectContractToolStripMenuItem";
            this.selectContractToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.selectContractToolStripMenuItem.Text = "Select Contract";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.updateToolStripMenuItem.Text = "Update";
            // 
            // submitToolStripMenuItem
            // 
            this.submitToolStripMenuItem.Name = "submitToolStripMenuItem";
            this.submitToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.submitToolStripMenuItem.Text = "Submit";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exit_btn_Click_1);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // select_btn
            // 
            this.select_btn.Location = new System.Drawing.Point(42, 339);
            this.select_btn.Margin = new System.Windows.Forms.Padding(2);
            this.select_btn.Name = "select_btn";
            this.select_btn.Size = new System.Drawing.Size(88, 33);
            this.select_btn.TabIndex = 4;
            this.select_btn.Text = "Select Contract";
            this.select_btn.UseVisualStyleBackColor = true;
            this.select_btn.Click += new System.EventHandler(this.select_btn_Click_1);
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(990, 339);
            this.exit_btn.Margin = new System.Windows.Forms.Padding(2);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(88, 33);
            this.exit_btn.TabIndex = 5;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click_1);
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(167, 339);
            this.update_btn.Margin = new System.Windows.Forms.Padding(2);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(88, 33);
            this.update_btn.TabIndex = 6;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click_1);
            // 
            // submit_btn
            // 
            this.submit_btn.Enabled = false;
            this.submit_btn.Location = new System.Drawing.Point(294, 339);
            this.submit_btn.Margin = new System.Windows.Forms.Padding(2);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(88, 33);
            this.submit_btn.TabIndex = 7;
            this.submit_btn.Text = "Submit";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click_1);
            // 
            // ContractInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 397);
            this.ControlBox = false;
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.select_btn);
            this.Controls.Add(this.location_grpbx);
            this.Controls.Add(this.contract_num_grpbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ContractInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label expected_label;
        private System.Windows.Forms.Label entry_date_label;
        private System.Windows.Forms.GroupBox location_grpbx;
        private System.Windows.Forms.RichTextBox processes_rchtxtbx;
        private System.Windows.Forms.Label processes_label;
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
        private System.Windows.Forms.TextBox startLocation_textbx;
        private System.Windows.Forms.Label currentlocation_lbl;
        private System.Windows.Forms.DateTimePicker dueDate_dtetimepckr;
        private System.Windows.Forms.DateTimePicker entryDate_dtetimepckr;
        private System.Windows.Forms.DateTimePicker expComplDate_dtetimepckr;
        private System.Windows.Forms.MaskedTextBox currentLocationMsked;
    }
}