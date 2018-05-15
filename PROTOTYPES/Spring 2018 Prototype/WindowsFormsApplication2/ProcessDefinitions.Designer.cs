namespace WindowsFormsApplication2
{
    partial class ProcessDefinitions
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
            this.process_num_rchtxtbx = new System.Windows.Forms.RichTextBox();
            this.description_rchtxtbx = new System.Windows.Forms.RichTextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lbl_ProcessDefinitions = new System.Windows.Forms.Label();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // process_num_rchtxtbx
            // 
            this.process_num_rchtxtbx.Location = new System.Drawing.Point(23, 80);
            this.process_num_rchtxtbx.Name = "process_num_rchtxtbx";
            this.process_num_rchtxtbx.ReadOnly = true;
            this.process_num_rchtxtbx.Size = new System.Drawing.Size(188, 397);
            this.process_num_rchtxtbx.TabIndex = 0;
            this.process_num_rchtxtbx.Text = "";
            // 
            // description_rchtxtbx
            // 
            this.description_rchtxtbx.Location = new System.Drawing.Point(217, 80);
            this.description_rchtxtbx.Name = "description_rchtxtbx";
            this.description_rchtxtbx.ReadOnly = true;
            this.description_rchtxtbx.Size = new System.Drawing.Size(188, 397);
            this.description_rchtxtbx.TabIndex = 1;
            this.description_rchtxtbx.Text = "";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(330, 489);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Text = "&Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(426, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lbl_ProcessDefinitions
            // 
            this.lbl_ProcessDefinitions.AutoSize = true;
            this.lbl_ProcessDefinitions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProcessDefinitions.Location = new System.Drawing.Point(120, 41);
            this.lbl_ProcessDefinitions.Name = "lbl_ProcessDefinitions";
            this.lbl_ProcessDefinitions.Size = new System.Drawing.Size(197, 25);
            this.lbl_ProcessDefinitions.TabIndex = 4;
            this.lbl_ProcessDefinitions.Text = "Process Definitions";
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // ProcessDefinitions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 531);
            this.Controls.Add(this.lbl_ProcessDefinitions);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.description_rchtxtbx);
            this.Controls.Add(this.process_num_rchtxtbx);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProcessDefinitions";
            this.Text = "ProcessDefinitions";
            this.Load += new System.EventHandler(this.ProcessDefinitions_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox process_num_rchtxtbx;
        private System.Windows.Forms.RichTextBox description_rchtxtbx;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lbl_ProcessDefinitions;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}