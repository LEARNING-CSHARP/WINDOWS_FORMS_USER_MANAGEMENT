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
			this.fullNameTextBox.Location = new System.Drawing.Point(104, 15);
			this.fullNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.fullNameTextBox.Name = "fullNameTextBox";
			this.fullNameTextBox.Size = new System.Drawing.Size(735, 24);
			this.fullNameTextBox.TabIndex = 1;
			// 
			// fullNameLabel
			// 
			this.fullNameLabel.AutoSize = true;
			this.fullNameLabel.ForeColor = System.Drawing.Color.White;
			this.fullNameLabel.Location = new System.Drawing.Point(16, 20);
			this.fullNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.fullNameLabel.Name = "fullNameLabel";
			this.fullNameLabel.Size = new System.Drawing.Size(75, 17);
			this.fullNameLabel.TabIndex = 0;
			this.fullNameLabel.Text = "&Full Name";
			// 
			// searchButton
			// 
			this.searchButton.Location = new System.Drawing.Point(104, 51);
			this.searchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(97, 30);
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
			this.usersListBox.ItemHeight = 17;
			this.usersListBox.Location = new System.Drawing.Point(16, 89);
			this.usersListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.usersListBox.Name = "usersListBox";
			this.usersListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.usersListBox.Size = new System.Drawing.Size(824, 344);
			this.usersListBox.TabIndex = 3;
			this.usersListBox.DoubleClick += new System.EventHandler(this.UsersListBox_DoubleClick);
			// 
			// deleteUsersButton
			// 
			this.deleteUsersButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.deleteUsersButton.Location = new System.Drawing.Point(16, 453);
			this.deleteUsersButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.deleteUsersButton.Name = "deleteUsersButton";
			this.deleteUsersButton.Size = new System.Drawing.Size(185, 30);
			this.deleteUsersButton.TabIndex = 4;
			this.deleteUsersButton.Text = "&Delete Users";
			this.deleteUsersButton.UseVisualStyleBackColor = true;
			this.deleteUsersButton.Click += new System.EventHandler(this.DeleteUsersButton_Click);
			// 
			// UsersListForm
			// 
			this.AcceptButton = this.searchButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(856, 498);
			this.Controls.Add(this.deleteUsersButton);
			this.Controls.Add(this.usersListBox);
			this.Controls.Add(this.searchButton);
			this.Controls.Add(this.fullNameLabel);
			this.Controls.Add(this.fullNameTextBox);
			this.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
			this.MinimumSize = new System.Drawing.Size(546, 334);
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
