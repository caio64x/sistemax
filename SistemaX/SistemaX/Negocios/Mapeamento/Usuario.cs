﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaX.Negocios.Mapeamento
{
    public class Usuario
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }

        public bool AcessaCategorias { get; set; }
        public bool AcessaProdutos { get; set; }
        public bool AcessaUsuarios { get; set; }
    }
}
