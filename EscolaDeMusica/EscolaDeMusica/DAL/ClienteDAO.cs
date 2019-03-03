using EscolaDeMusica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaDeMusica.DAL
{
    class ClienteDAO
    {
        private static Context ctx = SingletonContext.GetInstance();
        public static bool CadastrarCliente(Cliente cliente)
        {
            if (BuscarClientePorCpf(cliente) == null)
            {
                ctx.Clientes.Add(cliente);
                ctx.SaveChanges();
                return true;
            }
            return false;
        }
        public static List<Cliente> RetornarClientes()
        {
            //Retornar todos os objetos da tabela
            return ctx.Clientes.ToList();
        }

        public static Cliente BuscarClientePorCpf(Cliente cliente)
        {
            //Find busca apenas um objeto 
            //no campo da chave primária
            return ctx.Clientes.Find(cliente.Cpf);
        }
        public static Cliente BuscaSenhaCliente(Cliente cliente)
        {
            return ctx.Clientes.FirstOrDefault(x => x.Senha.Equals(cliente.Senha));
        }

    }
}
