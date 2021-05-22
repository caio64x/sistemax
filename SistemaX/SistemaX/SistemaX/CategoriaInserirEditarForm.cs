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
    public partial class CategoriaInserirEditarForm : Form
    {
        Categoria categoria = null;
        public CategoriaInserirEditarForm()
        {
            InitializeComponent();
            Application.DoEvents();

            this.Text = "Nova Categoria";
            idTextBox.Text = "Automático";
            idTextBox.Enabled = false;
            excluirButton.Enabled = false;
            categoria = new Categoria();

        }

        public CategoriaInserirEditarForm(int id)
        {
            InitializeComponent();
            Application.DoEvents();

            this.Text = "Alteração de Categoria";
            categoria = new CategoriaDAO().Buscar(id);

            idTextBox.Text = categoria.ID.ToString();
            idTextBox.Enabled = false;

            nomeTextBox.Text = categoria.Nome;
            ativoCheckBox.Checked = categoria.Ativo;

            excluirButton.Enabled = true;
        }

        private void fecharButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            categoria.Nome = nomeTextBox.Text.Trim();
            categoria.Ativo = ativoCheckBox.Checked;
            categoria.ID= new CategoriaDAO().Salvar(categoria);

            if (categoria.ID == 0)
            {
                MessageBox.Show("Erro ao salvar!");
            }
            else
            {
                this.Text = "Alteração de Categoria";
                idTextBox.Text = categoria.ID.ToString();
                excluirButton.Enabled = true;

                MessageBox.Show("Registro salvo com sucesso!");
            }

        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir o registro " + categoria.Nome + "?",
                "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var resp = new CategoriaDAO().Excluir(categoria.ID);
                if (resp)
                {
                    MessageBox.Show("Excluído com sucesso");
                    Close();
                }
                else
                {
                    MessageBox.Show("Erro ao excluir!");
                }
            }
        }

       
    }
}
