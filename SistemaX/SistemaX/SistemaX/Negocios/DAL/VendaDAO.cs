using Dapper;

using SistemaX.Negocios.Mapeamento;
using SistemaX;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System;

namespace SistemaX.Negocios.DAL
{
    public class VendaDAO : Conexao
    {
        SqlConnection banco;

        public VendaDAO()
        {
            this.banco = Conexao.getConnection();
        }
        public int Salvar(int idCliente, string observacao, List<ItensGrid> listaItem)
        {
            int idVenda = banco.Query<int>(
            "INSERT INTO Vendas (IDCliente, IDUsuario, Data, Observacao) values " +
            "(@IDCliente, @IDUsuario, @Data, @Observacao) " +
            "select @@Identity",
            new
            {
                idCliente,
                IDUsuario = Compartilhada.UsuarioLogado.ID,
                Data = DateTime.Now,
                observacao
            }).SingleOrDefault();

            //adiciona os itens
            foreach (var item in listaItem)
            {
                banco.Execute(
                "INSERT INTO VendaItens (IDVenda, IDProduto, Quantidade, ValorUnitario) values " +
                "(@IDVenda, @IDProduto, @Quantidade, @ValorUnitario) ",
                new
                {
                    IDVenda = idVenda,
                    IDProduto = item.IDProduto,
                    Quantidade = item.Quantidade,
                    ValorUnitario = item.ValorUnitario
                });
                //atualiza o estoque do produto
                banco.Execute(
                "UPDATE Produtos SET Quantidade = (Quantidade - " + item.Quantidade + ") " +
                "where ID = @id", new { id = item.IDProduto });
            }

            return idVenda;
        }
    }
}