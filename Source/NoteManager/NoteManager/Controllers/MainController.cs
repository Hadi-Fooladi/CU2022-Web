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
		public void AddNote([FromBody] string text)
		{
			Global.AddNote(text);
		}

		[Route("list")]
		public IEnumerable<Note> GetNotes() => Global.Database.Notes;

		[HttpPost]
		[Route("edit/{id:int}")]
		public void EditNote(int id, [FromBody] string text)
		{
			Global.EditNote(id, text);
		}
	}
}
