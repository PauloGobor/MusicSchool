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
    /// Interaction logic for frmAlunoPorCurso.xaml
    /// </summary>
    public partial class frmAlunoPorCurso : Window
    {
        public frmAlunoPorCurso()
        {
            InitializeComponent();
        }

        
        private void button_Click(object sender, RoutedEventArgs e)
        {
            Curso curso = new Curso
            {
                IdCurso=Convert.ToInt32(cboCursos.SelectedValue)
            };
            curso = CursoDAO.BuscarCursoPorId(curso);
            dtaAlunos.ItemsSource = MatriculaDAO.BuscaMatriculaPorCurso(curso);
        }

        private void btnFechar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            dtaAlunos.ItemsSource = null;
            dtaAlunos.Items.Clear();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cboCursos.ItemsSource = CursoDAO.RetornarCursos();
            cboCursos.DisplayMemberPath = "Nome";
            cboCursos.SelectedValuePath = "IdCurso";
        }
    }
}
