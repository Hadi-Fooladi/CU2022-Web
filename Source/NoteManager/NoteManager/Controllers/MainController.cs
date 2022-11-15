using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace NoteManager.Controllers
{
	using DB;

	[Route("api")]
	[ApiController]
	public class MainController : ControllerBase
	{
		[HttpPost]
		[Route("add")]
		public bool AddNote([FromBody] string text)
		{
			Global.AddNote(text);
			return true;
		}

		[Route("list")]
		public IEnumerable<Note> GetNotes() => Global.Database.Notes;
	}
}
