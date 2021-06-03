using Dapper;

using SistemaX.Negocios.Mapeamento;
using SistemaX;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;

namespace SistemaX.Negocios.DAL
{
    public class ClienteDAO : Conexao
    {
        SqlConnection banco;

        public ClienteDAO()
        {
            this.banco = Conexao.getConnection();
        }

        //funciona
        public List<Cliente> Listar(string nome)
        {
            return banco.Query<Cliente>(@"SELECT * FROM Clientes WHERE Nome LIKE '%" + nome + "%' Order By Nome").ToList();
        }



        public Cliente Buscar(int id)
        {
            return banco.Query<Cliente>(@"SELECT * FROM Clientes WHERE ID = @id", new { id }).SingleOrDefault();
        }

       
        
    }
}