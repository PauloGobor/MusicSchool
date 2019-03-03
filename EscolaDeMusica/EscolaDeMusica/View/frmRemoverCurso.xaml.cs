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
    /// Interaction logic for frmRemoverCurso.xaml
    /// </summary>
    public partial class frmRemoverCurso : Window
    {
        public frmRemoverCurso()
        {
            InitializeComponent();
            HabilitarCampos(false);
        }
        Curso curso = new Curso();

        public void HabilitarCampos(bool habilitar)
        {
            if (habilitar)
            {
                btnRemover.IsEnabled = true;
            }
            else
            {
                btnRemover.IsEnabled = false;
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNomeCursoRemover.Text))
            {
                curso = new Curso
                {
                    Nome = txtNomeCursoRemover.Text
                };

                curso = CursoDAO.BuscarCursoPorNome(curso);

                if (curso != null)
                {
                    //Mostrar os dados
                    dtaCurso.Items.Add(curso);
                    HabilitarCampos(true);

                }
                else
                {
                    MessageBox.Show("Esse Curso não existe!", "ERRO",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Favor preencher o nome!", "ERRO",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }



        private void btnRemover_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Deseja remover esse registro?",
               "Atenção",
               MessageBoxButton.YesNo,
               MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                //Remover o produto
                CursoDAO.RemoverCurso(curso);
                MessageBox.Show("Instrumento removido com sucesso!",
                    "Aviso",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                HabilitarCampos(false);
                txtNomeCursoRemover.Clear();
            }
        }
    }
}




