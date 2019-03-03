using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaDeMusica.Model
{
    [Table("DiaSemana")]
    public class DiaSemana
    {

        [Key]
        public int DiaSemanaId { get; set; }
        public string Nome { get; set; }
    }
}
