using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_Artur.Models.CustomValidationAttribute
{
    public class RegisteNameAttribute : ValidationAttribute
    {
        public override string FormatErrorMessage(string name)
        {
            return string.IsNullOrEmpty(ErrorMessage)
                ? $"Значение {name} некорректно"
                : ErrorMessage;
        }



    }

}

