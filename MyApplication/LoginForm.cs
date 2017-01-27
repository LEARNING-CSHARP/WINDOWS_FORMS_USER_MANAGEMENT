using System.Linq;
using System.Data.Entity;

namespace MyApplication
{
	public partial class LoginForm : Infrastructure.BaseForm
	{
		public LoginForm()
			: base()
		{
			InitializeComponent();
		}

		private void LoginForm_Load(object sender, System.EventArgs e)
		{
		}

		private void loginButton_Click(object sender, System.EventArgs e)
		{
			// **************************************************
			if ((string.IsNullOrWhiteSpace(usernameTextBox.Text)) ||
				(string.IsNullOrWhiteSpace(passwordTextBox.Text)))
			{
				usernameTextBox.Text =
					usernameTextBox.Text.Trim();

				passwordTextBox.Text =
					passwordTextBox.Text.Trim();

				if (usernameTextBox.Text == string.Empty)
				{
					usernameTextBox.Focus();
				}
				else
				{
					passwordTextBox.Focus();
				}

				System.Windows.Forms.MessageBox.Show("Username and Password is requied!");

				return;
			}
			// **************************************************

			Models.DatabaseContext oDatabaseContext = null;

			try
			{
				oDatabaseContext =
					new Models.DatabaseContext();

				Models.User oUser =
					oDatabaseContext.Users
					.Where(current => string.Compare(current.Username, usernameTextBox.Text, true) == 0)
					.FirstOrDefault();

				if (oUser == null)
				{
					System.Windows.Forms.MessageBox
						.Show("Username and/or Password is not correct!");

					return;
				}

				if (string.Compare(oUser.Password, passwordTextBox.Text, ignoreCase: false) != 0)
				{
					System.Windows.Forms.MessageBox
						.Show("Username and/or Password is not correct!");

					return;
				}

				if (oUser.IsActive == false)
				{
					System.Windows.Forms.MessageBox
						.Show("You can not login to this application! Please contact support.");

					return;
				}

				Infrastructure.Utility.AuthenticatedUser = oUser;

				Hide();

				MainForm mainForm = new MainForm();

				mainForm.Show();
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show("Error: " + ex.Message);
			}
			finally
			{
				if (oDatabaseContext != null)
				{
					oDatabaseContext.Dispose();
					oDatabaseContext = null;
				}
			}
		}

		private void resetButton_Click(object sender, System.EventArgs e)
		{
			passwordTextBox.Text = string.Empty;
			usernameTextBox.Text = string.Empty;

			usernameTextBox.Focus();
		}

		private void registerButton_Click(object sender, System.EventArgs e)
		{
			Hide();

			RegisterForm registerForm = new RegisterForm();

			registerForm.Show();
		}

		private void exitButton_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}
	}
}
