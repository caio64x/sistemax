using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaX.Negocios.Mapeamento
{
    public class ItensGrid
    {
        public int IDProduto { get; set; }
        public string NomeProduto { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorTotal
        {
            get
            {
                return ValorUnitario * Quantidade;
            }
        }
    }
}
