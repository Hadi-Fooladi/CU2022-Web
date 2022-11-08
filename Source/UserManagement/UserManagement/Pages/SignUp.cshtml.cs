using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace UserManagement.Pages
{
    public class SignUpModel : PageModel
    {
		[BindProperty]
		public string Username { get; set; }

		[BindProperty]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		public void OnGet()
        {
        }

		public IActionResult OnPost()
		{
			var user = new User
			{
				Name = Username,
				Password = Password
			};

			Global.Database.Add(user);

			return RedirectToPage("Index");
		}
    }
}
