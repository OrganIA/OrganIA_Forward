using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OrganIA_MockupPage.Classes;
using OrganIA_MockupPage.Models;

namespace OrganIA_MockupPage.Pages
{
    public class AddReceiverFormModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        [BindProperty]
        public Receiver NewReceiver { get; set; }
        public AddReceiverFormModel(ApplicationDbContext db)
        {
            _db = db;

        }
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                await _db.Receivers.AddAsync(NewReceiver);
                await _db.SaveChangesAsync();
                return RedirectToPage("ReceiverPanel");
            }
            else
            {
                return Page();
            }
        }

        public void OnGet()
        {
        }
    }
}
