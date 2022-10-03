using System.Collections.Generic;

namespace NoteManager
{
	public static class Notes
	{
		private static List<string> s_texts = new List<string>();

		public static void Add(string text)
		{
			s_texts.Add(text);
		}

		public static IReadOnlyList<string> Texts => s_texts;
	}
}
