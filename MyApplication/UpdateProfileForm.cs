using System.Linq;

namespace MyApplication
{
	public partial class UpdateProfileForm : Infrastructure.BaseForm
	{
		public UpdateProfileForm()
		{
			InitializeComponent();
		}

		private void UpdateProfileForm_Load(object sender, System.EventArgs e)
		{
			ResetForm();
		}

		private void ResetForm()
		{
			// **************************************************
			//fullNameTextBox.Text =
			//	Infrastructure.Utility.AuthenticatedUser.FullName;

			//descriptionTextBox.Text =
			//	Infrastructure.Utility.AuthenticatedUser.Description;
			// **************************************************

			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				var currentUser =
					databaseContext.Users
					.Where(current => current.Id == Infrastructure.Utility.AuthenticatedUser.Id)
					.FirstOrDefault();

				// **************************************************
				if (currentUser == null)
				{
					System.Windows.Forms.Application.Exit();
				}

				if (currentUser.IsActive == false)
				{
					System.Windows.Forms.Application.Exit();
				}
				// **************************************************

				fullNameTextBox.Text =
					currentUser.FullName;

				descriptionTextBox.Text =
					currentUser.Description;
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show($"Error: {ex.Message}");
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

		private void SaveButton_Click(object sender, System.EventArgs e)
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				var currentUser =
					databaseContext.Users
					.Where(current => current.Id == Infrastructure.Utility.AuthenticatedUser.Id)
					.FirstOrDefault();

				// **************************************************
				if (currentUser == null)
				{
					System.Windows.Forms.Application.Exit();
				}

				if (currentUser.IsActive == false)
				{
					System.Windows.Forms.Application.Exit();
				}
				// **************************************************

				currentUser.FullName =
					fullNameTextBox.Text;

				currentUser.Description =
					descriptionTextBox.Text;

				databaseContext.SaveChanges();

				// **************************************************
				Infrastructure.Utility.AuthenticatedUser = currentUser;

				Infrastructure.Utility.MainForm.ResetForm();
				// **************************************************

				System.Windows.Forms.MessageBox
					.Show("Your profile updated successfully...");

				// استفاده کنیم Close فرم به طور اتوماتیک بسته شود، می‌توانیم از دستور MessageBox اگر بخواهیم بعد از UpdateProfileForm در داخل
				//Close();
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show($"Error: {ex.Message}");
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
	}
}
