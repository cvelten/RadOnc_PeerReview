using System;
using System.Collections.Generic;
using System.Configuration;
using System.Xml;

namespace PeerReview
{
	public class AddressBookSection : IConfigurationSectionHandler
	{
		public object Create(object parent, object configContext, XmlNode section)
		{
			var myAddressBook = new List<AddressBook.Card>();

			foreach (XmlNode child in section.ChildNodes) // group level
			{
				if (child.Attributes is null || child.Attributes.Count == 0)
					continue;
				if (child.Name == "card")
				{
					myAddressBook.Add(new AddressBook.Card(child.Attributes["email"].Value));
					continue;
				}

				if (child.Name != "group")
					continue;

				if (!Enum.TryParse<AddressBook.Groups>(child.Attributes?["value"].Value, true, out var group))
					group = AddressBook.Groups.None;

				var selected = !(child.Attributes["selected"] is null) && Convert.ToBoolean(child.Attributes["selected"].Value);

				foreach (XmlNode grandChild in child.ChildNodes)
				{
					if (grandChild.Name != "card") continue;
					if (grandChild.Attributes.Count != 0)
						myAddressBook.Add(new AddressBook.Card(grandChild.Attributes["email"].Value, group) {Selected = selected});
				}
			}

			return myAddressBook;
		}

		public class AddressBook
		{
			public enum Groups
			{
				None,
				Attendings,
				Dosimetrists,
				Physicists,
				ResidentsPhysics,
				ResidentsMedical,
			};

			public class Card
			{
				public Card() : this("", Groups.None)
				{
				}

				public Card(string eMail) : this(eMail, Groups.None)
				{
				}

				public Card(string eMail, Groups group)
				{
					EMail = eMail;
					Group = group;
				}

				public Groups Group { get; set; }
				public string EMail { get; set; }
				public bool Selected { get; set; }

				public override string ToString()
				{
					return EMail;
				}
			}

			public AddressBook()
			{
				Cards = new List<Card>();
			}

			public AddressBook(List<Card> cards)
			{
				Cards = cards;
			}

			public List<Card> Cards { get; }

			public void AddCard(Card card)
			{
				Cards.Add(card);
			}

			public bool RemoveCard(Card card)
			{
				return Cards.Remove(card);
			}

			public List<Card> GetGroup(Groups group)
			{
				var cards = new List<Card>();
				foreach (var card in Cards)
					if (card.Group == group)
						cards.Add(card);
				return cards;
			}

			public List<Card> GetSelected()
			{
				var cards = new List<Card>();
				foreach (var card in Cards)
				{
					if (card.Selected) cards.Add(card);
				}
				return cards;
			}

			public AddressBook FromSelected()
			{
				var book = new AddressBook();
				foreach (var card in Cards)
				{
					if (card.Selected) book.AddCard(card);
				}
				return book;
			}

			public List<string> GetEMails()
			{
				var emails = new List<string>(Cards.Count);
				emails.AddRange(GetEMailsByGroup(Groups.Attendings));
				emails.AddRange(GetEMailsByGroup(Groups.Physicists));
				emails.AddRange(GetEMailsByGroup(Groups.ResidentsMedical));
				emails.AddRange(GetEMailsByGroup(Groups.ResidentsPhysics));
				emails.AddRange(GetEMailsByGroup(Groups.Dosimetrists));
				emails.AddRange(GetEMailsByGroup(Groups.None));
				return emails;
			}

			public List<string> GetEMailsByGroup(Groups group)
			{
				var emails = new List<string>();
				foreach (var card in GetGroup(group)) emails.Add(card.EMail);
				return emails;
			}
		}
	}
}