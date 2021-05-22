using Dapper;

using SistemaX.Negocios.Mapeamento;
using SistemaX;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;

namespace SistemaX.Negocios.DAL
{
    public class ProdutoDAO : Conexao
    {
        SqlConnection banco;

        public ProdutoDAO()
        {
            this.banco = Conexao.getConnection();
        }


        //funciona
        public List<Produto> Listar(string nome)
        {
            return banco.Query<Produto>(@"Select p.*, c.Nome as CategoriaNome from Produtos p
            inner join Categorias c on c.ID = p.IDCategoria 
            WHERE p.Nome LIKE '%" + nome + "%' Order By p.Nome").ToList();

        }



        public Produto Buscar(int id)
        {
            return banco.Query<Produto>(@"SELECT * FROM Produtos WHERE ID = @id", new { id }).SingleOrDefault();
        }



        public bool Excluir(int id)
        {
            return banco.Execute(@"DELETE FROM Produtos WHERE ID = @xxxxxx", new { xxxxxx = id }) == 1;
        }



        public int Salvar(Produto Produto)
        {
            if (Produto.ID == 0)
            {
                //se o id for zero, é inclusão
                return banco.Query<int>(
                "INSERT INTO Produtos (IDCategoria, Nome, Valor, Quantidade, Ativo) values " +
                "(@IDCategoria, @Nome, @Valor, @Quantidade, @Ativo) " +
                "select @@Identity", Produto).SingleOrDefault();
            }
            else
            {
                //update
                if (banco.Execute("UPDATE Produtos SET " +
                "IDCategoria = @IDCategoria, Nome = @Nome, Valor = @Valor, Quantidade = @Quantidade, Ativo = @Ativo " +
                "WHERE ID = @ID", Produto) == 1)
                    return Produto.ID;
                else
                    return 0;
            }
        }
    }
}