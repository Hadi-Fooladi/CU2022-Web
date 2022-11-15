using System;

namespace NoteManager
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List();
		}

		static async void List()
		{
			var client = new Client("http://localhost:60667/api/");

			int counter = 1;
			foreach(var note in  await client.GetNotesAsync())
			{
				Console.WriteLine($"Note {counter++}:");
				Console.WriteLine(note.Text);
			}
		}

		static async void Add()
		{
			var client = new Client("http://localhost:60667/api/");

			await client.AddNoteAsync("This is from Json Serializer");
		}
	}
}
