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
			this.usernameLabel = new Dtx.Windows.Forms.Label();
			this.usernameTextBox = new Dtx.Windows.Forms.TextBox();
			this.passwordTextBox = new Dtx.Windows.Forms.TextBox();
			this.fullNameTextBox = new Dtx.Windows.Forms.TextBox();
			this.passwordLabel = new Dtx.Windows.Forms.Label();
			this.fullNameLabel = new Dtx.Windows.Forms.Label();
			this.resetButton = new Dtx.Windows.Forms.Button();
			this.registerButton = new Dtx.Windows.Forms.Button();
			this.exitButton = new Dtx.Windows.Forms.Button();
			this.loginButton = new Dtx.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// usernameLabel
			// 
			this.usernameLabel.AutoSize = true;
			this.usernameLabel.ForeColor = System.Drawing.Color.White;
			this.usernameLabel.Location = new System.Drawing.Point(19, 23);
			this.usernameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.usernameLabel.Name = "usernameLabel";
			this.usernameLabel.Size = new System.Drawing.Size(95, 20);
			this.usernameLabel.TabIndex = 0;
			this.usernameLabel.Text = "&Username";
			// 
			// usernameTextBox
			// 
			this.usernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.usernameTextBox.Location = new System.Drawing.Point(130, 18);
			this.usernameTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.usernameTextBox.MaxLength = 20;
			this.usernameTextBox.Name = "usernameTextBox";
			this.usernameTextBox.Size = new System.Drawing.Size(496, 28);
			this.usernameTextBox.TabIndex = 1;
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.passwordTextBox.Location = new System.Drawing.Point(130, 60);
			this.passwordTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.passwordTextBox.MaxLength = 40;
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.PasswordChar = '*';
			this.passwordTextBox.Size = new System.Drawing.Size(496, 28);
			this.passwordTextBox.TabIndex = 3;
			// 
			// fullNameTextBox
			// 
			this.fullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.fullNameTextBox.Location = new System.Drawing.Point(130, 102);
			this.fullNameTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.fullNameTextBox.MaxLength = 50;
			this.fullNameTextBox.Name = "fullNameTextBox";
			this.fullNameTextBox.Size = new System.Drawing.Size(496, 28);
			this.fullNameTextBox.TabIndex = 5;
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.ForeColor = System.Drawing.Color.White;
			this.passwordLabel.Location = new System.Drawing.Point(19, 65);
			this.passwordLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(89, 20);
			this.passwordLabel.TabIndex = 2;
			this.passwordLabel.Text = "&Password";
			// 
			// fullNameLabel
			// 
			this.fullNameLabel.AutoSize = true;
			this.fullNameLabel.ForeColor = System.Drawing.Color.White;
			this.fullNameLabel.Location = new System.Drawing.Point(19, 106);
			this.fullNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.fullNameLabel.Name = "fullNameLabel";
			this.fullNameLabel.Size = new System.Drawing.Size(90, 20);
			this.fullNameLabel.TabIndex = 4;
			this.fullNameLabel.Text = "&FullName";
			// 
			// resetButton
			// 
			this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.resetButton.Location = new System.Drawing.Point(256, 143);
			this.resetButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(118, 35);
			this.resetButton.TabIndex = 7;
			this.resetButton.Text = "&Reset";
			this.resetButton.UseVisualStyleBackColor = true;
			this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
			// 
			// registerButton
			// 
			this.registerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.registerButton.Location = new System.Drawing.Point(129, 143);
			this.registerButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.registerButton.Name = "registerButton";
			this.registerButton.Size = new System.Drawing.Size(118, 35);
			this.registerButton.TabIndex = 6;
			this.registerButton.Text = "Re&gister";
			this.registerButton.UseVisualStyleBackColor = true;
			this.registerButton.Click += new System.EventHandler(this.RegisterButton_Click);
			// 
			// exitButton
			// 
			this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.exitButton.Location = new System.Drawing.Point(511, 143);
			this.exitButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(118, 35);
			this.exitButton.TabIndex = 9;
			this.exitButton.Text = "E&xit";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// loginButton
			// 
			this.loginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.loginButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.loginButton.Location = new System.Drawing.Point(383, 143);
			this.loginButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(118, 35);
			this.loginButton.TabIndex = 8;
			this.loginButton.Text = "&Login";
			this.loginButton.UseVisualStyleBackColor = true;
			this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
			// 
			// RegisterForm
			// 
			this.AcceptButton = this.registerButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.exitButton;
			this.ClientSize = new System.Drawing.Size(647, 169);
			this.ControlBox = false;
			this.Controls.Add(this.loginButton);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.registerButton);
			this.Controls.Add(this.resetButton);
			this.Controls.Add(this.fullNameLabel);
			this.Controls.Add(this.passwordLabel);
			this.Controls.Add(this.fullNameTextBox);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.usernameTextBox);
			this.Controls.Add(this.usernameLabel);
			this.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
			this.MaximumSize = new System.Drawing.Size(1245, 225);
			this.MinimumSize = new System.Drawing.Size(660, 225);
			this.Name = "RegisterForm";
			this.Text = "Register";
			this.Load += new System.EventHandler(this.RegisterForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Dtx.Windows.Forms.Label usernameLabel;
		private Dtx.Windows.Forms.TextBox usernameTextBox;
		private Dtx.Windows.Forms.TextBox passwordTextBox;
		private Dtx.Windows.Forms.TextBox fullNameTextBox;
		private Dtx.Windows.Forms.Label passwordLabel;
		private Dtx.Windows.Forms.Label fullNameLabel;
		private Dtx.Windows.Forms.Button resetButton;
		private Dtx.Windows.Forms.Button registerButton;
		private Dtx.Windows.Forms.Button exitButton;
		private Dtx.Windows.Forms.Button loginButton;
	}
}
