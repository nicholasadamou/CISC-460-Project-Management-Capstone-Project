namespace WindowsFormsApplication2
{
    partial class Sign_in_form
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
            this.components = new System.ComponentModel.Container();
            this.sign_in_label = new System.Windows.Forms.Label();
            this.username_label = new System.Windows.Forms.Label();
            this.username_textbx = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.password_textbx = new System.Windows.Forms.TextBox();
            this.sign_in_btn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forgotPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exit_btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sign_in_label
            // 
            this.sign_in_label.AutoSize = true;
            this.sign_in_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_in_label.Location = new System.Drawing.Point(182, 38);
            this.sign_in_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sign_in_label.Name = "sign_in_label";
            this.sign_in_label.Size = new System.Drawing.Size(109, 36);
            this.sign_in_label.TabIndex = 0;
            this.sign_in_label.Text = "Sign In";
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.Location = new System.Drawing.Point(129, 103);
            this.username_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(83, 20);
            this.username_label.TabIndex = 1;
            this.username_label.Text = "Username";
            // 
            // username_textbx
            // 
            this.username_textbx.Location = new System.Drawing.Point(230, 106);
            this.username_textbx.Margin = new System.Windows.Forms.Padding(2);
            this.username_textbx.Name = "username_textbx";
            this.username_textbx.Size = new System.Drawing.Size(122, 20);
            this.username_textbx.TabIndex = 2;
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.Location = new System.Drawing.Point(129, 141);
            this.password_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(78, 20);
            this.password_label.TabIndex = 3;
            this.password_label.Text = "Password";
            // 
            // password_textbx
            // 
            this.password_textbx.Location = new System.Drawing.Point(230, 143);
            this.password_textbx.Margin = new System.Windows.Forms.Padding(2);
            this.password_textbx.Name = "password_textbx";
            this.password_textbx.PasswordChar = '*';
            this.password_textbx.Size = new System.Drawing.Size(122, 20);
            this.password_textbx.TabIndex = 4;
            // 
            // sign_in_btn
            // 
            this.sign_in_btn.Location = new System.Drawing.Point(133, 194);
            this.sign_in_btn.Margin = new System.Windows.Forms.Padding(2);
            this.sign_in_btn.Name = "sign_in_btn";
            this.sign_in_btn.Size = new System.Drawing.Size(65, 25);
            this.sign_in_btn.TabIndex = 5;
            this.sign_in_btn.Text = "Sign In";
            this.sign_in_btn.UseVisualStyleBackColor = true;
            this.sign_in_btn.Click += new System.EventHandler(this.sign_in_btn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(473, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signInToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // signInToolStripMenuItem
            // 
            this.signInToolStripMenuItem.Name = "signInToolStripMenuItem";
            this.signInToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.signInToolStripMenuItem.Text = "Sign In";
            this.signInToolStripMenuItem.Click += new System.EventHandler(this.sign_in_btn_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forgotPasswordToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // forgotPasswordToolStripMenuItem
            // 
            this.forgotPasswordToolStripMenuItem.Name = "forgotPasswordToolStripMenuItem";
            this.forgotPasswordToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.forgotPasswordToolStripMenuItem.Text = "Password Hint";
            this.forgotPasswordToolStripMenuItem.Click += new System.EventHandler(this.forgotPasswordToolStripMenuItem_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(287, 194);
            this.exit_btn.Margin = new System.Windows.Forms.Padding(2);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(65, 25);
            this.exit_btn.TabIndex = 7;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // Sign_in_form
            // 
            this.AcceptButton = this.sign_in_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 283);
            this.ControlBox = false;
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.sign_in_btn);
            this.Controls.Add(this.password_textbx);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_textbx);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.sign_in_label);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Sign_in_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Sign_in_form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sign_in_label;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.TextBox username_textbx;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox password_textbx;
        private System.Windows.Forms.Button sign_in_btn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forgotPasswordToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}

