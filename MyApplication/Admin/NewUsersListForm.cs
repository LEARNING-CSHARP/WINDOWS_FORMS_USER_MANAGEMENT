using System.Linq;

namespace MyApplication.Admin
{
	public partial class NewUsersListForm : Infrastructure.BaseForm
	{
		public NewUsersListForm()
		{
			InitializeComponent();
		}

		private void SearchButton_Click(object sender, System.EventArgs e)
		{
			Search();
		}

		private void Search()
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				// **************************************************
				fullNameTextBox.Text =
					fullNameTextBox.Text.Trim();

				while (fullNameTextBox.Text.Contains("  "))
				{
					fullNameTextBox.Text =
						fullNameTextBox.Text.Replace("  ", " ");
				}
				// **************************************************

				System.Collections.Generic.List<Models.User> users = null;

				if (fullNameTextBox.Text == string.Empty)
				{
					users =
						databaseContext.Users
						.OrderBy(current => current.FullName)
						.ToList()
						;
				}
				else
				{
					users =
						databaseContext.Users
						.Where(current => current.FullName.Contains(fullNameTextBox.Text))
						.OrderBy(current => current.FullName)
						.ToList()
						;
				}

				// **************************************************
				myDataGridView.DataSource = users;
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
	}
}
