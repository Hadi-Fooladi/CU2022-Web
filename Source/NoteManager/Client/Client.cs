using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft;

namespace NoteManager
{
	using DB;
	using Newtonsoft.Json;
	using System.Text;

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
			var response = await _client.PostAsync("add", new StringContent(JsonConvert.SerializeObject(text), Encoding.UTF8, "application/json"));
			response.EnsureSuccessStatusCode();
		}

		public async Task<IEnumerable<Note>> GetNotesAsync()
		{
			var response = await _client.GetStringAsync("list");

			return JsonConvert.DeserializeObject<Note[]>(response);
		}
	}
}
