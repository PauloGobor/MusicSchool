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
    /// Interaction logic for frmAlterarCurso.xaml
    /// </summary>
    public partial class frmAlterarCurso : Window
    {
        public frmAlterarCurso()
        {
            InitializeComponent();
            HabilitarCampos(false);
        }
        Curso curso = new Curso();

        public void HabilitarCampos(bool habilitar)
        {
            if (habilitar)
            {
                btnAlteraCurso.IsEnabled = true;
            }
            else
            {
                btnAlteraCurso.IsEnabled = false;
            }
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnBuscaNomeCurso_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBuscaNomeCurso.Text))
            {
                curso = new Curso
                {
                    Nome = txtBuscaNomeCurso.Text
                };

                curso = CursoDAO.BuscarCursoPorNome(curso);

                if (curso != null)
                {
                    txtNomeCurso.Text = curso.Nome;
                    txtProfCurso.Text = curso.Professor;
                    txtValorCurso.Text = curso.ValorMensal.ToString();
                    txtVagasCursos.Text = curso.QtdVagas.ToString();
                    txtDescricaoCurso.Text = curso.Descricao.ToString();
                    cboDiaSemana.Text = curso.DiaSemana.Nome;
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

        private void btnAlteraCurso_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Deseja Alterar esse registro?",
               "Atenção",
               MessageBoxButton.YesNo,
               MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                //Remover o produto
                curso.Nome = txtNomeCurso.Text;
                curso.Professor = txtProfCurso.Text;
                curso.QtdVagas = Convert.ToInt32(txtVagasCursos.Text);
                curso.Descricao = txtDescricaoCurso.Text;
                curso.ValorMensal = Convert.ToDouble(txtValorCurso.Text);
                curso.DiaSemana.DiaSemanaId = Convert.ToInt32(cboDiaSemana.SelectedValue);
                curso.DiaSemana = DiaSemanaDAO.BuscarDiaSemanaPorId(curso.DiaSemana);
                CursoDAO.AlterarCurso(curso);
                MessageBox.Show("Curso Alterado com sucesso!",
                    "Aviso",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);

                HabilitarCampos(false);
                txtNomeCurso.Clear();
                txtProfCurso.Clear();
                txtVagasCursos.Clear();
                txtValorCurso.Clear();
                cboDiaSemana.Text = "";
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cboDiaSemana.ItemsSource = DiaSemanaDAO.RetornarDiasdaSemana();
            cboDiaSemana.DisplayMemberPath = "Nome";
            cboDiaSemana.SelectedValuePath = "DiaSemanaId";
        }
    }
}

