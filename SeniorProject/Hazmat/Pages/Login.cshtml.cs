using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Hazmat.Pages
{
    public class LoginModel : PageModel
    {
        private SQL sql = new SQL();
        public LoginModel(AppDbContext db) { _db = db; }

        private readonly AppDbContext _db;

        [BindProperty]
        public Login Login { get; set; }
        public IList<Login> Logins { get; private set; }

        public async Task<IActionResult> OnGetAsync()
        {
            Logins = await _db.Login.AsNoTracking().ToListAsync();
            if (Logins.Count >= 1)
            {
                return RedirectToPage("/Index");
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) { return Page(); }

            Login.ID = sql.UserCheck(Login.Username, Login.Password);
            
            if(Login.ID != null)
            {
                _db.Login.Add(Login);
                await _db.SaveChangesAsync();

                return RedirectToPage("/Index");
            }
            
            return Page();
        }
    }
}