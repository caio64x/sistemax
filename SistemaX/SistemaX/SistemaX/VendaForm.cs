using SistemaX.Negocios.DAL;
using SistemaX.Negocios.Mapeamento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaX
{
    public partial class VendaForm : Form
    {
        public VendaForm()
        {
            InitializeComponent();
            Application.DoEvents();
        }

        Cliente clienteSelecionado = null;
        Produto produtoSelecionado = null;
        List<ItensGrid> listaItem = new List<ItensGrid>();
        void PesquisarCliente()
        {
            if (idClienteTextBox.Text.Trim().Length == 0)
            {
                Compartilhada.IDCliente = 0;
                new ClientePesquisarForm().ShowDialog();
                idClienteTextBox.Text = Compartilhada.IDCliente.ToString();
            }



            try
            {
                int idCliente = Convert.ToInt32(idClienteTextBox.Text);
                clienteSelecionado = new ClienteDAO().Buscar(idCliente);
            }
            catch
            {
                clienteSelecionado = null;
            }



            if (clienteSelecionado == null)
            {
                nomeClienteTextBox.Text = "";
                telefoneClienteTextBox.Text = "";

            }
            else
            {
                nomeClienteTextBox.Text = clienteSelecionado.Nome;
                telefoneClienteTextBox.Text = clienteSelecionado.Telefone;
                idProdutoTextBox.Focus();
            }
        }

        void PesquisarProduto()
        {
            //if (idProdutoTextBox.Text.Trim().Length == 0)
            //{
            //    Compartilhada.IDCliente = 0;
            //    new ProdutoPesquisarForm().ShowDialog();
            //    idProdutoTextBox.Text = Compartilhada.IDProduto.ToString();
            //}



            try
            {
                int idProduto = Convert.ToInt32(idProdutoTextBox.Text);
                produtoSelecionado = new ProdutoDAO().Buscar(idProduto);
            }
            catch
            {
                produtoSelecionado = null;
            }



            if (produtoSelecionado == null)
            {
                nomeProdutoTextBox.Text = "";
                estoqueTextBox.Text = "";
                quantidadeNumericUpDown.Value = 0;
                valorUnitarioNumericUpDown.Value = int.Parse("");
                valorTotalProdutoTextBox.Text = "";

            }
            else
            {
                nomeProdutoTextBox.Text = produtoSelecionado.Nome;
                estoqueTextBox.Text = produtoSelecionado.Quantidade.ToString("N0");
                valorUnitarioNumericUpDown.Value = produtoSelecionado.Valor;
                quantidadeNumericUpDown.Focus();
            }
        }



        private void buscarClienteButton_Click(object sender, EventArgs e)
        {
            idClienteTextBox.Text = "";
            PesquisarCliente();
        }

        private void idClienteTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PesquisarCliente();
            }
        }

        private void idProdutoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PesquisarProduto();
            }
        }

        private void buscarProdutoButton_Click(object sender, EventArgs e)
        {
            idProdutoTextBox.Text = "";
            PesquisarProduto();

        }

        private void quantidadeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {


            quantidadeNumericUpDown.Select();
            valorTotalProdutoTextBox.Text = (valorUnitarioNumericUpDown.Value * quantidadeNumericUpDown.Value).ToString("C2");
        }

        private void valorUnitarioNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            valorTotalProdutoTextBox.Text = (valorUnitarioNumericUpDown.Value * quantidadeNumericUpDown.Value).ToString("C2");

        }

        private void adcionarButton_Click(object sender, EventArgs e)
        {
            if (clienteSelecionado == null)
            {
                MessageBox.Show("Selecione um cliente!");
                return;
            }
            if (produtoSelecionado == null)
            {
                MessageBox.Show("Selecione um produto!");
                return;
            }
            if (quantidadeNumericUpDown.Value > produtoSelecionado.Quantidade)
            {
                MessageBox.Show("Quantidade maior do que em estoque!");
                return;
            }

            ItensGrid item = new ItensGrid();
            item.IDProduto = produtoSelecionado.ID;
            item.NomeProduto = produtoSelecionado.Nome;
            item.Quantidade = Convert.ToInt32(quantidadeNumericUpDown.Value);
            item.ValorUnitario = valorUnitarioNumericUpDown.Value;
            listaItem.Add(item);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaItem;
            //
            produtoSelecionado = null;
            idProdutoTextBox.Text = "";
            nomeProdutoTextBox.Text = "";
            quantidadeNumericUpDown.Value = 0;
            valorUnitarioNumericUpDown.Value = 0;
            valorTotalProdutoTextBox.Text = "";
            idProdutoTextBox.Focus();
            valorTotalGeralTextBox.Text = listaItem.Sum(s => s.ValorTotal).ToString("C2");

        }

        private void excluirProdutoButton_Click(object sender, EventArgs e)
        {
            int idProd = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            var item = listaItem.SingleOrDefault(w => w.IDProduto == idProd);

            if (item != null)
            {
                listaItem.Remove(item);
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaItem;
            valorTotalGeralTextBox.Text = listaItem.Sum(s => s.ValorTotal).ToString("C2");

        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            if (clienteSelecionado == null)
            {
                MessageBox.Show("Selecione um cliente!");
                return;
            }

            int idVenda = new VendaDAO().Salvar(
                clienteSelecionado.ID,
                obseracaoTextBox.Text,
                listaItem);

            MessageBox.Show("venda  " + idVenda + " gravada com sucesso!");
            salvarButton.Enabled = false;
        }

        
    }
}
