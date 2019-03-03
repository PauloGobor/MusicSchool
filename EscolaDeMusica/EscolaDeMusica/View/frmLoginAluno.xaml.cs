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
    /// Interaction logic for frmLoginAluno.xaml
    /// </summary>
    public partial class frmLoginAluno : Window
    {
        public frmLoginAluno()
        {
            InitializeComponent();
        }

        private void BtEntrarAluno_Click(object sender, RoutedEventArgs e)
        {
            Aluno aluno = new Aluno
            {
                Cpf = TxtLoginAluno.Text,
                Senha = psdLoginAluno.Password
            };


            if (!string.IsNullOrEmpty(TxtLoginAluno.Text) &&
               !string.IsNullOrEmpty(psdLoginAluno.Password))
            {
                if (AlunoDAO.BuscarAlunoPorCpf(aluno) != null)
                {
                    if (AlunoDAO.BuscaSenhaAluno(aluno) != null)
                    {
                        MessageBox.Show("Login realizado!", "Escola de Musica", MessageBoxButton.OK, MessageBoxImage.Information);
                        frmMenuAluno frm = new frmMenuAluno();
                        frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Senha Invalida!", "Escola de Musica", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Aluno nao Cadastrado", "Escola de Musica", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencha os campos corretamente!", "Escola de Musica",
                     MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnCancelarAluno_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
