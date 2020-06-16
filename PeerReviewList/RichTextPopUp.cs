using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeerReview
{
	public partial class RichTextPopUp : Form
	{
		public RichTextPopUp()
		{
			InitializeComponent();
		}

		public string FormTitle { get { return this.Text; } set { this.Text=value; } }
		public string TextBoxValue { get {return richTextBox.Text;} set { richTextBox.Text = value; } }

		private void buttonCopy_Click(object sender, EventArgs e)
		{
			richTextBox.SelectAll();
			richTextBox.Copy();
		}

		private void buttonClose_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
