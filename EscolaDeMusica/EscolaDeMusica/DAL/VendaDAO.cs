using EscolaDeMusica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaDeMusica.DAL
{
    class VendaDAO
    {

        private static Context ctx = SingletonContext.GetInstance();

        public static bool CadastrarVenda(Venda venda)
        {
            if (venda.ItensVenda.Count > 0)
            {
                ctx.Vendas.Add(venda);
                ctx.SaveChanges();
                return true;
            }
            return false;
        }

        public static List<Venda> RetornarVendas()
        {
            return ctx.Vendas.ToList(); ;
        }

        //public static List<Venda> RetornarVendasPorCliente(Cliente cliente)
        //{
        //    List<Venda> aux = new List<Venda>();

        //    foreach (Venda vendaCadastrada in vendas)
        //    {
        //        if (vendaCadastrada.Cliente.Cpf.Equals(cliente.Cpf))
        //        {
        //            aux.Add(vendaCadastrada);
        //        }
        //    }
        //    return aux;
        //}
    }
}
