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
    /// Interaction logic for frmPrincipal.xaml
    /// </summary>
    public partial class frmPrincipal : Window
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void MenuCadastrarAluno(object sender, RoutedEventArgs e)
        {
            //Abrir um formulário 
            frmCadastrarAluno frm = new frmCadastrarAluno();
            
            frm.ShowDialog();
        }
        private void MenuCadastrarCliente(object sender, RoutedEventArgs e)
        {
            frmCadastrarCliente frm = new frmCadastrarCliente();
            frm.ShowDialog();
            

        }

        


        private void MenuListarCursos(object sender, RoutedEventArgs e)
        {
            frmListarCursos frm = new frmListarCursos();
            frm.ShowDialog();
        }

        private void MenuCadastrarVenda(object sender, RoutedEventArgs e)
        {
            frmCadastrarVenda frm = new frmCadastrarVenda();
            frm.ShowDialog();
        }

        

        private void MenuLoginAluno(object sender, RoutedEventArgs e)
        {
            //Abrir um formulário 
            frmLoginAluno frm = new frmLoginAluno();

            frm.ShowDialog();
        }


        private void MenuListarAlunos(object sender, RoutedEventArgs e)
        {
            //Abrir um formulário 
            frmListarAlunos frm = new frmListarAlunos();

            frm.ShowDialog();
        }

        private void MenuLoginVendedor(object sender, RoutedEventArgs e)
        {
            frmLoginVendedor frm = new frmLoginVendedor();
            frm.ShowDialog();
        }
        private void MenuBuscarVendedor(object sender, RoutedEventArgs e)
        {
            frmListarVendedores frm = new frmListarVendedores();
            frm.ShowDialog();
        }
        private void MenuListarInstrumentos(object sender, RoutedEventArgs e)
        {
            frmListarInstrumentos frm = new frmListarInstrumentos();
            frm.ShowDialog();
        }
        private void MenuLoginAdministrador(object sender, RoutedEventArgs e)
        {
            frmLoginAdministrador frm = new frmLoginAdministrador();
            frm.ShowDialog();
        }

        private void MenuListarVendedores(object sender, RoutedEventArgs e)
        {
            frmListarVendedores frm = new frmListarVendedores();
            frm.ShowDialog();
        }

        private void MenuListarAlunosPorCurso(object sender, RoutedEventArgs e)
        {
            frmAlunoPorCurso frm = new frmAlunoPorCurso();
            frm.ShowDialog();
        }
    }
}
