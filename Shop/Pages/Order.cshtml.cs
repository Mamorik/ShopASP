using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Data;
using Shop.Models;

namespace Shop.Pages
{
    public class OrderModel : PageModel
    {
        private readonly AppDBContext _context;

        [BindProperty]
        public Product Product { get; set; }

        public OrderModel(AppDBContext db)
        {
            _context = db;
        }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == 0) return NotFound();

            Product = await _context.Product.FindAsync(id);

            if (Product == null) return NotFound();

            return Page();
        }
    }
}