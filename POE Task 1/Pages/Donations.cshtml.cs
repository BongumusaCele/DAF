using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace POE_Task_1.Pages
{
    [Authorize]
    public class DonationsModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
