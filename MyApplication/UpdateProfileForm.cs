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

				fullNameTextBox.Text = oUser.FullName;
				descriptionTextBox.Text = oUser.Description;
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

		private void saveButton_Click(object sender, System.EventArgs e)
		{
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

				oUser.FullName = fullNameTextBox.Text;
				oUser.Description = descriptionTextBox.Text;

				oDatabaseContext.SaveChanges();

				Infrastructure.Utility.AuthenticatedUser = oUser;

				System.Windows.Forms.MessageBox
					.Show("Your profile was updated successfully...");
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
	}
}
