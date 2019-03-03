using EscolaDeMusica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaDeMusica.DAL
{
    class AlunoDAO
    {
        private static Context ctx = SingletonContext.GetInstance();
        public static bool CadastrarAluno(Aluno aluno)
        {
            if (BuscarAlunoPorCpf(aluno) == null)
            {
                ctx.Alunos.Add(aluno);
                ctx.SaveChanges();
                return true;
            }
            return false;
        }
        public static List<Aluno> RetornarAlunos()
        {
            //Retornar todos os objetos da tabela
            return ctx.Alunos.ToList();
        }
        public static Aluno BuscarAlunoPorNome(Aluno aluno)
        {
            //FirstOrDefault busca apenas um objeto 
            //com base na expressão LAMBDA
            return ctx.Alunos.FirstOrDefault(x => x.Nome.Equals(aluno.Nome));
        }
        public static Aluno BuscarAlunoPorCpf(Aluno aluno)
        {
            //Find busca apenas um objeto 
            //no campo da chave primária
            return ctx.Alunos.Find(aluno.Cpf);
        }
        public static List<Aluno> BuscarAlunoPorParteDoNome(Aluno aluno)
        {
            //Where busca apenas vários objetos 
            //com base na expressão LAMBDA
            return ctx.Alunos.
                Where(x => x.Nome.Contains(aluno.Nome)).ToList();
        }
        public static Aluno BuscaSenhaAluno(Aluno aluno)
        {
            return ctx.Alunos.FirstOrDefault(x => x.Senha.Equals(aluno.Senha));
        }
        //public static List<Aluno> BuscaAlunoPorCurso(Curso curso)
        //{
        //    return ctx.Alunos.Include("Matricula.Curso").Include("Curso").Where(x => x.Cpf.Equals(x.Matricula.Aluno.Cpf) && atricula.Curso.Nome.Equals(curso.Nome)).ToList();
        //}
    }
}
