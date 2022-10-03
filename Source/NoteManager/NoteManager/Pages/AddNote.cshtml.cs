using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NoteManager.Pages
{
    public class AddNoteModel : PageModel
    {
        public string Text { get; set; }

        public void OnGet(string text)
        {
            Text = text;
            Notes.Add(text);
        }
    }
}
