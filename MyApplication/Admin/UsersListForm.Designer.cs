namespace MyApplication.Admin
{
	partial class UsersListForm
	{
		private System.ComponentModel.IContainer components = null;

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
			this.fullNameTextBox = new Dtx.Windows.Forms.TextBox();
			this.fullNameLabel = new Dtx.Windows.Forms.Label();
			this.searchButton = new Dtx.Windows.Forms.Button();
			this.usersListBox = new Dtx.Windows.Forms.ListBox();
			this.deleteUsersButton = new Dtx.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// fullNameTextBox
			// 
			this.fullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.fullNameTextBox.Location = new System.Drawing.Point(127, 18);
			this.fullNameTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.fullNameTextBox.Name = "fullNameTextBox";
			this.fullNameTextBox.Size = new System.Drawing.Size(784, 28);
			this.fullNameTextBox.TabIndex = 1;
			// 
			// fullNameLabel
			// 
			this.fullNameLabel.AutoSize = true;
			this.fullNameLabel.ForeColor = System.Drawing.Color.White;
			this.fullNameLabel.Location = new System.Drawing.Point(19, 23);
			this.fullNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.fullNameLabel.Name = "fullNameLabel";
			this.fullNameLabel.Size = new System.Drawing.Size(96, 20);
			this.fullNameLabel.TabIndex = 0;
			this.fullNameLabel.Text = "&Full Name";
			// 
			// searchButton
			// 
			this.searchButton.Location = new System.Drawing.Point(127, 60);
			this.searchButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(118, 35);
			this.searchButton.TabIndex = 2;
			this.searchButton.Text = "&Search";
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
			// 
			// usersListBox
			// 
			this.usersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.usersListBox.FormattingEnabled = true;
			this.usersListBox.ItemHeight = 20;
			this.usersListBox.Location = new System.Drawing.Point(19, 105);
			this.usersListBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.usersListBox.Name = "usersListBox";
			this.usersListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.usersListBox.Size = new System.Drawing.Size(893, 184);
			this.usersListBox.TabIndex = 3;
			this.usersListBox.DoubleClick += new System.EventHandler(this.UsersListBox_DoubleClick);
			// 
			// deleteUsersButton
			// 
			this.deleteUsersButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.deleteUsersButton.Location = new System.Drawing.Point(19, 302);
			this.deleteUsersButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.deleteUsersButton.Name = "deleteUsersButton";
			this.deleteUsersButton.Size = new System.Drawing.Size(226, 35);
			this.deleteUsersButton.TabIndex = 4;
			this.deleteUsersButton.Text = "&Delete Users";
			this.deleteUsersButton.UseVisualStyleBackColor = true;
			this.deleteUsersButton.Click += new System.EventHandler(this.DeleteUsersButton_Click);
			// 
			// UsersListForm
			// 
			this.AcceptButton = this.searchButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(933, 355);
			this.Controls.Add(this.deleteUsersButton);
			this.Controls.Add(this.usersListBox);
			this.Controls.Add(this.searchButton);
			this.Controls.Add(this.fullNameLabel);
			this.Controls.Add(this.fullNameTextBox);
			this.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
			this.MinimumSize = new System.Drawing.Size(663, 385);
			this.Name = "UsersListForm";
			this.Text = "Users List";
			this.Load += new System.EventHandler(this.UsersListForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Dtx.Windows.Forms.TextBox fullNameTextBox;
		private Dtx.Windows.Forms.Label fullNameLabel;
		private Dtx.Windows.Forms.Button searchButton;
		private Dtx.Windows.Forms.ListBox usersListBox;
		private Dtx.Windows.Forms.Button deleteUsersButton;
	}
}
