using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OrganIA_MockupPage.Classes;
using OrganIA_MockupPage.Models;

namespace OrganIA_MockupPage.Pages
{
    public class ReceiverPanel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public ReceiverPanel(ApplicationDbContext db)
        {
            _db = db;
        }
        public IEnumerable<Receiver> Receivers { get; set; }

        public async Task OnGet()
        {
            Receivers = await _db.Receivers.ToListAsync();
        }
    }
}