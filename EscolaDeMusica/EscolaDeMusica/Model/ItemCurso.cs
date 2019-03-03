using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaDeMusica.Model
{
    [Table("ItemCurso")]
    class ItemCurso
    {
        public ItemCurso()
        {
            Curso = new Curso();
        }
        [Key]
        public int ItemID { get; set; }
        public Curso Curso { get; set; }
        public double PrecoCurso { get; set; }
        //public DiaSemana DiaSemana { get; set; }
    }
}
