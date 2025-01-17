using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EventManageApp.Pages;

public class IndexModel : PageModel
{

    public IActionResult OnGet()
    {
        if (User.Identity!.IsAuthenticated)
        {
            string role = HttpContext.User.FindFirst(ClaimTypes.Role)!.Value;
            return RedirectToPage($"{role}/Home");
        }
        return Page();
    }
}
