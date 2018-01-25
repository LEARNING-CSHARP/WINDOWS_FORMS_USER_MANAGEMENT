namespace MyApplication.Admin
{
	partial class UsersListForm
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
			this.fullNameTextBox = new System.Windows.Forms.TextBox();
			this.fullNameLabel = new System.Windows.Forms.Label();
			this.searchButton = new System.Windows.Forms.Button();
			this.usersListBox = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// fullNameTextBox
			// 
			this.fullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.fullNameTextBox.Location = new System.Drawing.Point(81, 12);
			this.fullNameTextBox.Name = "fullNameTextBox";
			this.fullNameTextBox.Size = new System.Drawing.Size(321, 21);
			this.fullNameTextBox.TabIndex = 1;
			// 
			// fullNameLabel
			// 
			this.fullNameLabel.AutoSize = true;
			this.fullNameLabel.ForeColor = System.Drawing.Color.White;
			this.fullNameLabel.Location = new System.Drawing.Point(12, 15);
			this.fullNameLabel.Name = "fullNameLabel";
			this.fullNameLabel.Size = new System.Drawing.Size(63, 13);
			this.fullNameLabel.TabIndex = 0;
			this.fullNameLabel.Text = "&Full Name";
			// 
			// searchButton
			// 
			this.searchButton.Location = new System.Drawing.Point(81, 39);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(75, 23);
			this.searchButton.TabIndex = 2;
			this.searchButton.Text = "&Search";
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
			// 
			// usersListBox
			// 
			this.usersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.usersListBox.FormattingEnabled = true;
			this.usersListBox.Location = new System.Drawing.Point(12, 68);
			this.usersListBox.Name = "usersListBox";
			this.usersListBox.Size = new System.Drawing.Size(390, 147);
			this.usersListBox.TabIndex = 3;
			this.usersListBox.DoubleClick += new System.EventHandler(this.usersListBox_DoubleClick);
			// 
			// UsersListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(414, 231);
			this.Controls.Add(this.usersListBox);
			this.Controls.Add(this.searchButton);
			this.Controls.Add(this.fullNameLabel);
			this.Controls.Add(this.fullNameTextBox);
			this.MinimumSize = new System.Drawing.Size(430, 270);
			this.Name = "UsersListForm";
			this.Text = "Users List";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UsersListForm_FormClosed);
			this.Load += new System.EventHandler(this.UsersListForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox fullNameTextBox;
		private System.Windows.Forms.Label fullNameLabel;
		private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.ListBox usersListBox;
	}
}