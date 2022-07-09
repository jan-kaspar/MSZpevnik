namespace MSZpevnik
{
	public class SongData
	{
		string number;
		string title;
		string author;
		string source;
		string file_name;

		public SongData(string _n, string _t, string _fn)
		{
			number = _n;
			title = _t;
			author = "";
			source = "";
			file_name = _fn;
		}

		public string GetNumber() => number;
		public string GetTitle() => title;
		public string GetAuthor() => author;
		public string GetSource() => source;

		public string GetFileName()
		{
			return "Songs/" + number + ".html";
		}

		private static bool IsMatch(string whereToSearch, string whatToSearch)
		{
			// TODO: ignore diacritics
			return whereToSearch.IndexOf(whatToSearch, StringComparison.OrdinalIgnoreCase) >= 0;
		}

		public bool Match(string key)
		{
			if (number == key)
				return true;

			if (IsMatch(title, key))
				return true;

			if (IsMatch(author, key))
				return true;

			if (IsMatch(source, key))
				return true;

			return false;
		}

		public override string ToString()
		{
			string s = number + ": " + title;
			if (author != "")
				s += $" ({author})";
			if (source != "")
				s += $" [{source}]";

			return s;
		}
	}
}
