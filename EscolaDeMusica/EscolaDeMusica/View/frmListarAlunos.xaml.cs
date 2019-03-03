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
    /// Interaction logic for frmListarAlunos.xaml
    /// </summary>
    public partial class frmListarAlunos : Window
    {
        public frmListarAlunos()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object Sender, RoutedEventArgs e)
        {
            dtaAlunos.ItemsSource = AlunoDAO.RetornarAlunos();
        }
        
        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

