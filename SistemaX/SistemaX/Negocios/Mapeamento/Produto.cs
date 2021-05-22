using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaX.Negocios.Mapeamento
{
    public class Produto
    {
        public int ID { get; set; }
        public int IDCategoria { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
        public bool Ativo { get; set; }

        //
        public string CategoriaNome { get; set; }
        public decimal ValorTotal
        {
            get
            {
                return Valor * Quantidade;
            }
        }
    }
}