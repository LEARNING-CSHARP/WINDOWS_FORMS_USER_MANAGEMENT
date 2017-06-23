namespace MyApplication
{
	partial class MainForm
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
			this.myMenuStrip = new System.Windows.Forms.MenuStrip();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.updateProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.usersListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.myStatusStrip = new System.Windows.Forms.StatusStrip();
			this.usernameToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.myMenuStrip.SuspendLayout();
			this.myStatusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// myMenuStrip
			// 
			this.myMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.adminToolStripMenuItem});
			this.myMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.myMenuStrip.Name = "myMenuStrip";
			this.myMenuStrip.Size = new System.Drawing.Size(331, 24);
			this.myMenuStrip.TabIndex = 0;
			this.myMenuStrip.Text = "menuStrip1";
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateProfileToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.settingsToolStripMenuItem.Text = "&Settings";
			// 
			// updateProfileToolStripMenuItem
			// 
			this.updateProfileToolStripMenuItem.Name = "updateProfileToolStripMenuItem";
			this.updateProfileToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.updateProfileToolStripMenuItem.Text = "&Update Profile";
			this.updateProfileToolStripMenuItem.Click += new System.EventHandler(this.updateProfileToolStripMenuItem_Click);
			// 
			// changePasswordToolStripMenuItem
			// 
			this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
			this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.changePasswordToolStripMenuItem.Text = "Change Password";
			this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(165, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// adminToolStripMenuItem
			// 
			this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersListToolStripMenuItem});
			this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
			this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
			this.adminToolStripMenuItem.Text = "Admin";
			// 
			// usersListToolStripMenuItem
			// 
			this.usersListToolStripMenuItem.Name = "usersListToolStripMenuItem";
			this.usersListToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.usersListToolStripMenuItem.Text = "Users List";
			this.usersListToolStripMenuItem.Click += new System.EventHandler(this.usersListToolStripMenuItem_Click);
			// 
			// myStatusStrip
			// 
			this.myStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usernameToolStripStatusLabel});
			this.myStatusStrip.Location = new System.Drawing.Point(0, 239);
			this.myStatusStrip.Name = "myStatusStrip";
			this.myStatusStrip.Size = new System.Drawing.Size(331, 22);
			this.myStatusStrip.TabIndex = 1;
			this.myStatusStrip.Text = "statusStrip1";
			// 
			// usernameToolStripStatusLabel
			// 
			this.usernameToolStripStatusLabel.Name = "usernameToolStripStatusLabel";
			this.usernameToolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(331, 261);
			this.Controls.Add(this.myStatusStrip);
			this.Controls.Add(this.myMenuStrip);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.myMenuStrip;
			this.Name = "MainForm";
			this.Text = "Main";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.myMenuStrip.ResumeLayout(false);
			this.myMenuStrip.PerformLayout();
			this.myStatusStrip.ResumeLayout(false);
			this.myStatusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip myMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem updateProfileToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.StatusStrip myStatusStrip;
		private System.Windows.Forms.ToolStripStatusLabel usernameToolStripStatusLabel;
		private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem usersListToolStripMenuItem;
	}
}