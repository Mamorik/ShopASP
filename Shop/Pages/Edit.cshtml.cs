using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters.Xml;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.EntityFrameworkCore;
using Shop.Data;
using Shop.Models;

namespace Shop.Pages
{
    public class EditModel : PageModel
    {
        private readonly AppDBContext _context;
        private readonly IWebHostEnvironment _appEnvironment;

        [BindProperty]
        public Product Product { get; set; }

        [BindProperty]
        public IFormFile Upload { get; set; }


        public EditModel(AppDBContext db, IWebHostEnvironment appEnvironment)
        {
            _context = db;
            _appEnvironment = appEnvironment;
        } 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == 0) return NotFound();

            Product = await _context.Product.FindAsync(id);

            if (Product == null) return NotFound();

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            try
            {
               
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_context.Product.Any(e => e.idProduct == Product.idProduct))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToPage("Index");
        }
    }
}