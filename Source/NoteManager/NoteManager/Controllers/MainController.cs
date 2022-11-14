using Microsoft.AspNetCore.Mvc;

namespace NoteManager.Controllers
{
	[Route("api")]
	[ApiController]
	public class MainController : ControllerBase
	{
		[Route("add/{text}")]
		public bool AddNote(string text)
		{
			Global.AddNote(text);
			return true;
		}
	}
}
