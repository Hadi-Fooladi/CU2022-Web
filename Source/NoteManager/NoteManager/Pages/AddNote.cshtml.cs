using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;


namespace NoteManager.Pages
{
    using DB;
    using System;

    public class AddNoteModel : PageModel
    {
        [BindProperty]
        public string Text { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            Global.AddNote(Text);
            return RedirectToPage("Notes");
        }
    }
}
