using Microsoft.AspNetCore.Mvc.RazorPages;
using OrganIA_MockupPage.Classes;

namespace OrganIA_MockupPage.Pages
{
    public class ReceiverPanel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public ReceiverPanel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            
        }
    }
}