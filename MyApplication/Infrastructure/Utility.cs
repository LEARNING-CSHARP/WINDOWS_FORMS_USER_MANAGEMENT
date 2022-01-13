//namespace MyApplication.Infrastructure
namespace Infrastructure
{
	public static class Utility
	{
		static Utility()
		{
			// Solution (3)
			//MainForm = new MyApplication.MainForm();
			//LoginForm = new MyApplication.LoginForm();
			//RegisterForm = new MyApplication.RegisterForm();
			// /Solution (3)
		}

		// **************************************************
		// **************************************************
		// **************************************************
		//public static string FullName { get; set; }
		//public static string Username { get; set; }
		//public static System.Guid? UserId { get; set; }
		// **************************************************

		// **************************************************
		public static Models.User AuthenticatedUser { get; set; }
		// **************************************************
		// **************************************************
		// **************************************************

		// **************************************************
		// Solution (1)
		// **************************************************
		//public static MyApplication.MainForm MainForm;
		//public static MyApplication.LoginForm LoginForm;
		//public static MyApplication.RegisterForm RegisterForm;
		// **************************************************
		// /Solution (1)
		// **************************************************

		// **************************************************
		// Solution (2)
		// **************************************************
		//public static MyApplication.MainForm MainForm = new MyApplication.MainForm();
		//public static MyApplication.LoginForm LoginForm = new MyApplication.LoginForm();
		//public static MyApplication.RegisterForm RegisterForm = new MyApplication.RegisterForm();
		// **************************************************
		// /Solution (2)
		// **************************************************

		// **************************************************
		// Solution (3)
		// **************************************************
		//public static MyApplication.MainForm MainForm;
		//public static MyApplication.LoginForm LoginForm;
		//public static MyApplication.RegisterForm RegisterForm;
		// **************************************************
		// /Solution (3)
		// **************************************************

		// **************************************************
		// Solution (4)
		// **************************************************
		// **************************************************
		// **************************************************
		private static MyApplication.LoginForm loginForm;
		// **************************************************

		// **************************************************
		/// <summary>
		/// Lazy Loading = Lazy Initialization
		/// </summary>
		public static MyApplication.LoginForm LoginForm
		{
			get
			{
				if (loginForm == null || loginForm.IsDisposed)
				{
					loginForm =
						new MyApplication.LoginForm();
				}

				return loginForm;
			}
		}
		// **************************************************

		// **************************************************
		public static void DisposeLoginForm()
		{
			if (loginForm != null)
			{
				if (loginForm.IsDisposed == false)
				{
					loginForm.Dispose();
				}

				loginForm = null;
			}
		}
		// **************************************************
		// **************************************************
		// **************************************************

		// **************************************************
		// **************************************************
		// **************************************************
		private static MyApplication.RegisterForm registerForm;
		// **************************************************

		// **************************************************
		/// <summary>
		/// Lazy Loading = Lazy Initialization
		/// </summary>
		public static MyApplication.RegisterForm RegisterForm
		{
			get
			{
				if (registerForm == null || registerForm.IsDisposed)
				{
					registerForm =
						new MyApplication.RegisterForm();
				}

				return registerForm;
			}
		}
		// **************************************************

		// **************************************************
		public static void DisposeRegisterForm()
		{
			if (registerForm != null)
			{
				if (registerForm.IsDisposed == false)
				{
					registerForm.Dispose();
				}

				registerForm = null;
			}
		}
		// **************************************************
		// **************************************************
		// **************************************************

		// **************************************************
		// **************************************************
		// **************************************************
		private static MyApplication.MainForm mainForm;
		// **************************************************

		// **************************************************
		/// <summary>
		/// Lazy Loading = Lazy Initialization
		/// </summary>
		public static MyApplication.MainForm MainForm
		{
			get
			{
				if (mainForm == null || mainForm.IsDisposed)
				{
					mainForm =
						new MyApplication.MainForm();
				}

				return mainForm;
			}
		}
		// **************************************************

		// **************************************************
		public static void DisposeMainForm()
		{
			if (mainForm != null)
			{
				if (mainForm.IsDisposed == false)
				{
					mainForm.Dispose();
				}

				mainForm = null;
			}
		}
		// **************************************************
		// **************************************************
		// **************************************************
		// /Solution (4)
		// **************************************************

		public static string FixText(string text)
		{
			if (text == null)
			{
				return null;
			}

			text =
				text.Trim();

			if (text == string.Empty)
			{
				return null;
			}

			// تا وقتی که در داخل متن، دو فاصله وجود دارد
			// دو فاصله را به یک فاصله تبدیل کن
			while (text.Contains("  "))
			{
				text =
					text.Replace("  ", " ");
			}

			return text;
		}
	}
}
