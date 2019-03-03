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
    /// Interaction logic for frmRemoverInstrumento.xaml
    /// </summary>
    public partial class frmRemoverInstrumento : Window
    {
        public frmRemoverInstrumento()
        {
            InitializeComponent();
            HabilitarCampos(false);
        }

        
        Instrumento instrumento = new Instrumento();

        public void HabilitarCampos(bool habilitar)
        {
            if (habilitar)
            {
                btnRemoverInstrumento.IsEnabled = true;
            }
            else
            {
                btnRemoverInstrumento.IsEnabled = false;
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNomeInstrumentoBuscar.Text))
            {
                instrumento = new Instrumento
                {
                    Nome = txtNomeInstrumentoBuscar.Text
                };

                instrumento = InstrumentoDAO.BuscarInstrumentoPorNome(instrumento);

                if (instrumento != null)
                {
                    //Mostrar os dados
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



        private void btnRemover_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Deseja remover esse registro?",
               "Escola de Musica",
               MessageBoxButton.YesNo,
               MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                //Remover o produto
                InstrumentoDAO.RemoverInstrumento(instrumento);
                MessageBox.Show("Instrumento removido com sucesso!",
                    "Escola de Musica",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                HabilitarCampos(false);
                txtNomeInstrumentoBuscar.Clear();


            }
        }
    }
}

