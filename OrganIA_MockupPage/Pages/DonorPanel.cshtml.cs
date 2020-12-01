using Microsoft.AspNetCore.Mvc.RazorPages;
using OrganIA_MockupPage.Classes;

namespace OrganIA_MockupPage.Pages
{
    public class DonorPanel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public DonorPanel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
        }
    }
}