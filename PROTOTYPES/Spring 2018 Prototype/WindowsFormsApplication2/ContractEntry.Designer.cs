namespace WindowsFormsApplication2
{
    partial class ContractEntry
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
            this.contract_entry_label = new System.Windows.Forms.Label();
            this.contract_num_label = new System.Windows.Forms.Label();
            this.due_date_label = new System.Windows.Forms.Label();
            this.entry_date_label = new System.Windows.Forms.Label();
            this.expected_label = new System.Windows.Forms.Label();
            this.start_location_label = new System.Windows.Forms.Label();
            this.processes_label = new System.Windows.Forms.Label();
            this.necessary_richtxtbx = new System.Windows.Forms.RichTextBox();
            this.contract_num_grpbx = new System.Windows.Forms.GroupBox();
            this.entry_date = new System.Windows.Forms.DateTimePicker();
            this.due_date = new System.Windows.Forms.DateTimePicker();
            this.expected_completion_date = new System.Windows.Forms.DateTimePicker();
            this.contract_number_mskedtxtbx = new System.Windows.Forms.MaskedTextBox();
            this.location_grpbx = new System.Windows.Forms.GroupBox();
            this.start_location_mskedtxtbx = new System.Windows.Forms.MaskedTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.submitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exit_btn = new System.Windows.Forms.Button();
            this.submit_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.current_location_mskedtxtbx = new System.Windows.Forms.MaskedTextBox();
            this.contract_num_grpbx.SuspendLayout();
            this.location_grpbx.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contract_entry_label
            // 
            this.contract_entry_label.AutoSize = true;
            this.contract_entry_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contract_entry_label.Location = new System.Drawing.Point(116, 43);
            this.contract_entry_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contract_entry_label.Name = "contract_entry_label";
            this.contract_entry_label.Size = new System.Drawing.Size(205, 36);
            this.contract_entry_label.TabIndex = 0;
            this.contract_entry_label.Text = "Contract Entry";
            // 
            // contract_num_label
            // 
            this.contract_num_label.AutoSize = true;
            this.contract_num_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contract_num_label.Location = new System.Drawing.Point(5, 26);
            this.contract_num_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contract_num_label.Name = "contract_num_label";
            this.contract_num_label.Size = new System.Drawing.Size(130, 20);
            this.contract_num_label.TabIndex = 1;
            this.contract_num_label.Text = "Contract Number";
            // 
            // due_date_label
            // 
            this.due_date_label.AutoSize = true;
            this.due_date_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.due_date_label.Location = new System.Drawing.Point(5, 57);
            this.due_date_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.due_date_label.Name = "due_date_label";
            this.due_date_label.Size = new System.Drawing.Size(78, 20);
            this.due_date_label.TabIndex = 2;
            this.due_date_label.Text = "Due Date";
            // 
            // entry_date_label
            // 
            this.entry_date_label.AutoSize = true;
            this.entry_date_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entry_date_label.Location = new System.Drawing.Point(5, 117);
            this.entry_date_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.entry_date_label.Name = "entry_date_label";
            this.entry_date_label.Size = new System.Drawing.Size(85, 20);
            this.entry_date_label.TabIndex = 3;
            this.entry_date_label.Text = "Entry Date";
            // 
            // expected_label
            // 
            this.expected_label.AutoSize = true;
            this.expected_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expected_label.Location = new System.Drawing.Point(5, 88);
            this.expected_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.expected_label.Name = "expected_label";
            this.expected_label.Size = new System.Drawing.Size(199, 20);
            this.expected_label.TabIndex = 7;
            this.expected_label.Text = "Expected Completion Date";
            // 
            // start_location_label
            // 
            this.start_location_label.AutoSize = true;
            this.start_location_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_location_label.Location = new System.Drawing.Point(4, 15);
            this.start_location_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.start_location_label.Name = "start_location_label";
            this.start_location_label.Size = new System.Drawing.Size(109, 20);
            this.start_location_label.TabIndex = 9;
            this.start_location_label.Text = "Start Location";
            // 
            // processes_label
            // 
            this.processes_label.AutoSize = true;
            this.processes_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processes_label.Location = new System.Drawing.Point(5, 88);
            this.processes_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.processes_label.Name = "processes_label";
            this.processes_label.Size = new System.Drawing.Size(161, 20);
            this.processes_label.TabIndex = 11;
            this.processes_label.Text = "Necessary Processes";
            // 
            // necessary_richtxtbx
            // 
            this.necessary_richtxtbx.Location = new System.Drawing.Point(193, 90);
            this.necessary_richtxtbx.Margin = new System.Windows.Forms.Padding(2);
            this.necessary_richtxtbx.Name = "necessary_richtxtbx";
            this.necessary_richtxtbx.Size = new System.Drawing.Size(166, 61);
            this.necessary_richtxtbx.TabIndex = 12;
            this.necessary_richtxtbx.Text = "";
            // 
            // contract_num_grpbx
            // 
            this.contract_num_grpbx.Controls.Add(this.entry_date);
            this.contract_num_grpbx.Controls.Add(this.due_date);
            this.contract_num_grpbx.Controls.Add(this.expected_completion_date);
            this.contract_num_grpbx.Controls.Add(this.contract_number_mskedtxtbx);
            this.contract_num_grpbx.Controls.Add(this.contract_num_label);
            this.contract_num_grpbx.Controls.Add(this.due_date_label);
            this.contract_num_grpbx.Controls.Add(this.entry_date_label);
            this.contract_num_grpbx.Controls.Add(this.expected_label);
            this.contract_num_grpbx.Location = new System.Drawing.Point(27, 101);
            this.contract_num_grpbx.Margin = new System.Windows.Forms.Padding(2);
            this.contract_num_grpbx.Name = "contract_num_grpbx";
            this.contract_num_grpbx.Padding = new System.Windows.Forms.Padding(2);
            this.contract_num_grpbx.Size = new System.Drawing.Size(413, 167);
            this.contract_num_grpbx.TabIndex = 16;
            this.contract_num_grpbx.TabStop = false;
            // 
            // entry_date
            // 
            this.entry_date.Enabled = false;
            this.entry_date.Location = new System.Drawing.Point(204, 117);
            this.entry_date.MaxDate = new System.DateTime(2018, 4, 27, 0, 0, 0, 0);
            this.entry_date.MinDate = new System.DateTime(2018, 4, 27, 0, 0, 0, 0);
            this.entry_date.Name = "entry_date";
            this.entry_date.Size = new System.Drawing.Size(200, 20);
            this.entry_date.TabIndex = 19;
            this.entry_date.Value = new System.DateTime(2018, 4, 27, 0, 0, 0, 0);
            // 
            // due_date
            // 
            this.due_date.Location = new System.Drawing.Point(204, 56);
            this.due_date.Name = "due_date";
            this.due_date.Size = new System.Drawing.Size(200, 20);
            this.due_date.TabIndex = 18;
            // 
            // expected_completion_date
            // 
            this.expected_completion_date.Location = new System.Drawing.Point(205, 88);
            this.expected_completion_date.Name = "expected_completion_date";
            this.expected_completion_date.Size = new System.Drawing.Size(200, 20);
            this.expected_completion_date.TabIndex = 17;
            // 
            // contract_number_mskedtxtbx
            // 
            this.contract_number_mskedtxtbx.Location = new System.Drawing.Point(204, 28);
            this.contract_number_mskedtxtbx.Margin = new System.Windows.Forms.Padding(2);
            this.contract_number_mskedtxtbx.Mask = "000000000";
            this.contract_number_mskedtxtbx.Name = "contract_number_mskedtxtbx";
            this.contract_number_mskedtxtbx.Size = new System.Drawing.Size(103, 20);
            this.contract_number_mskedtxtbx.TabIndex = 16;
            // 
            // location_grpbx
            // 
            this.location_grpbx.Controls.Add(this.current_location_mskedtxtbx);
            this.location_grpbx.Controls.Add(this.label1);
            this.location_grpbx.Controls.Add(this.start_location_mskedtxtbx);
            this.location_grpbx.Controls.Add(this.start_location_label);
            this.location_grpbx.Controls.Add(this.necessary_richtxtbx);
            this.location_grpbx.Controls.Add(this.processes_label);
            this.location_grpbx.Location = new System.Drawing.Point(27, 272);
            this.location_grpbx.Margin = new System.Windows.Forms.Padding(2);
            this.location_grpbx.Name = "location_grpbx";
            this.location_grpbx.Padding = new System.Windows.Forms.Padding(2);
            this.location_grpbx.Size = new System.Drawing.Size(365, 194);
            this.location_grpbx.TabIndex = 17;
            this.location_grpbx.TabStop = false;
            // 
            // start_location_mskedtxtbx
            // 
            this.start_location_mskedtxtbx.Location = new System.Drawing.Point(193, 17);
            this.start_location_mskedtxtbx.Margin = new System.Windows.Forms.Padding(2);
            this.start_location_mskedtxtbx.Mask = "000";
            this.start_location_mskedtxtbx.Name = "start_location_mskedtxtbx";
            this.start_location_mskedtxtbx.Size = new System.Drawing.Size(26, 20);
            this.start_location_mskedtxtbx.TabIndex = 13;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(465, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submitToolStripMenuItem,
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
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(231, 493);
            this.exit_btn.Margin = new System.Windows.Forms.Padding(2);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(68, 35);
            this.exit_btn.TabIndex = 19;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // submit_btn
            // 
            this.submit_btn.Location = new System.Drawing.Point(134, 493);
            this.submit_btn.Margin = new System.Windows.Forms.Padding(2);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(68, 35);
            this.submit_btn.TabIndex = 20;
            this.submit_btn.Text = "Submit";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Current Location";
            // 
            // current_location_mskedtxtbx
            // 
            this.current_location_mskedtxtbx.Location = new System.Drawing.Point(193, 51);
            this.current_location_mskedtxtbx.Mask = "000";
            this.current_location_mskedtxtbx.Name = "current_location_mskedtxtbx";
            this.current_location_mskedtxtbx.Size = new System.Drawing.Size(26, 20);
            this.current_location_mskedtxtbx.TabIndex = 15;
            // 
            // ContractEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 557);
            this.ControlBox = false;
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.location_grpbx);
            this.Controls.Add(this.contract_num_grpbx);
            this.Controls.Add(this.contract_entry_label);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ContractEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ContractEntry_Load);
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

        private System.Windows.Forms.Label contract_entry_label;
        private System.Windows.Forms.Label contract_num_label;
        private System.Windows.Forms.Label due_date_label;
        private System.Windows.Forms.Label entry_date_label;
        private System.Windows.Forms.Label expected_label;
        private System.Windows.Forms.Label start_location_label;
        private System.Windows.Forms.Label processes_label;
        private System.Windows.Forms.RichTextBox necessary_richtxtbx;
        private System.Windows.Forms.GroupBox contract_num_grpbx;
        private System.Windows.Forms.GroupBox location_grpbx;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem submitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.MaskedTextBox contract_number_mskedtxtbx;
        private System.Windows.Forms.MaskedTextBox start_location_mskedtxtbx;
        private System.Windows.Forms.DateTimePicker expected_completion_date;
        private System.Windows.Forms.DateTimePicker due_date;
        private System.Windows.Forms.DateTimePicker entry_date;
        private System.Windows.Forms.MaskedTextBox current_location_mskedtxtbx;
        private System.Windows.Forms.Label label1;
    }
}