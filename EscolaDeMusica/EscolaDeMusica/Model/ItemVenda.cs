using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaDeMusica.Model
{
    [Table("ItemVenda")]
    class ItemVenda
    {
        public ItemVenda()
        {
            Instrumento = new Instrumento();
        }
        [Key]
        public int ItemID { get; set; }
        public Instrumento Instrumento { get; set; }
        public double PrecoVenda { get; set; }
        public int Quantidade { get; set; }
        public double Subtotal { get; set; }
    }
}
