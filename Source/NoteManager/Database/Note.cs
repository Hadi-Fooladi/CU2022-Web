using SQLite;
using System;

namespace NoteManager.DB
{
	public class Note
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }

		[Indexed]
		public string Text { get; set; }

		public DateTime InsertDate { get; set; }

		public DateTime UpdateDate { get; set; }

		public string Comment { get; set; }
	}
}
