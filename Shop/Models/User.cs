using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class User
    {
        [Key]
        public int idUser { get; set; } 
        [StringLength(25)] 
        [NotNull]
        [Index("CourseCodeIndex", IsUnique = true)]
        [Display(Name = "Логин")]
        public string loginUser { get; set; } 
        [StringLength(50)]
        [NotNull]
        [Display(Name = "Пароль")]
        public string passwordUser { get; set; }  
        [StringLength(25)]
        [NotNull]
        [Display(Name = "Фамилия")]
        public string lastNameUser { get; set; }
        [StringLength(25)]
        [NotNull]
        [Display(Name = "Имя")]
        public string firstNameUser { get; set; }
        [StringLength(25)]
        [Display(Name = "Отчество")]
        public string secondNameUser { get; set; }
        [StringLength(50)]
        [NotNull]
        [Display(Name = "Электронная почта")]
        public string mailUser { get; set; }
        [StringLength(50)]
        [Display(Name = "Роль")]
        public string roleUser { get; set; }
     }
}
