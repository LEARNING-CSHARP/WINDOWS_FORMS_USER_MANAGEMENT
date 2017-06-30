using System.Linq;
using System.Data.Entity;

namespace MyApplication
{
	public partial class ChangePasswordForm : Infrastructure.BaseForm
	{
		public ChangePasswordForm() : base()
		{
			InitializeComponent();
		}

		private void ChangePasswordForm_Load(object sender, System.EventArgs e)
		{
		}

		private void changePasswordButton_Click(object sender, System.EventArgs e)
		{
			string strErrorMessages = string.Empty;

			if (string.IsNullOrWhiteSpace(oldPasswordTextBox.Text))
			{
				strErrorMessages =
					"Old password is required!";
			}
			else
			{
				if (oldPasswordTextBox.Text.Length < 8)
				{
					strErrorMessages =
						"The old password length should be greater than or equal to 8 characters!";
				}
			}

			if (string.IsNullOrWhiteSpace(newPasswordTextBox.Text))
			{
				if (strErrorMessages != string.Empty)
				{
					strErrorMessages += System.Environment.NewLine;
				}

				strErrorMessages +=
					"New password is required!";
			}
			else
			{
				if (newPasswordTextBox.Text.Length < 8)
				{
					if (strErrorMessages != string.Empty)
					{
						strErrorMessages += System.Environment.NewLine;
					}

					strErrorMessages +=
						"The new password length should be greater than or equal to 8 characters!";
				}
			}

			if (string.IsNullOrWhiteSpace(confirmNewPasswordTextBox.Text))
			{
				if (strErrorMessages != string.Empty)
				{
					strErrorMessages += System.Environment.NewLine;
				}

				strErrorMessages +=
					"Confirm new password is required!";
			}
			else
			{
				if (string.Compare(confirmNewPasswordTextBox.Text, newPasswordTextBox.Text, ignoreCase: false) != 0)
				{
					if (strErrorMessages != string.Empty)
					{
						strErrorMessages += System.Environment.NewLine;
					}

					strErrorMessages +=
						"The confirm new password is not equal to new password!";
				}
			}

			if (strErrorMessages != string.Empty)
			{
				System.Windows.Forms.MessageBox.Show(strErrorMessages);

				return;
			}

			Models.DatabaseContext oDatabaseContext = null;

			try
			{
				oDatabaseContext =
					new Models.DatabaseContext();

				Models.User oUser =
					oDatabaseContext.Users
					.Where(current => current.Id == Infrastructure.Utility.AuthenticatedUser.Id)
					.FirstOrDefault();

				if (oUser == null)
				{
					System.Windows.Forms.Application.Exit();
				}

				if (string.Compare(oUser.Password, oldPasswordTextBox.Text, ignoreCase: false) != 0)
				{
					System.Windows.Forms.MessageBox.Show("Old password is not correct!");

					oldPasswordTextBox.Focus();

					return;
				}

				oUser.Password = newPasswordTextBox.Text;

				oDatabaseContext.SaveChanges();

				System.Windows.Forms.MessageBox.Show("Your password was changed successfully.");
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
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
	}
}
