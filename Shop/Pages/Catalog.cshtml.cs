using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Shop.Data;
using Shop.Models;

namespace Shop.Pages
{
    public class CatalogModel : PageModel
    {
        private readonly AppDBContext _context;
        public List<Product> Product { get; set; }

        public CatalogModel(AppDBContext db)
        {
            _context = db;
        }

        public void OnGet()
        {
            Product = _context.Product.AsNoTracking().ToList();
        }
    }
}