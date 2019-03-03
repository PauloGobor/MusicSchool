using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaDeMusica.Model
{
   [Table("Matricula")]
    class Matricula
    {
        public Matricula()
        {
            Aluno = new Aluno();
            Curso = new Curso();
        }

        [Key]
        public int IdMatricula { get; set; }
        public Aluno Aluno { get; set; }
        public Curso Curso { get; set; }
        
    }
}
