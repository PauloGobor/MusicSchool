using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaDeMusica.Model
{

    /// <summary>
    /// Classe que representa o EF e 
    /// o banco de dados dentro da aplicação
    /// </summary>
    class Context : DbContext
    {
        //Opcional - Nomear banco de dados
        public Context() : base("EscolaDeMusica") { }

        //Mapear as classes que vão virar tabelas no banco de dados
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Instrumento> Instrumentos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }
        public DbSet<DiaSemana> DiasdaSemana { get; set; }

    }


}


