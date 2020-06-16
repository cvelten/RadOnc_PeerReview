using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeerReview
{
	static class ListExtension
	{
		public static T PopFirst<T>(this List<T> list)
		{
			if (list.Count == 0) return default(T);
			T item = list.First();
			list.RemoveAt(0);
			return item;
		}

		public static T Pop<T>(this List<T> list)
		{
			if (list.Count == 0) return default(T);
			T item = list.Last();
			list.RemoveAt(list.Count - 1);
			return item;
		}
	}
}
