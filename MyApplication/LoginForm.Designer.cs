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
			this.loginButton = new Dtx.Windows.Forms.Button();
			this.exitButton = new Dtx.Windows.Forms.Button();
			this.registerButton = new Dtx.Windows.Forms.Button();
			this.resetButton = new Dtx.Windows.Forms.Button();
			this.passwordLabel = new Dtx.Windows.Forms.Label();
			this.passwordTextBox = new Dtx.Windows.Forms.TextBox();
			this.usernameTextBox = new Dtx.Windows.Forms.TextBox();
			this.usernameLabel = new Dtx.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// loginButton
			// 
			this.loginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.loginButton.Location = new System.Drawing.Point(130, 102);
			this.loginButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(118, 35);
			this.loginButton.TabIndex = 4;
			this.loginButton.Text = "&Login";
			this.loginButton.UseVisualStyleBackColor = true;
			this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
			// 
			// exitButton
			// 
			this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.exitButton.Location = new System.Drawing.Point(512, 103);
			this.exitButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(118, 35);
			this.exitButton.TabIndex = 7;
			this.exitButton.Text = "E&xit";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// registerButton
			// 
			this.registerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.registerButton.Location = new System.Drawing.Point(385, 103);
			this.registerButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.registerButton.Name = "registerButton";
			this.registerButton.Size = new System.Drawing.Size(118, 35);
			this.registerButton.TabIndex = 6;
			this.registerButton.Text = "Re&gister";
			this.registerButton.UseVisualStyleBackColor = true;
			this.registerButton.Click += new System.EventHandler(this.RegisterButton_Click);
			// 
			// resetButton
			// 
			this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.resetButton.Location = new System.Drawing.Point(258, 102);
			this.resetButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(118, 35);
			this.resetButton.TabIndex = 5;
			this.resetButton.Text = "&Reset";
			this.resetButton.UseVisualStyleBackColor = true;
			this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
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
			// passwordTextBox
			// 
			this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.passwordTextBox.Location = new System.Drawing.Point(130, 60);
			this.passwordTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.passwordTextBox.MaxLength = 40;
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.PasswordChar = '*';
			this.passwordTextBox.Size = new System.Drawing.Size(497, 28);
			this.passwordTextBox.TabIndex = 3;
			// 
			// usernameTextBox
			// 
			this.usernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.usernameTextBox.Location = new System.Drawing.Point(130, 18);
			this.usernameTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.usernameTextBox.MaxLength = 20;
			this.usernameTextBox.Name = "usernameTextBox";
			this.usernameTextBox.Size = new System.Drawing.Size(497, 28);
			this.usernameTextBox.TabIndex = 1;
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
			// LoginForm
			// 
			this.AcceptButton = this.loginButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.exitButton;
			this.ClientSize = new System.Drawing.Size(649, 129);
			this.ControlBox = false;
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.loginButton);
			this.Controls.Add(this.registerButton);
			this.Controls.Add(this.resetButton);
			this.Controls.Add(this.passwordLabel);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.usernameTextBox);
			this.Controls.Add(this.usernameLabel);
			this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.MaximumSize = new System.Drawing.Size(1245, 185);
			this.MinimumSize = new System.Drawing.Size(662, 185);
			this.Name = "LoginForm";
			this.Text = "Login";
			this.Load += new System.EventHandler(this.LoginForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Dtx.Windows.Forms.Button registerButton;
		private Dtx.Windows.Forms.Button resetButton;
		private Dtx.Windows.Forms.Label passwordLabel;
		private Dtx.Windows.Forms.TextBox passwordTextBox;
		private Dtx.Windows.Forms.TextBox usernameTextBox;
		private Dtx.Windows.Forms.Label usernameLabel;
		private Dtx.Windows.Forms.Button loginButton;
		private Dtx.Windows.Forms.Button exitButton;
	}
}
