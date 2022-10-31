using System.Linq;
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NoteManager.Pages
{
    using DB;

    public class NotesModel : PageModel
    {
        public IEnumerable<Note> Notes { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Sort { get; set; }

        public void OnGet()
        {
            var db = Global.Database;
            switch(Sort)
            {
                case "asc": Notes = db.SortedNotes; break;
                case "des": Notes = db.SortedNotes.Reverse(); break;
                default: Notes = db.Notes; break;
            }
        }
    }
}
