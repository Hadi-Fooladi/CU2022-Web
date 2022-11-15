using System;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace NoteManager
{
	using DB;

	public class Client
	{
		public Client(string baseAddress)
		{
			_client = new HttpClient
			{
				BaseAddress = new Uri(baseAddress)
			};
		}

		private readonly HttpClient _client;

		public async Task AddNoteAsync(string text)
		{
			var response = await _client.PostAsync("add", Deserialize(text));
			response.EnsureSuccessStatusCode();
		}

		public async Task<IEnumerable<Note>> GetNotesAsync()
		{
			var response = await _client.GetStringAsync("list");

			return JsonConvert.DeserializeObject<Note[]>(response);
		}

		public async Task EditNoteAsync(int id, string text)
		{
			var response = await _client.PostAsync($"edit/{id}", Deserialize(text));
			response.EnsureSuccessStatusCode();
		}

		private static StringContent Deserialize(object obj)
			=> new StringContent(
				JsonConvert.SerializeObject(obj),
				Encoding.UTF8,
				"application/json");
	}
}
