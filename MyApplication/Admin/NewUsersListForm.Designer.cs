namespace MyApplication.Admin
{
	partial class NewUsersListForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.searchButton = new Dtx.Windows.Forms.Button();
			this.fullNameLabel = new Dtx.Windows.Forms.Label();
			this.fullNameTextBox = new Dtx.Windows.Forms.TextBox();
			this.myDataGridView = new Dtx.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.myDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// searchButton
			// 
			this.searchButton.Location = new System.Drawing.Point(81, 39);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(75, 23);
			this.searchButton.TabIndex = 5;
			this.searchButton.Text = "&Search";
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
			// 
			// fullNameLabel
			// 
			this.fullNameLabel.AutoSize = true;
			this.fullNameLabel.ForeColor = System.Drawing.Color.White;
			this.fullNameLabel.Location = new System.Drawing.Point(12, 15);
			this.fullNameLabel.Name = "fullNameLabel";
			this.fullNameLabel.Size = new System.Drawing.Size(63, 13);
			this.fullNameLabel.TabIndex = 3;
			this.fullNameLabel.Text = "&Full Name";
			// 
			// fullNameTextBox
			// 
			this.fullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.fullNameTextBox.Location = new System.Drawing.Point(81, 12);
			this.fullNameTextBox.Name = "fullNameTextBox";
			this.fullNameTextBox.Size = new System.Drawing.Size(396, 21);
			this.fullNameTextBox.TabIndex = 4;
			// 
			// myDataGridView
			// 
			this.myDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.myDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.myDataGridView.Location = new System.Drawing.Point(12, 68);
			this.myDataGridView.Name = "myDataGridView";
			this.myDataGridView.Size = new System.Drawing.Size(465, 298);
			this.myDataGridView.TabIndex = 6;
			// 
			// NewUsersListForm
			// 
			this.AcceptButton = this.searchButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.ClientSize = new System.Drawing.Size(489, 378);
			this.Controls.Add(this.myDataGridView);
			this.Controls.Add(this.searchButton);
			this.Controls.Add(this.fullNameLabel);
			this.Controls.Add(this.fullNameTextBox);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "NewUsersListForm";
			((System.ComponentModel.ISupportInitialize)(this.myDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Dtx.Windows.Forms.Button searchButton;
		private Dtx.Windows.Forms.Label fullNameLabel;
		private Dtx.Windows.Forms.TextBox fullNameTextBox;
		private Dtx.Windows.Forms.DataGridView myDataGridView;
	}
}
