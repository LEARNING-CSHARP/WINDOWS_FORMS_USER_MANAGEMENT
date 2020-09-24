using System.Linq;

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
			ResetForm();
		}

		private void LoginButton_Click(object sender, System.EventArgs e)
		{
			// **************************************************
			// **************************************************
			// **************************************************
			if (string.IsNullOrWhiteSpace(usernameTextBox.Text) ||
				string.IsNullOrWhiteSpace(passwordTextBox.Text))
			{
				System.Windows.Forms.MessageBox.Show("Username and Password are requied!");

				//usernameTextBox.Text =
				//	usernameTextBox.Text.Trim();

				//passwordTextBox.Text =
				//	passwordTextBox.Text.Trim();

				usernameTextBox.Text =
					usernameTextBox.Text.Replace(" ", string.Empty);

				passwordTextBox.Text =
					passwordTextBox.Text.Replace(" ", string.Empty);

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

				//Models.User foundedUser =
				//	databaseContext.Users
				//	.Where(current => current.Username == usernameTextBox.Text)
				//	.FirstOrDefault();

				//Models.User foundedUser =
				//	databaseContext.Users
				//	.Where(current => string.Compare(current.Username, usernameTextBox.Text, true) == 0)
				//	.FirstOrDefault();

				Models.User foundedUser =
					databaseContext.Users
					.Where(current => current.Username.ToLower() == usernameTextBox.Text.ToLower())
					.FirstOrDefault();

				if (foundedUser == null)
				{
					// پیغام ذیل کاملا دقیق بوده ولی از نظر مسایل امنیتی صلاح نیست

					//System.Windows.Forms.MessageBox
					//	.Show("Username is not correct!");

					// دقت کنید که در این حالت، پیغام باید گنگ باشد

					System.Windows.Forms.MessageBox
						.Show("Username and/or Password is not correct!");

					usernameTextBox.Focus();

					return;
				}

				if (string.Compare(foundedUser.Password, passwordTextBox.Text, ignoreCase: false) != 0)
				{
					// پیغام ذیل کاملا دقیق بوده ولی از نظر مسایل امنیتی صلاح نیست

					//System.Windows.Forms.MessageBox
					//	.Show("Password is not correct!");

					// دقت کنید که در این حالت نیز، پیغام باید گنگ باشد

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
				//System.Windows.Forms.MessageBox.Show("Welcome!");
				// **************************************************

				// **************************************************
				// **************************************************
				// **************************************************
				Infrastructure.Utility.AuthenticatedUser = foundedUser;
				// **************************************************

				// **************************************************
				//Hide();

				//MainForm mainForm = new MainForm();

				//mainForm.Show();
				// **************************************************

				// **************************************************
				Hide();

				Infrastructure.Utility.MainForm.ResetForm();

				Infrastructure.Utility.MainForm.Show();
				// **************************************************
				// **************************************************
				// **************************************************
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show($"Error: { ex.Message }");
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

		private void ResetButton_Click(object sender, System.EventArgs e)
		{
			ResetForm();
		}

		public void ResetForm()
		{
			Infrastructure.Utility.AuthenticatedUser = null;

			passwordTextBox.Text = string.Empty;
			usernameTextBox.Text = string.Empty;

			usernameTextBox.Focus();
		}

		private void RegisterButton_Click(object sender, System.EventArgs e)
		{
			// **************************************************
			// توجه: دستورات ذیل به درد نمی‌خورد
			// **************************************************
			//Close();

			//RegisterForm registerForm = new RegisterForm();

			//registerForm.Show();
			// **************************************************

			// **************************************************
			// توجه: دستورات ذیل کار می‌کند، ولی اصلا بهینه نیست، چون پدر حافظه را درمی‌آورد
			// **************************************************
			//Hide();

			//RegisterForm registerForm = new RegisterForm();

			//registerForm.Show();
			// **************************************************

			// **************************************************
			Hide();

			Infrastructure.Utility.RegisterForm.Show();
			// **************************************************
		}

		private void ExitButton_Click(object sender, System.EventArgs e)
		{
			//Close();

			System.Windows.Forms.Application.Exit();
		}
	}
}
