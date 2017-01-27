namespace MyApplication
{
	partial class RegisterForm
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
			this.usernameLabel = new System.Windows.Forms.Label();
			this.usernameTextBox = new System.Windows.Forms.TextBox();
			this.passwordTextBox = new System.Windows.Forms.TextBox();
			this.fullNameTextBox = new System.Windows.Forms.TextBox();
			this.passwordLabel = new System.Windows.Forms.Label();
			this.fullNameLabel = new System.Windows.Forms.Label();
			this.resetButton = new System.Windows.Forms.Button();
			this.registerButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// usernameLabel
			// 
			this.usernameLabel.AutoSize = true;
			this.usernameLabel.ForeColor = System.Drawing.Color.White;
			this.usernameLabel.Location = new System.Drawing.Point(12, 15);
			this.usernameLabel.Name = "usernameLabel";
			this.usernameLabel.Size = new System.Drawing.Size(65, 13);
			this.usernameLabel.TabIndex = 0;
			this.usernameLabel.Text = "&Username";
			// 
			// usernameTextBox
			// 
			this.usernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.usernameTextBox.Location = new System.Drawing.Point(83, 12);
			this.usernameTextBox.MaxLength = 20;
			this.usernameTextBox.Name = "usernameTextBox";
			this.usernameTextBox.Size = new System.Drawing.Size(155, 21);
			this.usernameTextBox.TabIndex = 1;
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.passwordTextBox.Location = new System.Drawing.Point(83, 39);
			this.passwordTextBox.MaxLength = 40;
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.PasswordChar = '*';
			this.passwordTextBox.Size = new System.Drawing.Size(155, 21);
			this.passwordTextBox.TabIndex = 3;
			// 
			// fullNameTextBox
			// 
			this.fullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.fullNameTextBox.Location = new System.Drawing.Point(83, 66);
			this.fullNameTextBox.MaxLength = 50;
			this.fullNameTextBox.Name = "fullNameTextBox";
			this.fullNameTextBox.Size = new System.Drawing.Size(155, 21);
			this.fullNameTextBox.TabIndex = 5;
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.ForeColor = System.Drawing.Color.White;
			this.passwordLabel.Location = new System.Drawing.Point(12, 42);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(61, 13);
			this.passwordLabel.TabIndex = 2;
			this.passwordLabel.Text = "&Password";
			// 
			// fullNameLabel
			// 
			this.fullNameLabel.AutoSize = true;
			this.fullNameLabel.ForeColor = System.Drawing.Color.White;
			this.fullNameLabel.Location = new System.Drawing.Point(12, 69);
			this.fullNameLabel.Name = "fullNameLabel";
			this.fullNameLabel.Size = new System.Drawing.Size(59, 13);
			this.fullNameLabel.TabIndex = 4;
			this.fullNameLabel.Text = "&FullName";
			// 
			// resetButton
			// 
			this.resetButton.Location = new System.Drawing.Point(164, 93);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(75, 23);
			this.resetButton.TabIndex = 7;
			this.resetButton.Text = "&Reset";
			this.resetButton.UseVisualStyleBackColor = true;
			this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
			// 
			// registerButton
			// 
			this.registerButton.Location = new System.Drawing.Point(83, 93);
			this.registerButton.Name = "registerButton";
			this.registerButton.Size = new System.Drawing.Size(75, 23);
			this.registerButton.TabIndex = 6;
			this.registerButton.Text = "Re&gister";
			this.registerButton.UseVisualStyleBackColor = true;
			this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
			// 
			// RegisterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(250, 127);
			this.Controls.Add(this.registerButton);
			this.Controls.Add(this.resetButton);
			this.Controls.Add(this.fullNameLabel);
			this.Controls.Add(this.passwordLabel);
			this.Controls.Add(this.fullNameTextBox);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.usernameTextBox);
			this.Controls.Add(this.usernameLabel);
			this.MaximumSize = new System.Drawing.Size(800, 166);
			this.MinimumSize = new System.Drawing.Size(266, 166);
			this.Name = "RegisterForm";
			this.Text = "Register";
			this.Load += new System.EventHandler(this.RegisterForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label usernameLabel;
		private System.Windows.Forms.TextBox usernameTextBox;
		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.TextBox fullNameTextBox;
		private System.Windows.Forms.Label passwordLabel;
		private System.Windows.Forms.Label fullNameLabel;
		private System.Windows.Forms.Button resetButton;
		private System.Windows.Forms.Button registerButton;
	}
}

