using EscolaDeMusica.DAL;
using EscolaDeMusica.Model;
using EscolaDeMusica.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
    /// Interaction logic for frmCadastrarVenda.xaml
    /// </summary>
    public partial class frmCadastrarVenda : Window
    {
        public frmCadastrarVenda()
        {
            InitializeComponent();
            //HabilitarCampos(false);
        }
        Venda venda = new Venda();

        double total = 0;

        private void LimpaCampos()
        {
            txtClienteCpf.Clear();
            txtVendedorCpf.Clear();
            
            txtQuantidadeInstrumento.Clear();
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            cbInstrumentos.ItemsSource = InstrumentoDAO.RetornarInstrumentos();
            cbInstrumentos.DisplayMemberPath = "Nome";
            cbInstrumentos.SelectedValuePath = "InstrumentoId";

        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnCadastrarVenda_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtClienteCpf.Text) &&
                
                !string.IsNullOrEmpty(txtVendedorCpf.Text))
            {
                venda.Cliente.Cpf = txtClienteCpf.Text;
                venda.Cliente = ClienteDAO.BuscarClientePorCpf(venda.Cliente);
                if (venda.Cliente != null)
                {
                    venda.Vendedor.Cpf = txtVendedorCpf.Text;
                    venda.Vendedor = VendedorDAO.BuscarVendedorPorCpf(venda.Vendedor);
                    if (venda.Vendedor != null)
                    {
                        //verificar se tem instrumento na lista de items
                        venda.Data = DateTime.Now;

                        if (VendaDAO.CadastrarVenda(venda))
                        {
                            MessageBox.Show("Venda cadastrada com Sucesso!",
                                                                        "Escola de Musica",
                                                                            MessageBoxButton.OK,
                                                                               MessageBoxImage.Information);
                            LimpaCampos();
                            venda = new Venda();
                        }
                        else
                        {
                            MessageBox.Show("Venda não cadastrada!",
                                                                        "Escola de Musica",
                                                                            MessageBoxButton.OK,
                                                                               MessageBoxImage.Information);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Vendedor nao cadastrado!",
                                                                     "Escola de Musica",
                                                                         MessageBoxButton.OK,
                                                                            MessageBoxImage.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Cliente não cadastrado!", "Escola de Musica", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                                    MessageBox.Show("Preencha os campos!", "Escola de Musica", MessageBoxButton.OK, MessageBoxImage.Error);

            }

        }

        private void btnAdionarItemVenda(object sender, RoutedEventArgs e)
        {
            ///vincula o instrumento com o item venda

            Instrumento instrumento = new Instrumento
            {
                InstrumentoId = Convert.ToInt32(cbInstrumentos.SelectedValue)
            };
            instrumento = InstrumentoDAO.BuscarInstrumentoPorId(instrumento);

            double subtotal = instrumento.Preço *
                   Convert.ToInt32(txtQuantidadeInstrumento.Text);
            total += subtotal;
            lblTotal.Content = "Total: " + total.ToString("C2");


            ItemVenda itemVenda = new ItemVenda
            {
                Instrumento = instrumento,
                Quantidade = Convert.ToInt32(txtQuantidadeInstrumento.Text),
                PrecoVenda = instrumento.Preço,
                Subtotal = subtotal
            };

            if (itemVenda.Instrumento != null)
            {
                itemVenda.Subtotal = subtotal;
                
                if (Validar.QuantidadeInstrumento(itemVenda.Instrumento, itemVenda.Quantidade))
                {
                    itemVenda.PrecoVenda = itemVenda.Instrumento.Preço;
                    if (Validar.InstrumentoNaVenda(venda, itemVenda))
                    {
                        MessageBox.Show("Instrumento Adicionado com Sucesso!",
                                                      "Escola de Musica",
                                                          MessageBoxButton.OK,
                                                             MessageBoxImage.Information);
                        
                        dtaVendas.ItemsSource = venda.ItensVenda;
                        dtaVendas.Items.Refresh();


                    }
                    else
                    {
                        MessageBox.Show("Instrumento Alterado!",
                                                           "Escola de Musica",
                                                               MessageBoxButton.OK,
                                                                  MessageBoxImage.Information);

                    }

                }
                else
                {
                    MessageBox.Show("Quantidade de instrumento indisponivel!",
                                                        "Escola de Musica",
                                                            MessageBoxButton.OK,
                                                               MessageBoxImage.Information);
                }

            }
            else
            {
                MessageBox.Show("Instrumento não encontrado!",
                                                            "Escola de Musica",
                                                                MessageBoxButton.OK,
                                                                   MessageBoxImage.Information);

            }
            dtaVendas.Items.Refresh();

        }

    }
}
