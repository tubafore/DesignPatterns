using System;
using System.Collections.Generic;
using System.Text;

namespace TheirSolution
{
    public class BrowseHistory
    {
		private List<string> urls;

		public BrowseHistory()
		{
			urls = new List<string>();
		}


		public void Push(string url)
		{
			urls.Add(url);
		}

		public string Pop()
		{
			int lastIndex = urls.Count - 1;
			var lastUrl = urls[lastIndex];
			urls.RemoveAt(lastIndex);
			return lastUrl;
		}

		public IIterator<string> GetIterator()
		{
			return new ListIterator(this);
		}

		public class ListIterator : IIterator<string>
		{
			private BrowseHistory browseHistory;
			private int index;

			public ListIterator(BrowseHistory browseHistory)
			{
				this.browseHistory = browseHistory;
				index = 0;
			}

			public string Current()
			{
				return browseHistory.urls[index];
			}

			public bool HasNext()
			{
				return index < browseHistory.urls.Count;
			}

			public void Next()
			{
				index++;
			}
		}
	}
}
