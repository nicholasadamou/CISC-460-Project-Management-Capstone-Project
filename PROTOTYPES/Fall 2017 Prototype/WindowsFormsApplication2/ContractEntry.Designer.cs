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
            this.due_date_msked = new System.Windows.Forms.MaskedTextBox();
            this.entry_date_msked = new System.Windows.Forms.MaskedTextBox();
            this.expected_completion_msked = new System.Windows.Forms.MaskedTextBox();
            this.contract_num_grpbx = new System.Windows.Forms.GroupBox();
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
            this.contract_num_grpbx.SuspendLayout();
            this.location_grpbx.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contract_entry_label
            // 
            this.contract_entry_label.AutoSize = true;
            this.contract_entry_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contract_entry_label.Location = new System.Drawing.Point(154, 9);
            this.contract_entry_label.Name = "contract_entry_label";
            this.contract_entry_label.Size = new System.Drawing.Size(263, 44);
            this.contract_entry_label.TabIndex = 0;
            this.contract_entry_label.Text = "Contract Entry";
            // 
            // contract_num_label
            // 
            this.contract_num_label.AutoSize = true;
            this.contract_num_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contract_num_label.Location = new System.Drawing.Point(-5, 32);
            this.contract_num_label.Name = "contract_num_label";
            this.contract_num_label.Size = new System.Drawing.Size(160, 25);
            this.contract_num_label.TabIndex = 1;
            this.contract_num_label.Text = "Contract Number";
            // 
            // due_date_label
            // 
            this.due_date_label.AutoSize = true;
            this.due_date_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.due_date_label.Location = new System.Drawing.Point(-5, 70);
            this.due_date_label.Name = "due_date_label";
            this.due_date_label.Size = new System.Drawing.Size(94, 25);
            this.due_date_label.TabIndex = 2;
            this.due_date_label.Text = "Due Date";
            // 
            // entry_date_label
            // 
            this.entry_date_label.AutoSize = true;
            this.entry_date_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entry_date_label.Location = new System.Drawing.Point(-5, 144);
            this.entry_date_label.Name = "entry_date_label";
            this.entry_date_label.Size = new System.Drawing.Size(103, 25);
            this.entry_date_label.TabIndex = 3;
            this.entry_date_label.Text = "Entry Date";
            // 
            // expected_label
            // 
            this.expected_label.AutoSize = true;
            this.expected_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expected_label.Location = new System.Drawing.Point(-5, 108);
            this.expected_label.Name = "expected_label";
            this.expected_label.Size = new System.Drawing.Size(244, 25);
            this.expected_label.TabIndex = 7;
            this.expected_label.Text = "Expected Completion Date";
            // 
            // start_location_label
            // 
            this.start_location_label.AutoSize = true;
            this.start_location_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_location_label.Location = new System.Drawing.Point(6, 18);
            this.start_location_label.Name = "start_location_label";
            this.start_location_label.Size = new System.Drawing.Size(132, 25);
            this.start_location_label.TabIndex = 9;
            this.start_location_label.Text = "Start Location";
            // 
            // processes_label
            // 
            this.processes_label.AutoSize = true;
            this.processes_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processes_label.Location = new System.Drawing.Point(6, 61);
            this.processes_label.Name = "processes_label";
            this.processes_label.Size = new System.Drawing.Size(202, 25);
            this.processes_label.TabIndex = 11;
            this.processes_label.Text = "Necessary Processes";
            // 
            // necessary_richtxtbx
            // 
            this.necessary_richtxtbx.Location = new System.Drawing.Point(235, 65);
            this.necessary_richtxtbx.Name = "necessary_richtxtbx";
            this.necessary_richtxtbx.Size = new System.Drawing.Size(220, 74);
            this.necessary_richtxtbx.TabIndex = 12;
            this.necessary_richtxtbx.Text = "";
            // 
            // due_date_msked
            // 
            this.due_date_msked.Location = new System.Drawing.Point(257, 74);
            this.due_date_msked.Mask = "00/00/0000";
            this.due_date_msked.Name = "due_date_msked";
            this.due_date_msked.Size = new System.Drawing.Size(136, 22);
            this.due_date_msked.TabIndex = 13;
            this.due_date_msked.ValidatingType = typeof(System.DateTime);
            // 
            // entry_date_msked
            // 
            this.entry_date_msked.Location = new System.Drawing.Point(257, 147);
            this.entry_date_msked.Mask = "00/00/0000";
            this.entry_date_msked.Name = "entry_date_msked";
            this.entry_date_msked.ReadOnly = true;
            this.entry_date_msked.Size = new System.Drawing.Size(136, 22);
            this.entry_date_msked.TabIndex = 14;
            this.entry_date_msked.ValidatingType = typeof(System.DateTime);
            // 
            // expected_completion_msked
            // 
            this.expected_completion_msked.Location = new System.Drawing.Point(257, 112);
            this.expected_completion_msked.Mask = "00/00/0000";
            this.expected_completion_msked.Name = "expected_completion_msked";
            this.expected_completion_msked.Size = new System.Drawing.Size(136, 22);
            this.expected_completion_msked.TabIndex = 15;
            this.expected_completion_msked.ValidatingType = typeof(System.DateTime);
            // 
            // contract_num_grpbx
            // 
            this.contract_num_grpbx.Controls.Add(this.contract_number_mskedtxtbx);
            this.contract_num_grpbx.Controls.Add(this.contract_num_label);
            this.contract_num_grpbx.Controls.Add(this.entry_date_msked);
            this.contract_num_grpbx.Controls.Add(this.expected_completion_msked);
            this.contract_num_grpbx.Controls.Add(this.due_date_label);
            this.contract_num_grpbx.Controls.Add(this.due_date_msked);
            this.contract_num_grpbx.Controls.Add(this.entry_date_label);
            this.contract_num_grpbx.Controls.Add(this.expected_label);
            this.contract_num_grpbx.Location = new System.Drawing.Point(36, 84);
            this.contract_num_grpbx.Name = "contract_num_grpbx";
            this.contract_num_grpbx.Size = new System.Drawing.Size(490, 205);
            this.contract_num_grpbx.TabIndex = 16;
            this.contract_num_grpbx.TabStop = false;
            // 
            // contract_number_mskedtxtbx
            // 
            this.contract_number_mskedtxtbx.Location = new System.Drawing.Point(257, 34);
            this.contract_number_mskedtxtbx.Mask = "000000000";
            this.contract_number_mskedtxtbx.Name = "contract_number_mskedtxtbx";
            this.contract_number_mskedtxtbx.Size = new System.Drawing.Size(136, 22);
            this.contract_number_mskedtxtbx.TabIndex = 16;
            // 
            // location_grpbx
            // 
            this.location_grpbx.Controls.Add(this.start_location_mskedtxtbx);
            this.location_grpbx.Controls.Add(this.start_location_label);
            this.location_grpbx.Controls.Add(this.necessary_richtxtbx);
            this.location_grpbx.Controls.Add(this.processes_label);
            this.location_grpbx.Location = new System.Drawing.Point(36, 354);
            this.location_grpbx.Name = "location_grpbx";
            this.location_grpbx.Size = new System.Drawing.Size(490, 179);
            this.location_grpbx.TabIndex = 17;
            this.location_grpbx.TabStop = false;
            // 
            // start_location_mskedtxtbx
            // 
            this.start_location_mskedtxtbx.Location = new System.Drawing.Point(257, 21);
            this.start_location_mskedtxtbx.Mask = "00";
            this.start_location_mskedtxtbx.Name = "start_location_mskedtxtbx";
            this.start_location_mskedtxtbx.Size = new System.Drawing.Size(136, 22);
            this.start_location_mskedtxtbx.TabIndex = 13;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(578, 28);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submitToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // submitToolStripMenuItem
            // 
            this.submitToolStripMenuItem.Name = "submitToolStripMenuItem";
            this.submitToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.submitToolStripMenuItem.Text = "Submit";
            this.submitToolStripMenuItem.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
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
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(138, 580);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(75, 29);
            this.exit_btn.TabIndex = 19;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // submit_btn
            // 
            this.submit_btn.Location = new System.Drawing.Point(36, 580);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(75, 29);
            this.submit_btn.TabIndex = 20;
            this.submit_btn.Text = "Submit";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // ContractEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 686);
            this.ControlBox = false;
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.location_grpbx);
            this.Controls.Add(this.contract_num_grpbx);
            this.Controls.Add(this.contract_entry_label);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ContractEntry";
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
        private System.Windows.Forms.MaskedTextBox due_date_msked;
        private System.Windows.Forms.MaskedTextBox entry_date_msked;
        private System.Windows.Forms.MaskedTextBox expected_completion_msked;
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
    }
}