namespace Dtx.Windows.Forms
{
	public class TextBox : System.Windows.Forms.TextBox
	{
		public TextBox() : base()
		{
			HoverBackColor = System.Drawing.Color.LightGray;
		}

		protected System.Drawing.Color CurrentBackColor { get; set; }

		[System.ComponentModel.DefaultValue(typeof(System.Drawing.Color), "LightGray")]
		public System.Drawing.Color HoverBackColor { get; set; }

		protected override void OnMouseEnter(System.EventArgs e)
		{
			base.OnMouseEnter(e);

			CurrentBackColor = BackColor;
			BackColor = HoverBackColor;
		}

		protected override void OnMouseLeave(System.EventArgs e)
		{
			base.OnMouseEnter(e);

			BackColor = CurrentBackColor;
		}
	}
}
