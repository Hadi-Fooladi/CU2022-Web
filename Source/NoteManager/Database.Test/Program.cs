using System;

namespace NoteManager.DB
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var db = new Database("DB.db3");

			//db.Add(new Note
			//{
			//	Text = "This is a test.",
			//	InsertDate = DateTime.Now,
			//	UpdateDate = DateTime.Now,
			//});

			//for(int i = 1; i < 10; i++)
			//{
			//	db.Add(new Note
			//	{
			//		Text = i.ToString(),
			//		InsertDate = DateTime.Now,
			//		UpdateDate = DateTime.Now,
			//	});
			//}

			foreach (var note in db.SortedNotes)
			{
				Console.WriteLine(note.Text);
			}
		}
	}
}
