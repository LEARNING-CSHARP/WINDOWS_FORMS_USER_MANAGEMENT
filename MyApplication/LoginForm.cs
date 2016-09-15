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

		private void LoginButton_Click(object sender, System.EventArgs e)
		{
			// **************************************************
			if ((string.IsNullOrWhiteSpace(UsernameTextBox.Text)) ||
				(string.IsNullOrWhiteSpace(PasswordTextBox.Text)))
			{
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
					.Where(current => string.Compare(current.Username, UsernameTextBox.Text, true) == 0)
					.FirstOrDefault();

				if (oUser == null)
				{
					System.Windows.Forms.MessageBox.Show("Username and/or Password is not correct!");
					return;
				}

				if (string.Compare(oUser.Password, PasswordTextBox.Text, ignoreCase: false) != 0)
				{
					System.Windows.Forms.MessageBox.Show("Username and/or Password is not correct!");
					return;
				}

				if (oUser.IsActive == false)
				{
					System.Windows.Forms.MessageBox.Show("You can not login to this application! Please contact support.");
					return;
				}

				Infrastructure.Utility.AuthenticatedUser = oUser;

				Hide();

				MainForm frmMain = new MainForm();

				frmMain.Show();
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

		private void ResetButton_Click(object sender, System.EventArgs e)
		{
			PasswordTextBox.Text = string.Empty;
			UsernameTextBox.Text = string.Empty;

			UsernameTextBox.Focus();
		}

		private void RegisterButton_Click(object sender, System.EventArgs e)
		{
			Hide();

			RegisterForm frmRegister = new RegisterForm();

			frmRegister.Show();
		}
	}
}
