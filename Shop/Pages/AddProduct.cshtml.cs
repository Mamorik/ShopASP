using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Shop.Data;
using Shop.Models;

namespace Shop.Pages
{
    public class AddProductModel : PageModel
    { 
        private readonly AppDBContext _context;

        [BindProperty]
        public Product Product { get; set; }
        
        public AddProductModel (AppDBContext db, IWebHostEnvironment appEnvironment)
        {
            _context = db;
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                _context.Product.Add(Product);
                await _context.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}