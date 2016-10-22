using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvcTemplates2.Models
{
    public class Release
    {
        [Key]
        public int Id { get; set; }
        public int Codigo { get; set; }
        public DateTime DataLiberacao { get; set; }
    }
}
