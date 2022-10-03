using System;
using System.IO;
using System.Collections.Generic;

namespace NoteManager
{
	public class Notes
	{
		private string _filePath;

		public Notes(string filePath)
		{
			_filePath = filePath;
		}

		public void Add(string text)
		{
			File.AppendAllText(_filePath, text + Environment.NewLine);
		}

		public IReadOnlyList<string> Texts => File.ReadAllLines(_filePath);
	}
}
