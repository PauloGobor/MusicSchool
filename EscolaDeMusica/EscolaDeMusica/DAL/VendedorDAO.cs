using EscolaDeMusica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaDeMusica.DAL
{
    class VendedorDAO
    {
        private static Context ctx = SingletonContext.GetInstance();
        public static bool CadastrarVendedor(Vendedor vendedor)
        {
            if (BuscarVendedorPorCpf(vendedor) == null)
            {
                ctx.Vendedores.Add(vendedor);
                ctx.SaveChanges();
                return true;
            }
            return false;
        }
        public static List<Vendedor> RetornarVendedores()
        {
            //Retornar todos os objetos da tabela
            return ctx.Vendedores.ToList();
        }

        public static Vendedor BuscarVendedorPorCpf(Vendedor vendedor)
        {
            //Find busca apenas um objeto 
            //no campo da chave primária
            return ctx.Vendedores.Find(vendedor.Cpf);
        }
        public static Vendedor BuscaSenhaVendedor(Vendedor vendedor)
        {
            return ctx.Vendedores.FirstOrDefault(x => x.Senha.Equals(vendedor.Senha));
        }
    }
}
