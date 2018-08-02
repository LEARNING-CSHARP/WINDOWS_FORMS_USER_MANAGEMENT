namespace MyApplication.Admin
{
	partial class UpdateUserForm
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
			this.descriptionLabel = new Dtx.Windows.Forms.Label();
			this.descriptionTextBox = new Dtx.Windows.Forms.TextBox();
			this.fullNameTextBox = new Dtx.Windows.Forms.TextBox();
			this.fullNameLabel = new Dtx.Windows.Forms.Label();
			this.isActiveCheckBox = new Dtx.Windows.Forms.CheckBox();
			this.isAdminCheckBox = new Dtx.Windows.Forms.CheckBox();
			this.saveAndCloseButton = new Dtx.Windows.Forms.Button();
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
			this.descriptionTextBox.Size = new System.Drawing.Size(353, 139);
			this.descriptionTextBox.TabIndex = 3;
			// 
			// fullNameTextBox
			// 
			this.fullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.fullNameTextBox.Location = new System.Drawing.Point(89, 12);
			this.fullNameTextBox.Name = "fullNameTextBox";
			this.fullNameTextBox.Size = new System.Drawing.Size(353, 21);
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
			this.isActiveCheckBox.Location = new System.Drawing.Point(89, 184);
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
			this.isAdminCheckBox.Location = new System.Drawing.Point(89, 207);
			this.isAdminCheckBox.Name = "isAdminCheckBox";
			this.isAdminCheckBox.Size = new System.Drawing.Size(62, 17);
			this.isAdminCheckBox.TabIndex = 5;
			this.isAdminCheckBox.Text = "Admin";
			this.isAdminCheckBox.UseVisualStyleBackColor = true;
			// 
			// saveAndCloseButton
			// 
			this.saveAndCloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.saveAndCloseButton.Location = new System.Drawing.Point(89, 230);
			this.saveAndCloseButton.Name = "saveAndCloseButton";
			this.saveAndCloseButton.Size = new System.Drawing.Size(141, 23);
			this.saveAndCloseButton.TabIndex = 6;
			this.saveAndCloseButton.Text = "&Save And Close";
			this.saveAndCloseButton.UseVisualStyleBackColor = true;
			this.saveAndCloseButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// UpdateUserForm
			// 
			this.AcceptButton = this.saveAndCloseButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(454, 261);
			this.Controls.Add(this.saveAndCloseButton);
			this.Controls.Add(this.isAdminCheckBox);
			this.Controls.Add(this.isActiveCheckBox);
			this.Controls.Add(this.descriptionLabel);
			this.Controls.Add(this.descriptionTextBox);
			this.Controls.Add(this.fullNameTextBox);
			this.Controls.Add(this.fullNameLabel);
			this.MinimumSize = new System.Drawing.Size(470, 300);
			this.Name = "UpdateUserForm";
			this.Text = "Update User";
			this.Load += new System.EventHandler(this.UpdateUserForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Dtx.Windows.Forms.Label descriptionLabel;
		private Dtx.Windows.Forms.TextBox descriptionTextBox;
		private Dtx.Windows.Forms.TextBox fullNameTextBox;
		private Dtx.Windows.Forms.Label fullNameLabel;
		private Dtx.Windows.Forms.CheckBox isActiveCheckBox;
		private Dtx.Windows.Forms.CheckBox isAdminCheckBox;
		private Dtx.Windows.Forms.Button saveAndCloseButton;
	}
}
