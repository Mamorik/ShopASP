using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Data;
using Shop.Models;

namespace Shop.Pages
{
    public class adminModel : PageModel
    {
        private readonly AppDBContext _context;
        public List<Product> Product { get; set; }

        public adminModel(AppDBContext db)
        {
            _context = db;
        }

        public void OnGet()
        {
            Product = _context.Product.AsNoTracking().ToList();
        }
        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var product = await _context.Product.FindAsync(id);

            if (product != null)
            {
                _context.Product.Remove(product);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage();
        }
    }
}