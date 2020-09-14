using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Shop.Data;
using Shop.Models;

namespace Shop.Pages
{
    public class AuthorizationModel : PageModel
    {
        private readonly AppDBContext _context;
        public List<User> Users { get; set; } 
        public User user { get; set; }

        public AuthorizationModel(AppDBContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            Users = _context.User.AsNoTracking().ToList();
        }

        public async Task<IActionResult> OnPostDeleteAsync(User pass)
        {
            if (ModelState.IsValid)
            {
                var users = await  _context.User.FirstOrDefaultAsync(s => s.passwordUser == pass.passwordUser);
                if (users == null)
                {
                    return RedirectToPage("Index");
                }
            }
            else
            {
                return RedirectToPage("Register");
            }
            return Page();
        }
        private Task Authenticate(object email)
        {
            throw new NotImplementedException();
        }
    }
}