using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class Product
    {
        [Key]
        public int idProduct { get; set; }
        [StringLength(50)]
        [Display(Name = "Название")]
        public string nameProduct { get; set; }
        [Display(Name = "Цена")]
        public float priceProduct { get; set; }
        [StringLength(50)]
        [Display(Name = "Категория")]
        public string categoryProduct { get; set; }
        [Display(Name = "Картинка")]
        public string imageProdusct { get; set; } 
        [StringLength(100)]
        [Display(Name = "Показ")]
        public string previewProduct { get; set; }
        [Display(Name = "Детальное описание")]
        public string detailProduct { get; set; }
    }
}
