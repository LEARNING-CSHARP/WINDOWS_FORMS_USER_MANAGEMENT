using System.Linq;

namespace MyApplication.Admin
{
	public partial class UpdateUserForm : Infrastructure.BaseForm
	{
		public UpdateUserForm()
		{
			InitializeComponent();
		}

		public Models.User User { get; set; }
		//public System.Guid UserId { get; set; }

		private void UpdateUserForm_Load(object sender, System.EventArgs e)
		{
			Models.DatabaseContext oDatabaseContext = null;

			try
			{
				oDatabaseContext =
					new Models.DatabaseContext();

				Models.User oUser =
					oDatabaseContext.Users
					.Where(current => current.Id == User.Id)
					//.Where(current => current.Id == UserId)
					.FirstOrDefault();

				if (oUser == null)
				{
					System.Windows.Forms.MessageBox.Show("There is no such a user!");

					Close();
				}

				isAdminCheckBox.Checked = oUser.IsAdmin;
				isActiveCheckBox.Checked = oUser.IsActive;

				fullNameTextBox.Text = oUser.FullName;
				descriptionTextBox.Text = oUser.Description;
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);

				Close();
			}
			finally
			{
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
					.Where(current => current.Id == User.Id)
					//.Where(current => current.Id == UserId)
					.FirstOrDefault();

				if (oUser == null)
				{
					System.Windows.Forms.MessageBox.Show("There is no such a user!");

					Close();
				}

				oUser.IsAdmin = isAdminCheckBox.Checked;
				oUser.IsActive = isActiveCheckBox.Checked;

				oUser.FullName = fullNameTextBox.Text;
				oUser.Description = descriptionTextBox.Text;

				oDatabaseContext.SaveChanges();

				Close();
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);

				Close();
			}
			finally
			{
			}
		}
	}
}
