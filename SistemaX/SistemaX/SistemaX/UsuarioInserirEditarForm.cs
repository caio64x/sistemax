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
    public partial class UsuarioInserirEditarForm : Form
    {
        Usuario usuario = null;
      
        public UsuarioInserirEditarForm()
        {
            InitializeComponent();
            Application.DoEvents();

            this.Text = "Novo Usuário";
            idTextBox.Text = "Automático";
            idTextBox.Enabled = false;
            excluirButton.Enabled = false;
            usuario = new Usuario();
        }


        public UsuarioInserirEditarForm(int id)
        {
            InitializeComponent();
            Application.DoEvents();

            this.Text = "Alteração de Usuário";
            usuario = new UsuarioDAO().Buscar(id);

            idTextBox.Text = usuario.ID.ToString();
            idTextBox.Enabled = false;

            nomeTextBox.Text = usuario.Nome;
            loginTextBox.Text = usuario.Login;
            senhaTextBox.Text = usuario.Senha;

            ativoCheckBox.Checked = usuario.Ativo;
            categoriasCheckBox.Checked = usuario.AcessaCategorias;
            produtosCheckBox.Checked = usuario.AcessaProdutos;
            usuariosCheckBox.Checked = usuario.AcessaUsuarios;
            excluirButton.Enabled = true;


        }

        private void fecharButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            usuario.Nome = nomeTextBox.Text.Trim();
            usuario.Ativo = ativoCheckBox.Checked;
            usuario.Login = loginTextBox.Text.Trim();
            usuario.Senha = senhaTextBox.Text.Trim();
            usuario.AcessaCategorias = categoriasCheckBox.Checked;
            usuario.AcessaProdutos = produtosCheckBox.Checked;
            usuario.AcessaUsuarios = usuariosCheckBox.Checked;

            usuario.ID = new UsuarioDAO().Salvar(usuario);

            if (usuario.ID == 0)
            {
                MessageBox.Show("Erro ao salvar!");
            }
            else
            {
                this.Text = "Novo Usuário";

                idTextBox.Text = usuario.ID.ToString();
                excluirButton.Enabled = true;

                MessageBox.Show("Registro salvo com sucesso!");

            }

        }


        private void excluirButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir o registro " + usuario.Nome + "?",
                "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var resp = new UsuarioDAO().Excluir(usuario.ID);
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
