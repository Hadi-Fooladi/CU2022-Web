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
            var now = DateTime.Now;
            Global.Database.Add(new Note
            {
                Text = Text,
                InsertDate = now,
                UpdateDate = now
            });

            return RedirectToPage("Notes");
        }
    }
}
