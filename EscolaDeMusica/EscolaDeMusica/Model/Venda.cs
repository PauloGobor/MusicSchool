using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaDeMusica.Model
{
    [Table("Venda")]
    class Venda
    {

        public Venda()
        {
            Cliente = new Cliente();
            Vendedor = new Vendedor();
            ItensVenda = new List<ItemVenda>();

        }
        [Key]
        public int IdVenda { get; set; }
        public Cliente Cliente { get; set; }
        public Vendedor Vendedor { get; set; }
        public List<ItemVenda> ItensVenda { get; set; }
        public DateTime Data { get; set; }

    }
}
