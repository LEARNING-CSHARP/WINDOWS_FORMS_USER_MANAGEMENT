namespace Dtx.Windows.Forms
{
	public class Button : System.Windows.Forms.Button
	{
		public Button() : base()
		{
			BackColor = System.Drawing.Color.LightGray;
			HoverBackColor = System.Drawing.Color.Yellow;
		}

		protected System.Drawing.Color CurrentBackColor { get; set; }

		[System.ComponentModel.DefaultValue(typeof(System.Drawing.Color), "Yellow")]
		public System.Drawing.Color HoverBackColor { get; set; }

		[System.ComponentModel.DefaultValue(typeof(System.Drawing.Color), "LightGray")]
		public override System.Drawing.Color BackColor
		{
			get => base.BackColor;
			set => base.BackColor = value;
		}

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
