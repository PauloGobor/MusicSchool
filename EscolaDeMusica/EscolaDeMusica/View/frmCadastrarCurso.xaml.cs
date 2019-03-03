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
    /// Interaction logic for frmCadastrarCurso.xaml
    /// </summary>
    public partial class frmCadastrarCurso : Window
    {

        public frmCadastrarCurso()
        {
            InitializeComponent();
        }

        private void LimpaCampos()
        {
            TxtNomeCurso.Clear();
            TxtProfessorCurso.Clear();
            TxtVagasCurso.Clear();
            TxtValorCurso.Clear();

        }
        Curso curso = new Curso();

        private void BtnCancelar_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnCadastrarCurso_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtNomeCurso.Text) &&
                !string.IsNullOrEmpty(TxtProfessorCurso.Text) &&
                !string.IsNullOrEmpty(TxtVagasCurso.Text) &&
                !string.IsNullOrEmpty(TxtValorCurso.Text)&&
                !string.IsNullOrEmpty(cboDiaCurso.Text))
            {
                //Gravar
                DiaSemana diaSemana = new DiaSemana
                {
                    DiaSemanaId = Convert.ToInt32(cboDiaCurso.SelectedValue),


                };
                diaSemana = DiaSemanaDAO.BuscarDiaSemanaPorId(diaSemana);

                curso = new Curso
                {
                    Nome = TxtNomeCurso.Text,
                    ValorMensal = Convert.ToDouble(TxtValorCurso.Text),
                    Professor = TxtProfessorCurso.Text,
                    QtdVagas = Convert.ToInt32(TxtVagasCurso.Text),
                    DiaSemana = diaSemana,
                    Descricao = TxtDescricaoCurso.Text
                    

                };

                if (CursoDAO.CadastrarCurso(curso))
                {

                    MessageBox.Show("Curso cadastrado com sucesso!", "Escola de Musica",
                        MessageBoxButton.OK, MessageBoxImage.Information);
                    
                }
                else
                {
                    MessageBox.Show("Esse Curso já existe!", "Escola de Musica",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
                LimpaCampos();
            }
            else
            {
                MessageBox.Show("Favor preencher os campos corretamente!", "Escola de Musica",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }

            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cboDiaCurso.ItemsSource = DiaSemanaDAO.RetornarDiasdaSemana();
            cboDiaCurso.DisplayMemberPath = "Nome";
            cboDiaCurso.SelectedValuePath = "DiaSemanaId";

        }
    }
}
