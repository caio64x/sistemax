using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaX.Negocios.Mapeamento
{
    public class Venda
    {
        public int ID { get; set; }
        public int IDCliente { get; set; }
        public int IDUsuario { get; set; }
        public DateTime Data { get; set; }
        public string Observacao { get; set; }
    }
}
