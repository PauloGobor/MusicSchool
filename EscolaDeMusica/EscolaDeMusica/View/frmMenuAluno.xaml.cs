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
    /// Interaction logic for frmMenuAluno.xaml
    /// </summary>
    public partial class frmMenuAluno : Window
    {
        public frmMenuAluno()
        {
            InitializeComponent();
        }
        private void MenuCadastrarMatricula(object sender, RoutedEventArgs e)
        {
            frmCadastrarMatricula frm = new frmCadastrarMatricula();
            frm.ShowDialog();
        }
    }
}
