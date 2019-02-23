using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Hazmat.Pages
{
    public class ManualSubmissionModel : PageModel
    {
        public ManualSubmissionModel(AppDbContext db) { _db = db; }

        private readonly AppDbContext _db;

        [BindProperty]
        public IList<Login> Logins { get; private set; }

        public async Task<IActionResult> OnGetAsync()
        {
            //Redirect to Login if not Logged in
            Logins = await _db.Login.AsNoTracking().ToListAsync();
            if (Logins.Count == 0)
            {
                return RedirectToPage("/Login");
            }
            //

            return Page();
        }
    }
}