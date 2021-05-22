using Dapper;

using SistemaX.Negocios.Mapeamento;
using SistemaX;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;

namespace SistemaX.Negocios.DAL
{
    public class CategoriaDAO : Conexao
    {
        SqlConnection banco;

        public CategoriaDAO()
        {
            this.banco = Conexao.getConnection();
        }

        public List<Categoria> ListarParaCombo(bool somenteAtivos = true)
        {
            if (somenteAtivos)
                return banco.Query<Categoria>(@"SELECT * FROM Categorias WHERE Ativo = 1 Order By Nome").ToList();
            else
                return banco.Query<Categoria>(@"SELECT * FROM Categorias Order By Nome").ToList();
        }
        //funciona
        public List<Categoria> Listar(string nome)
        {
            return banco.Query<Categoria>(@"SELECT * FROM Categorias
WHERE Nome LIKE '%" + nome + "%' Order By Nome").ToList();
        }



        public Categoria Buscar(int id)
        {
            return banco.Query<Categoria>(@"SELECT * FROM Categorias WHERE ID = @id", new { id }).SingleOrDefault();
        }



        public bool Excluir(int id)
        {
            return banco.Execute(@"DELETE FROM Categorias WHERE ID = @xxxxxx", new { xxxxxx = id }) == 1;
        }



        public int Salvar(Categoria categoria)
        {
            if (categoria.ID == 0)
            {
                //se o id for zero, é inclusão
                return banco.Query<int>(
                "INSERT INTO Categorias (Nome, Ativo) values " +
                "(@Nome, @Ativo) " +
                "select @@Identity", categoria).SingleOrDefault();
            }
            else
            {
                //update
                if (banco.Execute("UPDATE Categorias SET " +
                "Nome = @Nome, Ativo = @Ativo " +
                "WHERE ID = @ID", categoria) == 1)
                    return categoria.ID;
                else
                    return 0;
            }
        }
    }
}