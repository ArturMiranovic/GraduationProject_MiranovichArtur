using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_Artur.Models.CustomValidationAttribute
{
    public class UserRegisterNameAttribute : ValidationAttribute
    {
        public override string FormatErrorMessage(string name)
        {
            return string.IsNullOrEmpty(ErrorMessage)
                ? $"Значение {name} некорректно"
                : ErrorMessage;
        }

        public override bool IsValid(object value)
        {

            var res = false;

            if (!(value is string))
            {
                throw new FormatException("Неверный формат данных");
            }


            return char.IsUpper(Convert.ToString(value)[0]);
        }


    }
}

