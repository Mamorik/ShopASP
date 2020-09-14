using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Data;
using Shop.Models;

namespace Shop.Pages
{
    public class RegistrationModel : PageModel
    {
        private readonly AppDBContext _context;

        [BindProperty]
        public User person { get; set; }

        public RegistrationModel(AppDBContext db)
        {
            _context = db;
        }

        public void OnGet()
        {

        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                _context.User.Add(person);
                await _context.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}