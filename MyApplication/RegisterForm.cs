using System.Linq;

namespace MyApplication
{
	public partial class RegisterForm : Infrastructure.BaseForm
	{
		public RegisterForm()
		{
			InitializeComponent();
		}

		private void RegisterForm_Load(object sender, System.EventArgs e)
		{
		}

		private void registerButton_Click(object sender, System.EventArgs e)
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
			string errorMessages = string.Empty;

			if (usernameTextBox.Text.Length < 6)
			{
				errorMessages =
					"Username length should be at least 6 characters!";
			}

			if (passwordTextBox.Text.Length < 8)
			{
				if (errorMessages != string.Empty)
				{
					errorMessages +=
						System.Environment.NewLine;
				}

				errorMessages +=
					"Password length should be at least 8 characters!";
			}

			// اگر خطایی وجود داشت
			if (errorMessages != string.Empty)
			{
				System.Windows.Forms.MessageBox.Show(errorMessages);

				return;
			}
			// **************************************************
			// **************************************************
			// **************************************************

			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				//Models.User user =
				//	databaseContext.Users
				//	.Where(current => current.Username == usernameTextBox.Text)
				//	.FirstOrDefault();

				Models.User user =
					databaseContext.Users
					.Where(current => string.Compare(current.Username, usernameTextBox.Text, true) == 0)
					.FirstOrDefault();

				//Models.User user =
				//	databaseContext.Users
				//	.Where(current => string.Compare(current.Username, usernameTextBox.Text, true) == 0)
				//	.First();

				//Models.User user =
				//	databaseContext.Users
				//	.Where(current => string.Compare(current.Username, usernameTextBox.Text, true) == 0)
				//	.Single();

				if (user != null)
				{
					System.Windows.Forms.MessageBox.Show
						("This username is already exist! Please choose another one...");

					usernameTextBox.Focus();

					return;
				}

				user = new Models.User();

				user.FullName = fullNameTextBox.Text;
				user.Password = passwordTextBox.Text;
				user.Username = usernameTextBox.Text;

				user.IsActive = true; // بستگی به سناریو و قواعد شرکت یا پروژه دارد

				databaseContext.Users.Add(user);

				databaseContext.SaveChanges();

				System.Windows.Forms.MessageBox.Show("Registration Done!");

				fullNameTextBox.Text = string.Empty;
				passwordTextBox.Text = string.Empty;
				usernameTextBox.Text = string.Empty;

				usernameTextBox.Focus();
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
			usernameTextBox.Text = string.Empty;
			passwordTextBox.Text = string.Empty;
			fullNameTextBox.Text = string.Empty;

			usernameTextBox.Focus();
		}

		private void exitButton_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}
	}
}
