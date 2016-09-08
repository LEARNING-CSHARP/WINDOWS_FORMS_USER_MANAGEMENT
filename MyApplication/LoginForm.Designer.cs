namespace MyApplication
{
	partial class LoginForm
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
			this.RegisterButton = new System.Windows.Forms.Button();
			this.ResetButton = new System.Windows.Forms.Button();
			this.PasswordLabel = new System.Windows.Forms.Label();
			this.PasswordTextBox = new System.Windows.Forms.TextBox();
			this.UsernameTextBox = new System.Windows.Forms.TextBox();
			this.UsernameLabel = new System.Windows.Forms.Label();
			this.LoginButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// RegisterButton
			// 
			this.RegisterButton.Location = new System.Drawing.Point(245, 67);
			this.RegisterButton.Name = "RegisterButton";
			this.RegisterButton.Size = new System.Drawing.Size(75, 23);
			this.RegisterButton.TabIndex = 6;
			this.RegisterButton.Text = "Re&gister";
			this.RegisterButton.UseVisualStyleBackColor = true;
			this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
			// 
			// ResetButton
			// 
			this.ResetButton.Location = new System.Drawing.Point(164, 66);
			this.ResetButton.Name = "ResetButton";
			this.ResetButton.Size = new System.Drawing.Size(75, 23);
			this.ResetButton.TabIndex = 5;
			this.ResetButton.Text = "&Reset";
			this.ResetButton.UseVisualStyleBackColor = true;
			this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
			// 
			// PasswordLabel
			// 
			this.PasswordLabel.AutoSize = true;
			this.PasswordLabel.Location = new System.Drawing.Point(12, 42);
			this.PasswordLabel.Name = "PasswordLabel";
			this.PasswordLabel.Size = new System.Drawing.Size(61, 13);
			this.PasswordLabel.TabIndex = 2;
			this.PasswordLabel.Text = "&Password";
			// 
			// PasswordTextBox
			// 
			this.PasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PasswordTextBox.Location = new System.Drawing.Point(83, 39);
			this.PasswordTextBox.Name = "PasswordTextBox";
			this.PasswordTextBox.PasswordChar = '*';
			this.PasswordTextBox.Size = new System.Drawing.Size(236, 21);
			this.PasswordTextBox.TabIndex = 3;
			// 
			// UsernameTextBox
			// 
			this.UsernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.UsernameTextBox.Location = new System.Drawing.Point(83, 12);
			this.UsernameTextBox.Name = "UsernameTextBox";
			this.UsernameTextBox.Size = new System.Drawing.Size(236, 21);
			this.UsernameTextBox.TabIndex = 1;
			// 
			// UsernameLabel
			// 
			this.UsernameLabel.AutoSize = true;
			this.UsernameLabel.Location = new System.Drawing.Point(12, 15);
			this.UsernameLabel.Name = "UsernameLabel";
			this.UsernameLabel.Size = new System.Drawing.Size(65, 13);
			this.UsernameLabel.TabIndex = 0;
			this.UsernameLabel.Text = "&Username";
			// 
			// LoginButton
			// 
			this.LoginButton.Location = new System.Drawing.Point(83, 66);
			this.LoginButton.Name = "LoginButton";
			this.LoginButton.Size = new System.Drawing.Size(75, 23);
			this.LoginButton.TabIndex = 4;
			this.LoginButton.Text = "&Login";
			this.LoginButton.UseVisualStyleBackColor = true;
			this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(331, 101);
			this.Controls.Add(this.LoginButton);
			this.Controls.Add(this.RegisterButton);
			this.Controls.Add(this.ResetButton);
			this.Controls.Add(this.PasswordLabel);
			this.Controls.Add(this.PasswordTextBox);
			this.Controls.Add(this.UsernameTextBox);
			this.Controls.Add(this.UsernameLabel);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MinimumSize = new System.Drawing.Size(347, 140);
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LoginForm";
			this.Load += new System.EventHandler(this.LoginForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button RegisterButton;
		private System.Windows.Forms.Button ResetButton;
		private System.Windows.Forms.Label PasswordLabel;
		private System.Windows.Forms.TextBox PasswordTextBox;
		private System.Windows.Forms.TextBox UsernameTextBox;
		private System.Windows.Forms.Label UsernameLabel;
		private System.Windows.Forms.Button LoginButton;
	}
}
