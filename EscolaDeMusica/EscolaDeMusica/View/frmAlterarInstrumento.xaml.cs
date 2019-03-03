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
    /// Interaction logic for frmAlterarInstrumento.xaml
    /// </summary>
    public partial class frmAlterarInstrumento : Window
    {
        public frmAlterarInstrumento()
        {
            InitializeComponent();
            HabilitarCampos(false);
        }
        Instrumento instrumento = new Instrumento();

        public void HabilitarCampos(bool habilitar)
        {
            if (habilitar)
            {
                btnAlteraInstrumento.IsEnabled = true;
            }
            else
            {
                btnAlteraInstrumento.IsEnabled = false;
            }
        }
        private void LimpaCampos()
        {
            txtNomeInstrumento.Clear();
            txtQuantidadeInstrumento.Clear();
            txtPrecoInstrumento.Clear();
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnBuscaNomeCurso_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBuscaNomeInstrumento.Text))
            {
                instrumento = new Instrumento
                {
                    Nome = txtBuscaNomeInstrumento.Text
                };

                instrumento = InstrumentoDAO.BuscarInstrumentoPorNome(instrumento);

                if (instrumento != null)
                {
                    txtNomeInstrumento.Text = instrumento.Nome;

                    txtPrecoInstrumento.Text = instrumento.Preço.ToString();
                    txtQuantidadeInstrumento.Text = instrumento.Quantidade.ToString();
                    HabilitarCampos(true);

                }
                else
                {
                    MessageBox.Show("Esse Instrumento não existe!", "Escola de Musica",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Favor preencher o nome!", "Escola de Musica",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnAlteraCurso_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Deseja Alterar esse registro?",
               "Escola de Musica",
               MessageBoxButton.YesNo,
               MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                //Remover o produto
                instrumento.Nome = txtNomeInstrumento.Text;

                instrumento.Quantidade = Convert.ToInt32(txtQuantidadeInstrumento.Text);
                instrumento.Preço = Convert.ToDouble(txtPrecoInstrumento.Text);
                InstrumentoDAO.AlterarInstrumento(instrumento);
                MessageBox.Show("Instrumento Alterado com sucesso!",
                    "Escola de Musica",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);

                HabilitarCampos(false);
                LimpaCampos();
            }
        }


    }
}

