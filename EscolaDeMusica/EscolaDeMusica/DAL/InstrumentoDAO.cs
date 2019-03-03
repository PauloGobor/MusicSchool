using EscolaDeMusica.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaDeMusica.DAL
{
    class InstrumentoDAO
    {
        private static Context ctx = SingletonContext.GetInstance();
        public static bool CadastrarInstrumento(Instrumento instrumento)
        {
            if (BuscarInstrumentoPorNome(instrumento) == null)
            {
                ctx.Instrumentos.Add(instrumento);
                ctx.SaveChanges();
                return true;
            }
            return false;
        }

        public static Instrumento BuscarInstrumentoPorNome(Instrumento instrumento)
        {
            return ctx.Instrumentos.FirstOrDefault
                (x => x.Nome.Equals(instrumento.Nome));
        }
        public static Instrumento BuscarInstrumentoPorId(Instrumento instrumento)
        {
            //Find busca apenas um objeto 
            //no campo da chave primária
            return ctx.Instrumentos.Find(instrumento.InstrumentoId);
        }


        public static List<Instrumento> RetornarInstrumentos()
        {
            //Retornar todos os objetos da tabela
            return ctx.Instrumentos.ToList();
        }

        public static void AlterarInstrumento(Instrumento instrumento)
        {
            ctx.Entry(instrumento).State = EntityState.Modified;
            ctx.SaveChanges();
        }
        public static void RemoverInstrumento(Instrumento instrumento)
        {
            ctx.Instrumentos.Remove(instrumento);
            ctx.SaveChanges();
        }
    }
}

