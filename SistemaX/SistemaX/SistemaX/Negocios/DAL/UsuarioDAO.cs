using Dapper;

using SistemaX.Negocios.Mapeamento;
using SistemaX;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;

namespace SistemaX.Negocios.DAL
{
    public class UsuarioDAO : Conexao
    {
        SqlConnection banco;

        public UsuarioDAO()
        {
            this.banco = Conexao.getConnection();
        }

        //funciona
        public List<Usuario> Listar(string nome)
        {
            return banco.Query<Usuario>(@"SELECT * FROM Usuarios WHERE Nome LIKE '%" + nome + "%' Order By Nome").ToList();
        }



        public Usuario Buscar(int id)
        {
            return banco.Query<Usuario>(@"SELECT * FROM Usuarios WHERE ID = @id", new { id }).SingleOrDefault();
        }

        public Usuario EfetuarLogin(string login, string senha)
        {
            return banco.Query<Usuario>(@"SELECT * FROM Usuarios WHERE Login = @Login  and Senha = @Senha", new { login, senha }).SingleOrDefault();
        }


        public bool Excluir(int id)
        {
            return banco.Execute(@"DELETE FROM Usuarios WHERE ID = @xxxxxx", new { xxxxxx = id }) == 1;
        }



        public int Salvar(Usuario usuario)
        {
            if (usuario.ID == 0)
            {
                //se o id for zero, é inclusão
                return banco.Query<int>(
                "INSERT INTO Usuarios (Nome, Ativo, Login, Senha, AcessaCategorias, AcessaProdutos, AcessaUsuarios) values " +
                "(@Nome, @Ativo, @Login, @Senha, @AcessaCategorias, @AcessaProdutos, @AcessaUsuarios) " +
                "select @@Identity", usuario).SingleOrDefault();
            }
            else
            {
                //update
                if (banco.Execute("UPDATE Usuarios SET " +
                "Nome = @Nome, Ativo = @Ativo, Senha = @Senha, " +
                "AcessaCategorias = @AcessaCategorias, AcessaProdutos = @AcessaProdutos, AcessaUsuarios = @AcessaUsuarios " +
                "WHERE ID = @ID", usuario) == 1)
                    return usuario.ID;
                else
                    return 0;
            }
        }
    }
}