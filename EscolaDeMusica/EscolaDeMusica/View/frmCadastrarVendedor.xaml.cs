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
    /// Interaction logic for frmCadastrarVendedor.xaml
    /// </summary>
    public partial class frmCadastrarVendedor : Window
    {

        Vendedor vendedor = new Vendedor();
        public frmCadastrarVendedor()
        {
            InitializeComponent();
        }
        

        private void LimpaCampos()
        {
            TxtCpfVendedor.Clear();
            TxtNomeVendedor.Clear();
        }

        private void BtnCadastrarCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnCadastrarVendedor_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtNomeVendedor.Text)
                && !string.IsNullOrEmpty(TxtCpfVendedor.Text))
            {
                vendedor = new Vendedor
                {
                    Nome = TxtNomeVendedor.Text,
                    Cpf = TxtCpfVendedor.Text,
                    Senha = psdSenhaVendedor.Password
                };
                if (Validar.Cpf(vendedor.Cpf))
                {
                    if (VendedorDAO.CadastrarVendedor(vendedor))
                    {
                        MessageBox.Show("Vendedor Cadastrado", "Escola de Musica", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        MessageBox.Show("Esse Vendedor já existe!", "Escola de Musica",
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
                MessageBox.Show("Favor preencher o nome!", "Escola de Musica",
                   MessageBoxButton.OK, MessageBoxImage.Error);
            }
            LimpaCampos();
        }


    }
}

