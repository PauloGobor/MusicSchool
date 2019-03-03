using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaDeMusica.Model
{
    [Table("Curso")]
    public class Curso
    {

        [Key]
        public int IdCurso { get; set; }
        public string Nome { get; set; }
        public string Professor { get; set; }
        public int QtdVagas { get; set; }
        public double ValorMensal { get; set; }
        public DiaSemana DiaSemana { get; set ; }

        public string Descricao { get; set; }

        // colocar uma propriedade que vai receber o dia da semana como segunda feira
        // vai ser realizado um comparacao das datas com os cursos ja matriculados



    }
}
