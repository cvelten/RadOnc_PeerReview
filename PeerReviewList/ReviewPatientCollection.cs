using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace PeerReview
{
	public class ReviewPatientCollection : IEnumerable<ReviewPatient>, ICollection<ReviewPatient>
	{
		public ReviewPatientCollection()
		{
			Collection = new List<ReviewPatient>();
			Errors = new List<string>();
		}

		public List<ReviewPatient> Collection { get; }
		public List<string> Errors { get;  }

		public int Count => Collection.Count;

		public bool IsReadOnly => throw new System.NotImplementedException();

		public static ReviewPatientCollection ReadDirectory(DirectoryInfo folder)
		{
			var items = new ReviewPatientCollection();
			foreach (var file in folder.GetFiles("*.pdf", SearchOption.AllDirectories))
			{
				if (ReviewPatient.TryParse(file, out var reviewPatient)) items.Collection.Add(reviewPatient);
			}
			return items;
		}

		public static async Task<ReviewPatientCollection> ReadDirectoryAsync(DirectoryInfo folder)
		{
			var items = new ReviewPatientCollection();
			foreach (var file in folder.GetFiles("*.pdf", SearchOption.AllDirectories))
			{
				var item = await ReviewPatient.ParseAsync(file);
				if (!(item is null) && !item.IsNull) items.Collection.Add(item);
				else items.Errors.Add($"NULL Exception: {file.FullName}. Maybe RADIALOGICA package does not exist or name is wrong (anonymous) in PDF?");
			}
			return items;
		}

		public void Add(ReviewPatient item)
		{
			throw new System.NotImplementedException();
		}

		public void Clear()
		{
			throw new System.NotImplementedException();
		}

		public bool Contains(ReviewPatient item)
		{
			throw new System.NotImplementedException();
		}

		public void CopyTo(ReviewPatient[] array, int arrayIndex)
		{
			throw new System.NotImplementedException();
		}

		public IEnumerator<ReviewPatient> GetEnumerator()
		{
			return ((IEnumerable<ReviewPatient>)Collection).GetEnumerator();
		}

		public bool Remove(ReviewPatient item)
		{
			throw new System.NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<ReviewPatient>)Collection).GetEnumerator();
		}
	}
}
