
using EscolaDeMusica.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaDeMusica.DAL
{
    class CursoDAO
    {
        private static Context ctx = SingletonContext.GetInstance();
        public static bool CadastrarCurso(Curso curso)
        {
            if (BuscarCursoPorNome(curso) == null)
            {
                ctx.Cursos.Add(curso);
                ctx.SaveChanges();
                return true;
            }
            return false;
        }

        public static List<Curso> RetornarCursos()
        {
            //Retornar todos os objetos da tabela
            return ctx.Cursos.Include("DiaSemana").ToList();
        }

        public static Curso BuscarCursoPorNome(Curso curso)
        {
            //FirstOrDefault busca apenas um objeto 
            //com base na expressão LAMBDA
            return ctx.Cursos.FirstOrDefault(x => x.Nome.Equals(curso.Nome));
        }

        public static void AlterarCurso(Curso curso)
        {
            ctx.Entry(curso).State = EntityState.Modified;
            ctx.SaveChanges();
        }

        public static void RemoverCurso(Curso curso)
        {
            ctx.Cursos.Remove(curso);
            ctx.SaveChanges();
        }
        public static Curso BuscarCursoPorId(Curso curso)
        {
            //Find busca apenas um objeto 
            //no campo da chave primária
            return ctx.Cursos.Find(curso.IdCurso);
        }

    }
}
