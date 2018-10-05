namespace Models
{
	public class User : BaseEntity
	{
		public User() : base()
		{
		}

		// **********
		public bool IsActive { get; set; }
		// **********

		// **********
		public bool IsAdmin { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 20, MinimumLength = 6)]

		[System.ComponentModel.DataAnnotations.Schema.Index
			(IsUnique = true)]
		public string Username { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 40, MinimumLength = 8)]
		public string Password { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 50)]

		[System.ComponentModel.DataAnnotations.Schema.Index
			(IsUnique = false)]
		public string FullName { get; set; }
		// **********

		// **********
		public string Description { get; set; }
		// **********

		// **********
		public string DisplayName
		{
			get
			{
				string result = string.Empty;

				if (string.IsNullOrWhiteSpace(FullName) == false)
				{
					result = FullName;
				}

				if (result != string.Empty)
				{
					result += " - ";
				}

				result += $"[{ Username }]";

				if (IsActive)
				{
					result += " [Enabled]";
				}
				else
				{
					result += " [Disabled]";
				}

				if (IsAdmin)
				{
					result += " [Admin]";
				}
				else
				{
					result += " [User]";
				}

				return result;
			}
		}
		// **********
	}
}
