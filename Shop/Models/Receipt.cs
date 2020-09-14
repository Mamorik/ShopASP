using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class Receipt
    { 
        [Key]
        public int idReceipt { get; set; } 
        public DateTime datePurchase { get; set; } 
        public int idUser { get; set; } 
        public int idProduct { get; set; } 
        public virtual User User { get; set; } 
        public virtual Product Product { get; set; }
    }
}
