using EscolaDeMusica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaDeMusica.DAL
{
    class MatriculaDAO
    {
        private static Context ctx = SingletonContext.GetInstance();


        public static bool RealizarMatricula(Matricula matricula)
        {
            if (BuscarMatriculaPorAlunoDiaSemana(matricula) != null)
            {

                return false;
            }
            ctx.Matriculas.Add(matricula);
            ctx.SaveChanges();
            return true;
        }

        //

        public static List<Matricula> RetornarMatriculas()
        {
            //Retornar todos os objetos da tabela
            return ctx.Matriculas.ToList();
        }

        public static Matricula BuscarMatriculaPorAlunoDiaSemana(Matricula matricula)
        {
            return ctx.Matriculas.Include("Aluno").

                Include("Curso.DiaSemana").FirstOrDefault(x => x.Aluno.Cpf.Equals(matricula.Aluno.Cpf) && x.Curso.DiaSemana.Nome.Equals(matricula.Curso.DiaSemana.Nome));
        }

        public static List<Matricula> BuscaMatriculaPorCurso(Curso curso)
        {
            return ctx.Matriculas.Include("Aluno").Where(x => x.Curso.Nome.Equals(curso.Nome)).ToList();
        }

    }
}
