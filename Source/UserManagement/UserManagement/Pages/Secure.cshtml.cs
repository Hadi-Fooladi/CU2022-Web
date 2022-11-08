using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UserManagement.Pages
{
    [Authorize(Roles = "Admin")]
    public class SecureModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
