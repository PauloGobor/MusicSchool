using EscolaDeMusica.DAL;
using EscolaDeMusica.Model;
using EscolaDeMusica.Utils;
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
    /// Interaction logic for frmCadastrarMatricula.xaml
    /// </summary>
    public partial class frmCadastrarMatricula : Window
    {
        public frmCadastrarMatricula()
        {
            InitializeComponent();
        }

        Matricula matricula = new Matricula();
        

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnCadastrarMatricula_Click(object sender, RoutedEventArgs e)
        {
            matricula = new Matricula();
            if (!string.IsNullOrEmpty(TxtAlunoCpf.Text)&&
                !string.IsNullOrEmpty(cboCursoDisponivelMatricula.Text))
            {
                
                Curso curso = new Curso
                {
                    IdCurso = Convert.ToInt32(cboCursoDisponivelMatricula.SelectedValue)
                };
                curso = CursoDAO.BuscarCursoPorId(curso);



                matricula.Aluno.Cpf = TxtAlunoCpf.Text;
                matricula.Aluno = AlunoDAO.BuscarAlunoPorCpf(matricula.Aluno);
                if (matricula.Aluno != null)
                {
                 
                    matricula.Curso = CursoDAO.BuscarCursoPorId(curso);
                    if (matricula.Curso != null)
                    {
                        if (Validar.QuantidadeCurso(matricula.Curso))
                        {
                           
                               
                                if (MatriculaDAO.RealizarMatricula(matricula))
                                {
                                    MessageBox.Show("Matricula Realizada com Sucesso!",
                                                                              "Escola de Musica",
                                                                                  MessageBoxButton.OK,
                                                                                     MessageBoxImage.Information);
                                    TxtAlunoCpf.Clear();
                                    //TxtNomeCurso.Clear();
                                   
                                }
                                else
                                {
                                    MessageBox.Show("Matricula não Realizada!",
                                                                               "Escola de Musica",
                                                                                   MessageBoxButton.OK,
                                                                                      MessageBoxImage.Information);
                                }
                           

                        }
                        else
                        {
                            MessageBox.Show("Quantidade de vagas indisponivel!",
                                                                    "Escola de Musica",
                                                                        MessageBoxButton.OK,
                                                                           MessageBoxImage.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Curso não encontrado!",
                                                                    "Escola de Musica",
                                                                        MessageBoxButton.OK,
                                                                           MessageBoxImage.Information);
                    }


                }
                else
                {
                    MessageBox.Show("Aluno não encontrado!",
                                                                     "Escola de Musica",
                                                                         MessageBoxButton.OK,
                                                                            MessageBoxImage.Information);
                }
                TxtAlunoCpf.Clear();
            }else
            {
                MessageBox.Show("Favor preencher os campos corretamente!", "Escola de Musica",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //cboCursoDiaMatricula.ItemsSource = DiaSemanaDAO.RetornarDiasdaSemana();
            //cboCursoDiaMatricula.DisplayMemberPath = "Nome";
            //cboCursoDiaMatricula.SelectedValuePath = "DiaSemanaId";
            cboCursoDisponivelMatricula.ItemsSource = CursoDAO.RetornarCursos();
            cboCursoDisponivelMatricula.DisplayMemberPath = "Nome";
            cboCursoDisponivelMatricula.SelectedValuePath = "IdCurso";


            
        }
    }
}

