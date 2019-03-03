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
    /// Interaction logic for frmLoginAdministrador.xaml
    /// </summary>
    public partial class frmLoginAdministrador : Window
    {
        public frmLoginAdministrador()
        {
            InitializeComponent();
        }

        private void BtEntrarAdministrador_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtLoginAdministrador.Text) &&
                !string.IsNullOrEmpty(psdLoginAdministrador.Password))
            {
                if (TxtLoginAdministrador.Text == "adm" && psdLoginAdministrador.Password == "adm")
                {
                    frmMenuAdministrador frm = new frmMenuAdministrador();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Login não Realizado!", "Escola de Musica",
                      MessageBoxButton.OK, MessageBoxImage.Error);
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
