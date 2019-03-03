using EscolaDeMusica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaDeMusica.DAL
{
    class DiaSemanaDAO
    {
        private static Context ctx = SingletonContext.GetInstance();

        public static List<DiaSemana> RetornarDiasdaSemana()
        {
            return ctx.DiasdaSemana.ToList();
        }

        public static DiaSemana BuscarDiaSemanaPorId(DiaSemana dia)
        {
            return ctx.DiasdaSemana.Find(dia.DiaSemanaId);
        }

    }
}
