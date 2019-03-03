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
    /// Interaction logic for frmCadastrarAluno.xaml
    /// </summary>
    public partial class frmCadastrarAluno : Window
    {
        public frmCadastrarAluno()
        {
            InitializeComponent();
        }

        private void LimpaCampos()
        {
            TxtDataNascAluno.Clear();
            TxtCpfAluno.Clear();
            TxtNomeAluno.Clear();
            TxtTelefoneAluno.Clear();
            psdSenhaAluno.Clear();
        }

        Aluno aluno = new Aluno();

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnCadastrarAuno_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtNomeAluno.Text) &&
                !string.IsNullOrEmpty(TxtDataNascAluno.Text) &&
                !string.IsNullOrEmpty(TxtCpfAluno.Text) &&
                !string.IsNullOrEmpty(TxtTelefoneAluno.Text))
            {
                aluno = new Aluno
                {
                    Nome = TxtNomeAluno.Text,
                    Cpf = TxtCpfAluno.Text,
                    Nascimento = Convert.ToDateTime(TxtDataNascAluno.Text),
                    Telefone = TxtTelefoneAluno.Text,
                    Senha = psdSenhaAluno.Password
                };

                if (Validar.Cpf(aluno.Cpf))
                {
                    if (AlunoDAO.CadastrarAluno(aluno))
                    {
                        MessageBox.Show("Aluno Cadastrado", "Escola de Musica", MessageBoxButton.OK, MessageBoxImage.Information);

                    }
                    else
                    {
                        MessageBox.Show("Esse Aluno já existe!", "Escola de Musica",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                    }


                }
                else
                {
                    MessageBox.Show("CPF INVÁLIDO", "Escola de Musica", MessageBoxButton.OK, MessageBoxImage.Error);

                }
                LimpaCampos();
            }
            else
            {
                MessageBox.Show("Favor preencher os campos corretamente!", "Escola de Musica",
                   MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


    }
}