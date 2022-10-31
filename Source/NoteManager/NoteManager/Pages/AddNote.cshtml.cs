using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Collections.Generic;


namespace NoteManager.Pages
{
    public class AddNoteModel : PageModel
    {
        public IReadOnlyList<string> Notes { get; set; }

        //public void OnGet(string text, [FromServices] IWebHostEnvironment env)
        //{
        //    var notes = new Notes(Path.Combine(env.ContentRootPath, "Notes.txt"));

        //    notes.Add(text);
        //    Notes = notes.Texts;
        //}
    }
}
