// Note: برای دیدن و بکاربردن دستورات لینک باید دستور ذیل نوشته شود
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

		private void RegisterButton_Click(object sender, System.EventArgs e)
		{
			// **************************************************
			// **************************************************
			// **************************************************
			if (string.IsNullOrWhiteSpace(usernameTextBox.Text) ||
				string.IsNullOrWhiteSpace(passwordTextBox.Text))
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
			string errorMessages = string.Empty; // ""

			if (usernameTextBox.Text.Length < 6)
			{
				errorMessages =
					"Username length should be at least 6 characters!";
			}
			// **************************************************

			// **************************************************
			if (passwordTextBox.Text.Length < 8)
			{
				if (errorMessages != string.Empty)
				{
					errorMessages +=
						System.Environment.NewLine; // "\r\n"
				}

				errorMessages +=
					"Password length should be at least 8 characters!";
			}
			// **************************************************

			// **************************************************
			// اگر خطایی وجود داشت
			if (errorMessages != string.Empty)
			{
				System.Windows.Forms.MessageBox.Show(errorMessages);

				return;
			}
			// **************************************************
			// **************************************************
			// **************************************************

			// از این قسمت به بعد باید سر کلاس نوشته شود
			// در ضمن، دقت کنید، چون دستورات فوق را سر کلاس نباید بنویسید
			// در زمان ورود اطلاعات برای ثبت‌نام، داده‌های درستی را خودتان وارد کنید

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

				if (user != null)
				{
					System.Windows.Forms.MessageBox.Show
						("This username is already exist! Please choose another one...");

					usernameTextBox.Focus();

					return;
				}

				user = new Models.User
				{
					FullName = fullNameTextBox.Text,
					Password = passwordTextBox.Text,
					Username = usernameTextBox.Text,

					// بستگی به سناریو و قواعد و قوانین شرکت یا پروژه دارد
					IsActive = true,
				};

				databaseContext.Users.Add(user);

				databaseContext.SaveChanges();

				// **************************************************
				//fullNameTextBox.Text = string.Empty;
				//passwordTextBox.Text = string.Empty;
				//usernameTextBox.Text = string.Empty;

				//usernameTextBox.Focus();
				// **************************************************

				// **************************************************
				// دقت داشته باشید، هر چند که دستور ذیل کاملا صحیح می‌باشد
				// ولی شیک‌تر آن است که از تابع بعدی استفاده نماییم
				//ResetButton_Click(null, null);
				// **************************************************

				// **************************************************
				ResetForm();
				// **************************************************

				System.Windows.Forms.MessageBox.Show("Registration Done!");
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

		private void ResetButton_Click(object sender, System.EventArgs e)
		{
			// **************************************************
			//usernameTextBox.Text = string.Empty;
			//passwordTextBox.Text = string.Empty;
			//fullNameTextBox.Text = string.Empty;

			//usernameTextBox.Focus();
			// **************************************************

			ResetForm();
		}

		public void ResetForm()
		{
			usernameTextBox.Text = string.Empty;
			passwordTextBox.Text = string.Empty;
			fullNameTextBox.Text = string.Empty;

			usernameTextBox.Focus();
		}

		private void LoginButton_Click(object sender, System.EventArgs e)
		{
			Hide();

			Infrastructure.Utility.LoginForm.Show();
		}

		private void ExitButton_Click(object sender, System.EventArgs e)
		{
			//Close();

			System.Windows.Forms.Application.Exit();
		}
	}
}
