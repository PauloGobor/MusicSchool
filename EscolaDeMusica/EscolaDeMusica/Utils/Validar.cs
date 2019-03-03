using EscolaDeMusica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaDeMusica.Utils
{
    class Validar
    {
        public static bool Cpf(string cpf)
        {
            int peso = 10;
            int soma = 0;
            int resto;
            int digito1, digito2;

            if (cpf.Length != 11)
            {
                return false;
            }

            switch (cpf)
            {
                case "11111111111": return false;
                case "22222222222": return false;
                case "33333333333": return false;
                case "44444444444": return false;
                case "55555555555": return false;
                case "66666666666": return false;
                case "77777777777": return false;
                case "88888888888": return false;
                case "99999999999": return false;
            }

            //Primeiro digito
            for (int i = 0; i < 9; i++)
            {
                int resultado = Convert.ToInt32(cpf[i].ToString()) * peso;
                soma += resultado;
                peso--;
            }
            resto = soma % 11;
            if (resto < 2)
            {
                digito1 = 0;
            }
            else
            {
                digito1 = 11 - resto;
            }

            //Segundo digito
            soma = 0;
            peso = 11;
            for (int i = 0; i < 10; i++)
            {
                int resultado = Convert.ToInt32(cpf[i].ToString()) * peso;
                soma += resultado;
                peso--;
            }
            resto = soma % 11;
            if (resto < 2)
            {
                digito2 = 0;
            }
            else
            {
                digito2 = 11 - resto;
            }

            if (Convert.ToInt32(cpf[9].ToString()) == digito1 &&
                Convert.ToInt32(cpf[10].ToString()) == digito2)
            {
                return true;
            }
            else
            {
                return false;
            }



        }
        /// Aqui ira verificar a quantidade de Instrumentos em estoque 
        /// E também ira diminuir do estoque

        public static bool QuantidadeInstrumento(Instrumento instrumento,int quantidade)
        {
            if (quantidade <= instrumento.Quantidade)
            {
                instrumento.Quantidade -= quantidade;
                return true;
            }
            else
            {
                return false;
            }
        }

        //Ira verificar a Quantidade de Vagas disponiveis no curso
        // e Tambéms diminuir 1 vaga apos cadastro do aluno 
        //passar por paramentro o valor 1, que sera o aluno a ser matriculado
        public static bool QuantidadeCurso(Curso curso)
        {
            
            if (1 <= curso.QtdVagas)
            {
                curso.QtdVagas -= 1;
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool InstrumentoNaVenda(Venda venda, ItemVenda itemVenda)
        {
            foreach (ItemVenda itemVendaCadastrado in venda.ItensVenda)
            {
                if (itemVendaCadastrado.Instrumento.Nome.Equals(itemVenda.Instrumento.Nome))
                {
                    itemVendaCadastrado.Quantidade += itemVenda.Quantidade;
                    itemVendaCadastrado.Subtotal += itemVenda.Subtotal;
                    return false;
                }
            }
            venda.ItensVenda.Add(itemVenda);
            
            return true;
        }

        //public static bool CursoNaMatricula(Matricula matricula, Curso curso)
        //{
        //    foreach (ItemCurso itemCursoCadastrado in matricula.c)
        //    {
        //        if (itemCursoCadastrado.Curso.Nome.Equals(curso.Nome))
        //        {
        //           //itemCursoCadastrado.Quantidade += itemCurso.Quantidade;
        //            return false;
        //        }
        //    }
            
        //    return true;
        //}



    }
}
