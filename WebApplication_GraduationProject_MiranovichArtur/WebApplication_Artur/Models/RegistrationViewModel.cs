using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_Artur.Models.CustomValidationAttribute;

namespace WebApplication_Artur.Models
{
    public class RegistrationViewModel
    {
        [Required(ErrorMessage = "Недопустимая длина имени (минимум 2 символа)")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Недопустимая длина имени (минимум 2 символа)")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Недопустимая длина имени (минимум 2 символа)")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Недопустимая длина имени (минимум 2 символа)")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Недопустимая длина имени (минимум 2 символа)")]
        [StringLength(30, MinimumLength = 4, ErrorMessage = "Недопустимая длина имени (минимум 4 символа)")]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }
    }
}
