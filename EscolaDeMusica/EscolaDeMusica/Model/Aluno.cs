using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaDeMusica.Model
{
    [Table("Aluno")]
    public class Aluno
    {
        [Key]
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public string Telefone { get; set; }
        public string Senha { get; set; }
    }
}
