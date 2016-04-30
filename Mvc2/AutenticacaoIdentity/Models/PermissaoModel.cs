using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutenticacaoIdentity.Models
{
    public class PermissaoModel
    {
        [Key]
        public int Id { get; set; }

        public string Permissao { get; set; }

        public ICollection<UsuarioModel> Usuarios { get; set; }
    }
}
