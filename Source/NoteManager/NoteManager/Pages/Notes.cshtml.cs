using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NoteManager.Pages
{
    using DB;

    public class NotesModel : PageModel
    {
        public IEnumerable<Note> Notes { get; set; }

        public void OnGet()
        {
            Notes = Global.Database.Notes;
        }
    }
}
