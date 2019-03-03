using EscolaDeMusica.DAL;
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
    /// Interaction logic for frmListarCursos.xaml
    /// </summary>
    public partial class frmListarCursos : Window
    {
        public frmListarCursos()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void dtaCursos_Loaded(object sender, RoutedEventArgs e)
        {

            dtaCursos.ItemsSource = CursoDAO.RetornarCursos();


        }
    }
}
