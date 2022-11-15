using System;

namespace NoteManager
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Edit(12, "This is edited!!!!!!!");
		}

		static async void List()
		{
			var client = new Client("http://localhost:60667/api/");

			int counter = 1;
			foreach(var note in  await client.GetNotesAsync())
			{
				Console.WriteLine($"Note {counter++} ({note.Id}):");
				Console.WriteLine(note.Text);
			}
		}

		static async void Add()
		{
			var client = new Client("http://localhost:60667/api/");

			await client.AddNoteAsync("This is from Json Serializer");
		}

		static async void Edit(int id, string text)
		{
			var client = new Client("http://localhost:60667/api/");

			await client.EditNoteAsync(id, text);
		}
	}
}
