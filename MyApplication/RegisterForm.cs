namespace MyApplication
{
	public partial class RegisterForm : System.Windows.Forms.Form
	{
		public RegisterForm()
		{
			InitializeComponent();
		}

		private void RegisterForm_Load(object sender, System.EventArgs e)
		{

		}

		private void SubmitButton_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.MessageBox.Show("Hello, World!");
		}

		private void ResetButton_Click(object sender, System.EventArgs e)
		{
			UsernameTextBox.Text = string.Empty;
			PasswordTextBox.Text = string.Empty;
			FullNameTextBox.Text = string.Empty;
		}
	}
}
