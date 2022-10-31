using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NoteManager.DB;
using System;

namespace NoteManager.Pages
{
    public class EditNoteModel : PageModel
    {
		[BindProperty(SupportsGet = true)]
		public int Id { get; set; }

		[BindProperty]
		public string Text { get; set; }

		public void OnGet()
        {
			var db = Global.Database;
			var note = db.FindById(Id);

			Text = note.Text;
		}

		public IActionResult OnPost()
		{
			var db = Global.Database;
			var note = db.FindById(Id);

			note.Text = Text;
			note.UpdateDate = DateTime.Now;

			db.Edit(note);
			return RedirectToPage("Notes");
		}
	}
}
