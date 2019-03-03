using EscolaDeMusica.DAL;
using EscolaDeMusica.Model;
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
    /// Interaction logic for frmLoginVendedor.xaml
    /// </summary>
    public partial class frmLoginVendedor : Window
    {
        public frmLoginVendedor()
        {
            InitializeComponent();
        }

        private void BtEntrarVendedor_Click(object sender, RoutedEventArgs e)
        {
           Vendedor vendedor = new Vendedor {
           Cpf = TxtLoginVendedor.Text,
           Senha = psdLoginVendedor.Password
           };

            if (!string.IsNullOrEmpty(TxtLoginVendedor.Text) &&
                !string.IsNullOrEmpty(psdLoginVendedor.Password))
            {
                if (VendedorDAO.BuscarVendedorPorCpf(vendedor) != null)
                {
                    if (VendedorDAO.BuscaSenhaVendedor(vendedor) != null)
                    {
                        MessageBox.Show("Login realizado!", "Escola de Musica", MessageBoxButton.OK, MessageBoxImage.Information);
                        frmMenuVendedor frm = new frmMenuVendedor();
                        frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Senha Inválida!", "Escola de Musica", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vendedor não Cadastrado", "Escola de Musica", MessageBoxButton.OK, MessageBoxImage.Error);
                } 
            }
            else
            {
                MessageBox.Show("Preencha os campos corretamente!", "Escola de Musica",
                     MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void BtnCancelarAdministrador_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
