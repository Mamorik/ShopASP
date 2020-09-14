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
    public class IndexModel : PageModel
    { 
        private readonly AppDBContext _context;
        public List<Product> Product { get; set; }
        public User Users { get; set; }

        public IndexModel(AppDBContext db)
        {
            _context = db;
        }

        public void OnGet()
        {
            Product = _context.Product.AsNoTracking().ToList();
        }
        

    }
}
