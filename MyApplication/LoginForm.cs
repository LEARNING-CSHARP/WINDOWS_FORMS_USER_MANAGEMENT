using System.Linq;
using System.Data.Entity;

namespace MyApplication
{
	public partial class LoginForm : Infrastructure.BaseForm
	{
		public LoginForm() : base()
		{
			InitializeComponent();
		}

		private void LoginForm_Load(object sender, System.EventArgs e)
		{
		}

		private void loginButton_Click(object sender, System.EventArgs e)
		{
			// **************************************************
			// **************************************************
			// **************************************************
			if ((string.IsNullOrWhiteSpace(usernameTextBox.Text)) ||
				(string.IsNullOrWhiteSpace(passwordTextBox.Text)))
			{
				//usernameTextBox.Text =
				//	usernameTextBox.Text.Trim();

				//passwordTextBox.Text =
				//	passwordTextBox.Text.Trim();

				usernameTextBox.Text =
					usernameTextBox.Text.Replace(" ", string.Empty);

				passwordTextBox.Text =
					passwordTextBox.Text.Replace(" ", string.Empty);

				System.Windows.Forms.MessageBox.Show("Username and Password is requied!");

				if (usernameTextBox.Text == string.Empty)
				{
					usernameTextBox.Focus();
				}
				else
				{
					passwordTextBox.Focus();
				}

				return;
			}
			// **************************************************
			// **************************************************
			// **************************************************

			// از این قسمت به بعد باید سر کلاس نوشته شود

			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				Models.User foundedUser =
					databaseContext.Users
					.Where(current => string.Compare(current.Username, usernameTextBox.Text, true) == 0)
					.FirstOrDefault();

				if (foundedUser == null)
				{
					//System.Windows.Forms.MessageBox
					//	.Show("Username is not correct!");

					// دقت کنید که در این حالت پیغام باید گنگ باشد

					System.Windows.Forms.MessageBox
						.Show("Username and/or Password is not correct!");

					usernameTextBox.Focus();

					return;
				}

				if (string.Compare(foundedUser.Password, passwordTextBox.Text, ignoreCase: false) != 0)
				{
					//System.Windows.Forms.MessageBox
					//	.Show("Password is not correct!");

					// دقت کنید که در این حالت پیغام باید گنگ باشد

					System.Windows.Forms.MessageBox
						.Show("Username and/or Password is not correct!");

					usernameTextBox.Focus();

					return;
				}

				if (foundedUser.IsActive == false)
				{
					System.Windows.Forms.MessageBox
						.Show("You can not login to this application! Please contact support team.");

					usernameTextBox.Focus();

					return;
				}

				// **************************************************
				System.Windows.Forms.MessageBox.Show("Welcome!");
				// **************************************************

				// **************************************************
				//Infrastructure.Utility.AuthenticatedUser = foundedUser;

				//Hide();

				//MainForm mainForm = new MainForm();

				//mainForm.Show();
				// **************************************************
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show("Error: " + ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					databaseContext = null;
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

			//RegisterForm registerForm = new RegisterForm();

			//registerForm.Show();

			Infrastructure.Utility.RegisterForm.Show();
		}

		private void exitButton_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}
	}
}
