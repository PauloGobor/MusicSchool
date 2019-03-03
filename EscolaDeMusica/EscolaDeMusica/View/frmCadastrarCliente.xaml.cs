using EscolaDeMusica.DAL;
using EscolaDeMusica.Model;
using EscolaDeMusica.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EscolaDeMusica.View
{
    /// <summary>
    /// Interaction logic for frmCadastrarCliente.xaml
    /// </summary>
    public partial class frmCadastrarCliente : Window
    {
        public frmCadastrarCliente()
        {
            InitializeComponent();
        }

        private void LimpaCampos()
        {
            TxtCpf.Clear();
            TxtNome.Clear();
        }

        Cliente cliente = new Cliente();

        private void BtnCancelar_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnCadastrarCliente_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtNome.Text) &&
                !string.IsNullOrEmpty(TxtCpf.Text))
            {
                cliente = new Cliente
                {
                    Nome = TxtNome.Text,
                    Cpf = TxtCpf.Text,
                    Senha = psdSenhaCliente.Password
                };
                if (Validar.Cpf(cliente.Cpf))
                {
                    if (ClienteDAO.CadastrarCliente(cliente))
                    {
                        MessageBox.Show("Cliente Cadastrado", "Escola de Musica", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        MessageBox.Show("Esse Cliente já existe!", "Escola de Musica",
                       MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("CPF INVÁLIDO", "Escola de Musica", MessageBoxButton.OK, MessageBoxImage.Error);

                }
            }
            else
            {
                MessageBox.Show("Favor preencher os campos corretamente!", "Erro",
                   MessageBoxButton.OK, MessageBoxImage.Error);
            }
            LimpaCampos();
        }

  
    }
}
