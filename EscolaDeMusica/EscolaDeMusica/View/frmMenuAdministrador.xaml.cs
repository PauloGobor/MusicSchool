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
    /// Interaction logic for frmMenuAdministrador.xaml
    /// </summary>
    public partial class frmMenuAdministrador : Window
    {
        public frmMenuAdministrador()
        {
            InitializeComponent();
        }

        private void MenuCadastrarCurso(object sender, RoutedEventArgs e)
        {
            frmCadastrarCurso frm = new frmCadastrarCurso();
            frm.ShowDialog();
        }

        private void MenuAlterarCurso(object sender, RoutedEventArgs e)
        {
            frmAlterarCurso frm = new frmAlterarCurso();
            frm.ShowDialog();
        }
        private void MenuCadastrarVendedor(object sender, RoutedEventArgs e)
        {
            frmCadastrarVendedor frm = new frmCadastrarVendedor();
            frm.ShowDialog();
        }
        private void MenuRemoverCurso(object sender, RoutedEventArgs e)
        {
            frmRemoverCurso frm = new frmRemoverCurso();
            frm.ShowDialog();
        }
    }
}
