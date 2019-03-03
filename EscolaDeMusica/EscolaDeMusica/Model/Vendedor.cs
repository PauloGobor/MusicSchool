﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaDeMusica.Model
{
    [Table("Vendedor")]
    public class Vendedor
    {
        [Key]
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
    }
}
