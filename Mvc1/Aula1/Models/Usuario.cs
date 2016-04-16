using Aula1.Models.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [System.Web.Mvc.Remote("LoginValido", "Usuarios")]
        public string Email { get; set; }

        [Required, DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required, DataType(DataType.Password), Compare("Senha")]
        public string ComfirmarSenha { get; set; }

        [Required, Cpf]
        public string Cpf { get; set; }
    }
}
