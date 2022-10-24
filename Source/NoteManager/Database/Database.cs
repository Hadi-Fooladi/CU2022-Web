using System;
using System.Collections.Generic;

using SQLite;

namespace NoteManager.DB
{
	public class Database
	{
		private readonly SQLiteConnection _con;

		public Database(string path)
		{
			_con = new SQLiteConnection(path);
			_con.CreateTable<Note>();
		}

		public void Add(Note note)
		{
			_con.Insert(note);
		}

		public IEnumerable<Note> Notes => _con.Table<Note>();
		public IEnumerable<Note> SortedNotes => _con.Table<Note>().OrderBy(n => n.Text);
	}
}
