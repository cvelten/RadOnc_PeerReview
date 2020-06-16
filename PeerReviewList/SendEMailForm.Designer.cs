namespace PeerReview
{
	partial class SendEMailForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendEMailForm));
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOk = new System.Windows.Forms.Button();
			this.checkedListBoxEMail = new System.Windows.Forms.CheckedListBox();
			this.labelSelectRecipients = new System.Windows.Forms.Label();
			this.buttonAll = new System.Windows.Forms.Button();
			this.buttonNone = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCancel.Location = new System.Drawing.Point(216, 326);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 4;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// buttonOk
			// 
			this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonOk.Location = new System.Drawing.Point(297, 326);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(75, 23);
			this.buttonOk.TabIndex = 3;
			this.buttonOk.Text = "OK";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
			// 
			// checkedListBoxEMail
			// 
			this.checkedListBoxEMail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.checkedListBoxEMail.CheckOnClick = true;
			this.checkedListBoxEMail.FormattingEnabled = true;
			this.checkedListBoxEMail.Location = new System.Drawing.Point(12, 25);
			this.checkedListBoxEMail.Name = "checkedListBoxEMail";
			this.checkedListBoxEMail.ScrollAlwaysVisible = true;
			this.checkedListBoxEMail.Size = new System.Drawing.Size(360, 289);
			this.checkedListBoxEMail.TabIndex = 5;
			this.checkedListBoxEMail.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CheckedListBoxEMail_ItemCheck);
			// 
			// labelSelectRecipients
			// 
			this.labelSelectRecipients.AutoSize = true;
			this.labelSelectRecipients.Location = new System.Drawing.Point(12, 9);
			this.labelSelectRecipients.Name = "labelSelectRecipients";
			this.labelSelectRecipients.Size = new System.Drawing.Size(119, 13);
			this.labelSelectRecipients.TabIndex = 6;
			this.labelSelectRecipients.Text = "Select EMail Recipients";
			// 
			// buttonAll
			// 
			this.buttonAll.Location = new System.Drawing.Point(12, 326);
			this.buttonAll.Name = "buttonAll";
			this.buttonAll.Size = new System.Drawing.Size(75, 23);
			this.buttonAll.TabIndex = 7;
			this.buttonAll.Text = "Select All";
			this.buttonAll.UseVisualStyleBackColor = true;
			this.buttonAll.Click += new System.EventHandler(this.buttonAll_Click);
			// 
			// buttonNone
			// 
			this.buttonNone.Location = new System.Drawing.Point(93, 326);
			this.buttonNone.Name = "buttonNone";
			this.buttonNone.Size = new System.Drawing.Size(75, 23);
			this.buttonNone.TabIndex = 8;
			this.buttonNone.Text = "Select None";
			this.buttonNone.UseVisualStyleBackColor = true;
			this.buttonNone.Click += new System.EventHandler(this.buttonNone_Click);
			// 
			// SendEMailForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 361);
			this.Controls.Add(this.buttonNone);
			this.Controls.Add(this.buttonAll);
			this.Controls.Add(this.labelSelectRecipients);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.checkedListBoxEMail);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "SendEMailForm";
			this.Text = "Send EMail To...";
			this.Load += new System.EventHandler(this.SendEMailForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.CheckedListBox checkedListBoxEMail;
		private System.Windows.Forms.Label labelSelectRecipients;
		private System.Windows.Forms.Button buttonAll;
		private System.Windows.Forms.Button buttonNone;
	}
}