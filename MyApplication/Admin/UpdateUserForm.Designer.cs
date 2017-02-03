namespace MyApplication.Admin
{
	partial class UpdateUserForm
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
			this.descriptionLabel = new System.Windows.Forms.Label();
			this.descriptionTextBox = new System.Windows.Forms.TextBox();
			this.fullNameTextBox = new System.Windows.Forms.TextBox();
			this.fullNameLabel = new System.Windows.Forms.Label();
			this.isActiveCheckBox = new System.Windows.Forms.CheckBox();
			this.isAdminCheckBox = new System.Windows.Forms.CheckBox();
			this.saveButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// descriptionLabel
			// 
			this.descriptionLabel.AutoSize = true;
			this.descriptionLabel.ForeColor = System.Drawing.Color.White;
			this.descriptionLabel.Location = new System.Drawing.Point(12, 42);
			this.descriptionLabel.Name = "descriptionLabel";
			this.descriptionLabel.Size = new System.Drawing.Size(71, 13);
			this.descriptionLabel.TabIndex = 2;
			this.descriptionLabel.Text = "&Description";
			// 
			// descriptionTextBox
			// 
			this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.descriptionTextBox.Location = new System.Drawing.Point(89, 39);
			this.descriptionTextBox.Multiline = true;
			this.descriptionTextBox.Name = "descriptionTextBox";
			this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.descriptionTextBox.Size = new System.Drawing.Size(346, 190);
			this.descriptionTextBox.TabIndex = 3;
			// 
			// fullNameTextBox
			// 
			this.fullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.fullNameTextBox.Location = new System.Drawing.Point(89, 12);
			this.fullNameTextBox.Name = "fullNameTextBox";
			this.fullNameTextBox.Size = new System.Drawing.Size(346, 21);
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
			// isActiveCheckBox
			// 
			this.isActiveCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.isActiveCheckBox.AutoSize = true;
			this.isActiveCheckBox.ForeColor = System.Drawing.Color.White;
			this.isActiveCheckBox.Location = new System.Drawing.Point(89, 235);
			this.isActiveCheckBox.Name = "isActiveCheckBox";
			this.isActiveCheckBox.Size = new System.Drawing.Size(61, 17);
			this.isActiveCheckBox.TabIndex = 4;
			this.isActiveCheckBox.Text = "Active";
			this.isActiveCheckBox.UseVisualStyleBackColor = true;
			// 
			// isAdminCheckBox
			// 
			this.isAdminCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.isAdminCheckBox.AutoSize = true;
			this.isAdminCheckBox.ForeColor = System.Drawing.Color.White;
			this.isAdminCheckBox.Location = new System.Drawing.Point(89, 258);
			this.isAdminCheckBox.Name = "isAdminCheckBox";
			this.isAdminCheckBox.Size = new System.Drawing.Size(62, 17);
			this.isAdminCheckBox.TabIndex = 5;
			this.isAdminCheckBox.Text = "Admin";
			this.isAdminCheckBox.UseVisualStyleBackColor = true;
			// 
			// saveButton
			// 
			this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.saveButton.Location = new System.Drawing.Point(89, 281);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(75, 23);
			this.saveButton.TabIndex = 6;
			this.saveButton.Text = "&Save";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// UpdateUserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(447, 312);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.isAdminCheckBox);
			this.Controls.Add(this.isActiveCheckBox);
			this.Controls.Add(this.descriptionLabel);
			this.Controls.Add(this.descriptionTextBox);
			this.Controls.Add(this.fullNameTextBox);
			this.Controls.Add(this.fullNameLabel);
			this.Name = "UpdateUserForm";
			this.Text = "Update User";
			this.Load += new System.EventHandler(this.UpdateUserForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label descriptionLabel;
		private System.Windows.Forms.TextBox descriptionTextBox;
		private System.Windows.Forms.TextBox fullNameTextBox;
		private System.Windows.Forms.Label fullNameLabel;
		private System.Windows.Forms.CheckBox isActiveCheckBox;
		private System.Windows.Forms.CheckBox isAdminCheckBox;
		private System.Windows.Forms.Button saveButton;
	}
}