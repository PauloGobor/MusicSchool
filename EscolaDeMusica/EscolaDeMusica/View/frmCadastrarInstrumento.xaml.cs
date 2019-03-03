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
    /// Interaction logic for frmCadastrarInstrumento.xaml
    /// </summary>
    public partial class frmCadastrarInstrumento : Window
    {

        public Instrumento instrumento = new Instrumento();

        public frmCadastrarInstrumento()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void LimpaCampos()
        {
            TxtNomeInstrumento.Clear();
            TxtPrecoInstrumento.Clear();
            TxtQtdInstrumento.Clear();
        }

        private void btnCadastrarInstrumento_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtNomeInstrumento.Text) &&
                 !string.IsNullOrEmpty(TxtPrecoInstrumento.Text) &&
                 !string.IsNullOrEmpty(TxtQtdInstrumento.Text))
            {
                //Gravar
                instrumento = new Instrumento
                {
                    Nome = TxtNomeInstrumento.Text,
                    Preço = Convert.ToDouble(TxtPrecoInstrumento.Text),
                    Quantidade = Convert.ToInt32(TxtQtdInstrumento.Text)
                };
                if (InstrumentoDAO.CadastrarInstrumento(instrumento))
                {

                    MessageBox.Show("Instrumento cadastrado com sucesso!", "Escola de Musica",
                        MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Esse Instrumento já existe!", "Escola de Musica",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Favor preencher os campos corretamente!", "Escola de Musica",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            LimpaCampos();
            
        }


    }
}
