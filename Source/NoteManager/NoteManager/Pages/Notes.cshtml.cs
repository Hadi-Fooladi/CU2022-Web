using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NoteManager.Pages
{
    public class NotesModel : PageModel
    {
        public List<int> Numbers { get; set; }

        public void OnGet()
        {
            Numbers = new List<int>();
            for (int i = 1; i < 10; i++)
                Numbers.Add(i);
        }
    }
}
