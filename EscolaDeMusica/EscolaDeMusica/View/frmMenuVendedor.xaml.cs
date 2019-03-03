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
    /// Interaction logic for frmMenuVendedor.xaml
    /// </summary>
    public partial class frmMenuVendedor : Window
    {
        public frmMenuVendedor()
        {
            InitializeComponent();
        }
        private void MenuCadastrarInstrumento(object sender, RoutedEventArgs e)
        {
            frmCadastrarInstrumento frm = new frmCadastrarInstrumento();
            frm.ShowDialog();
        }
        private void MenuAlterarInstrumento(object sender, RoutedEventArgs e)
        {
            frmAlterarInstrumento frm = new frmAlterarInstrumento();
            frm.ShowDialog();
        }
        private void MenuRemoverInstrumento(object sender, RoutedEventArgs e)
        {
            frmRemoverInstrumento frm = new frmRemoverInstrumento();
            frm.ShowDialog();
        }
        private void MenuRealizarVenda(object sender, RoutedEventArgs e)
        {
            frmCadastrarVenda frm = new frmCadastrarVenda();
            frm.ShowDialog();
        }
    }
}
