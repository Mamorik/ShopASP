using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Data;
using Shop.Models;

namespace Shop.Pages
{
    public class OplataModel : PageModel
    {
        public class OrderModel
        {
            public int OrderId { get; set; }
            public decimal Sum { get; set; }
        }

        private readonly AppDBContext _context;

        [BindProperty]
        public Product Product { get; set; }

        public OplataModel(AppDBContext db)
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
        public ActionResult Index()
        {
            Product order = _context.Product.FirstOrDefault();
            if (order != null)
            {
                OrderModel orderModel = new OrderModel { OrderId = order.idProduct, Sum = 10 };
                return Page();
            }
            return HttpNotFound();

        } 
            [HttpPost]
            public void Paid(string notification_type, int operation_id, int label,
                      decimal amount, decimal withdraw_amount, string sender, string sha1_hash, string currency, bool codepro)
            {
                string key = "4avY5eS99SMyTGlkdR4MVfzm"; // секретный код
                                                 // проверяем хэш
                string paramString = String.Format("{0}&{1}&{2}&{3}&{4}&{5}&{6}&{7}&{8}",
                    notification_type, operation_id, amount, currency, sender,
                    codepro.ToString().ToLower(), key, label);
                string paramStringHash1 = GetHash(paramString);
                // создаем класс для сравнения строк
                StringComparer comparer = StringComparer.OrdinalIgnoreCase;
                // если хэши идентичны, добавляем данные о заказе в бд
                if (0 == comparer.Compare(paramStringHash1, sha1_hash))
                {
                    Product order = _context.Product.FirstOrDefault(o => o.idProduct == label);
                    order.idProduct = operation_id;

                    order.priceProduct = 10;
                    _context.Entry(order).State = (Microsoft.EntityFrameworkCore.EntityState)EntityState.Modified;
                    _context.SaveChanges();
                }
            }
            public string GetHash(string val)
            {
                SHA1 sha = new SHA1CryptoServiceProvider();
                byte[] data = sha.ComputeHash(Encoding.Default.GetBytes(val));

                StringBuilder sBuilder = new StringBuilder();

                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }
                return sBuilder.ToString();
            }

            [HttpGet]
        public string Paid()
        {
            return "<p>заказ оплачен</p>";
        }

        private ActionResult HttpNotFound()
        {
            throw new NotImplementedException();
        }
    }
}