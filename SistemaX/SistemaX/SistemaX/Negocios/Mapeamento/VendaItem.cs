using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaX.Negocios.Mapeamento
{
   public class VendaItem
    {
        public int ID { get; set; }
        public int IDVenda { get; set; }
        public int IDProduto { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
    }
}
