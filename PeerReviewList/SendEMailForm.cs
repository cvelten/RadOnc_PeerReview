using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AddressBook = PeerReview.AddressBookSection.AddressBook;

namespace PeerReview
{
	public partial class SendEMailForm : Form
	{
		public SendEMailForm(AddressBook addressBook)
		{
			InitializeComponent();

			AddressBook = addressBook;

			AddressBook.Groups[] groups =
			{
				AddressBook.Groups.Attendings, AddressBook.Groups.ResidentsMedical, AddressBook.Groups.Physicists,
				AddressBook.Groups.ResidentsPhysics, AddressBook.Groups.Dosimetrists, AddressBook.Groups.None
			};
			foreach (var group in groups)
			{
				foreach (var card in addressBook.GetGroup(group).OrderBy(c => c.EMail).ToList())
				{
					checkedListBoxEMail.Items.Add(card);
				}
			}
		}

		public AddressBook AddressBook { get; }

		private void SetAllChecked(bool value)
		{
			for (var i = 0; i < checkedListBoxEMail.Items.Count; ++i)
				checkedListBoxEMail.SetItemChecked(i, value);
		}

		private void SendEMailForm_Load(object sender, EventArgs e)
		{
			for (var i = 0; i < checkedListBoxEMail.Items.Count; ++i)
			{
				if (((AddressBook.Card) checkedListBoxEMail.Items[i]).Selected)
					checkedListBoxEMail.SetItemChecked(i, true);
			}
		}

		private void CheckedListBoxEMail_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			if (e.NewValue == e.CurrentValue) return;
			var index = AddressBook.Cards.IndexOf(checkedListBoxEMail.Items[e.Index] as AddressBook.Card);

			switch (e.NewValue)
			{
				case CheckState.Checked:
					AddressBook.Cards[index].Selected = true;
					//AddressBook.AddCard(checkedListBoxEMail.Items[e.Index] as AddressBook.Card);
					break;
				case CheckState.Unchecked:
				case CheckState.Indeterminate:
				default:
					AddressBook.Cards[index].Selected = false;
					//AddressBook.RemoveCard(checkedListBoxEMail.Items[e.Index] as AddressBook.Card);
					break;
			}
		}

		private void buttonOk_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void buttonAll_Click(object sender, EventArgs e)
		{
			SetAllChecked(true);
		}

		private void buttonNone_Click(object sender, EventArgs e)
		{
			SetAllChecked(false);
		}
	}
}
