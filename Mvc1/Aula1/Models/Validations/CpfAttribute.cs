using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1.Models.Validations
{
    public class CpfAttribute: ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            ErrorMessage = "Mensagem de erro CPF inválido";
            return false;
        }
    }
}
