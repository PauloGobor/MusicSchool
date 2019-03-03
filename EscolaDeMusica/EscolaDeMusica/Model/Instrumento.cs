using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaDeMusica.Model
{
    [Table("Instrumento")]
    public class Instrumento
    {
        [Key]
        public int InstrumentoId { get; set; }
        public string Nome { get; set; }
        public double Preço { get; set; }
        public int Quantidade { get; set; }
    }
}
