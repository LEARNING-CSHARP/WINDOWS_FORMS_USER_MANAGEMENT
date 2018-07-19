namespace MyApplication
{
	partial class ChangePasswordForm
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
			this.changePasswordButton = new Dtx.Windows.Forms.Button();
			this.newPasswordLabel = new Dtx.Windows.Forms.Label();
			this.newPasswordTextBox = new Dtx.Windows.Forms.TextBox();
			this.oldPasswordTextBox = new Dtx.Windows.Forms.TextBox();
			this.oldPasswordLabel = new Dtx.Windows.Forms.Label();
			this.confirmNewPasswordLabel = new Dtx.Windows.Forms.Label();
			this.confirmNewPasswordTextBox = new Dtx.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// changePasswordButton
			// 
			this.changePasswordButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.changePasswordButton.Location = new System.Drawing.Point(273, 93);
			this.changePasswordButton.Name = "changePasswordButton";
			this.changePasswordButton.Size = new System.Drawing.Size(128, 23);
			this.changePasswordButton.TabIndex = 6;
			this.changePasswordButton.Text = "Change &Password";
			this.changePasswordButton.UseVisualStyleBackColor = true;
			this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
			// 
			// newPasswordLabel
			// 
			this.newPasswordLabel.AutoSize = true;
			this.newPasswordLabel.ForeColor = System.Drawing.Color.White;
			this.newPasswordLabel.Location = new System.Drawing.Point(12, 42);
			this.newPasswordLabel.Name = "newPasswordLabel";
			this.newPasswordLabel.Size = new System.Drawing.Size(89, 13);
			this.newPasswordLabel.TabIndex = 2;
			this.newPasswordLabel.Text = "&New Password";
			// 
			// newPasswordTextBox
			// 
			this.newPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.newPasswordTextBox.Location = new System.Drawing.Point(157, 39);
			this.newPasswordTextBox.MaxLength = 40;
			this.newPasswordTextBox.Name = "newPasswordTextBox";
			this.newPasswordTextBox.PasswordChar = '*';
			this.newPasswordTextBox.Size = new System.Drawing.Size(244, 21);
			this.newPasswordTextBox.TabIndex = 3;
			// 
			// oldPasswordTextBox
			// 
			this.oldPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.oldPasswordTextBox.Location = new System.Drawing.Point(157, 12);
			this.oldPasswordTextBox.MaxLength = 40;
			this.oldPasswordTextBox.Name = "oldPasswordTextBox";
			this.oldPasswordTextBox.PasswordChar = '*';
			this.oldPasswordTextBox.Size = new System.Drawing.Size(244, 21);
			this.oldPasswordTextBox.TabIndex = 1;
			// 
			// oldPasswordLabel
			// 
			this.oldPasswordLabel.AutoSize = true;
			this.oldPasswordLabel.ForeColor = System.Drawing.Color.White;
			this.oldPasswordLabel.Location = new System.Drawing.Point(12, 15);
			this.oldPasswordLabel.Name = "oldPasswordLabel";
			this.oldPasswordLabel.Size = new System.Drawing.Size(84, 13);
			this.oldPasswordLabel.TabIndex = 0;
			this.oldPasswordLabel.Text = "&Old Password";
			// 
			// confirmNewPasswordLabel
			// 
			this.confirmNewPasswordLabel.AutoSize = true;
			this.confirmNewPasswordLabel.ForeColor = System.Drawing.Color.White;
			this.confirmNewPasswordLabel.Location = new System.Drawing.Point(12, 69);
			this.confirmNewPasswordLabel.Name = "confirmNewPasswordLabel";
			this.confirmNewPasswordLabel.Size = new System.Drawing.Size(139, 13);
			this.confirmNewPasswordLabel.TabIndex = 4;
			this.confirmNewPasswordLabel.Text = "&Confirm New Password";
			// 
			// confirmNewPasswordTextBox
			// 
			this.confirmNewPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.confirmNewPasswordTextBox.Location = new System.Drawing.Point(157, 66);
			this.confirmNewPasswordTextBox.MaxLength = 40;
			this.confirmNewPasswordTextBox.Name = "confirmNewPasswordTextBox";
			this.confirmNewPasswordTextBox.PasswordChar = '*';
			this.confirmNewPasswordTextBox.Size = new System.Drawing.Size(244, 21);
			this.confirmNewPasswordTextBox.TabIndex = 5;
			// 
			// ChangePasswordForm
			// 
			this.AcceptButton = this.changePasswordButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(413, 126);
			this.Controls.Add(this.confirmNewPasswordLabel);
			this.Controls.Add(this.confirmNewPasswordTextBox);
			this.Controls.Add(this.changePasswordButton);
			this.Controls.Add(this.newPasswordLabel);
			this.Controls.Add(this.newPasswordTextBox);
			this.Controls.Add(this.oldPasswordTextBox);
			this.Controls.Add(this.oldPasswordLabel);
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MaximumSize = new System.Drawing.Size(800, 165);
			this.MinimumSize = new System.Drawing.Size(429, 165);
			this.Name = "ChangePasswordForm";
			this.Text = "Login";
			this.Load += new System.EventHandler(this.ChangePasswordForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Dtx.Windows.Forms.Label newPasswordLabel;
		private Dtx.Windows.Forms.TextBox newPasswordTextBox;
		private Dtx.Windows.Forms.TextBox oldPasswordTextBox;
		private Dtx.Windows.Forms.Label oldPasswordLabel;
		private Dtx.Windows.Forms.Button changePasswordButton;
		private Dtx.Windows.Forms.Label confirmNewPasswordLabel;
		private Dtx.Windows.Forms.TextBox confirmNewPasswordTextBox;
	}
}
