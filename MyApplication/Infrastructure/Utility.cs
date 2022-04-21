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
		private static MyApplication.LoginForm _loginForm;
		// **************************************************

		// **************************************************
		/// <summary>
		/// Lazy Loading = Lazy Initialization
		/// </summary>
		public static MyApplication.LoginForm LoginForm
		{
			get
			{
				if (_loginForm == null || _loginForm.IsDisposed)
				{
					_loginForm =
						new MyApplication.LoginForm();
				}

				return _loginForm;
			}
		}
		// **************************************************

		// **************************************************
		public static void DisposeLoginForm()
		{
			if (_loginForm != null)
			{
				if (_loginForm.IsDisposed == false)
				{
					_loginForm.Dispose();
				}

				_loginForm = null;
			}
		}
		// **************************************************
		// **************************************************
		// **************************************************

		// **************************************************
		// **************************************************
		// **************************************************
		private static MyApplication.RegisterForm _registerForm;
		// **************************************************

		// **************************************************
		/// <summary>
		/// Lazy Loading = Lazy Initialization
		/// </summary>
		public static MyApplication.RegisterForm RegisterForm
		{
			get
			{
				if (_registerForm == null || _registerForm.IsDisposed)
				{
					_registerForm =
						new MyApplication.RegisterForm();
				}

				return _registerForm;
			}
		}
		// **************************************************

		// **************************************************
		public static void DisposeRegisterForm()
		{
			if (_registerForm != null)
			{
				if (_registerForm.IsDisposed == false)
				{
					_registerForm.Dispose();
				}

				_registerForm = null;
			}
		}
		// **************************************************
		// **************************************************
		// **************************************************

		// **************************************************
		// **************************************************
		// **************************************************
		private static MyApplication.MainForm _mainForm;
		// **************************************************

		// **************************************************
		/// <summary>
		/// Lazy Loading = Lazy Initialization
		/// </summary>
		public static MyApplication.MainForm MainForm
		{
			get
			{
				if (_mainForm == null || _mainForm.IsDisposed)
				{
					_mainForm =
						new MyApplication.MainForm();
				}

				return _mainForm;
			}
		}
		// **************************************************

		// **************************************************
		public static void DisposeMainForm()
		{
			if (_mainForm != null)
			{
				if (_mainForm.IsDisposed == false)
				{
					_mainForm.Dispose();
				}

				_mainForm = null;
			}
		}
		// **************************************************
		// **************************************************
		// **************************************************
		// /Solution (4)
		// **************************************************

		public static string FixText(string text)
		{
			if(string.IsNullOrWhiteSpace(text))
			{
				return null;
			}

			text =
				text.Trim();

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
