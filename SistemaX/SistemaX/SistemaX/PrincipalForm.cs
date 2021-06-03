using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaX
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void pegarStringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var str = System.Configuration.ConfigurationManager.AppSettings["banco"];
            MessageBox.Show(str);
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TesteForm testeForm = new TesteForm();
            testeForm.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ProdutoListarForm();
            form.MdiParent = this;
            form.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new CategoriaListarForm();
            form.MdiParent = this;
            form.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new UsuariosListarForm();
            form.MdiParent = this;
            form.Show();

        }

        public void ValidarUsuario()
        {
            if (Compartilhada.UsuarioLogado == null)
            {

                loginToolStripButton.Text = "ENTRAR";
                loginToolStripButton.Image = SistemaX.Properties.Resources.entrar;

                categoriasToolStripButton.Enabled = false;
                produtosToolStripButton.Enabled = false;
                vendasToolStripButton.Enabled = false;

                produtosToolStripMenuItem.Enabled = false;

                usuarioToolStripStatusLabel.Text = "Usuário não logado";

            }
            else
            {
                loginToolStripButton.Text = "SAIR";
               loginToolStripButton.Image = SistemaX.Properties.Resources.sair;

                categoriasToolStripButton.Enabled = Compartilhada.UsuarioLogado.AcessaCategorias;
                produtosToolStripButton.Enabled = Compartilhada.UsuarioLogado.AcessaProdutos;
                vendasToolStripButton.Enabled = Compartilhada.UsuarioLogado.AcessaUsuarios;

                categoriasToolStripMenuItem.Enabled = Compartilhada.UsuarioLogado.AcessaCategorias;
                produtosToolStripMenuItem.Enabled = Compartilhada.UsuarioLogado.AcessaProdutos;
                usuariosToolStripMenuItem.Enabled = Compartilhada.UsuarioLogado.AcessaUsuarios;

                usuarioToolStripStatusLabel.Text = "Usuário: " + Compartilhada.UsuarioLogado.Nome;

            }
        }

        private void loginToolStripButton_Click(object sender, EventArgs e)
        {
            Compartilhada.UsuarioLogado = null;

            ValidarUsuario();

            new LoginForm().ShowDialog();

            ValidarUsuario();
        }

        private void PrincipalForm_Shown(object sender, EventArgs e)
        {
            Compartilhada.UsuarioLogado = null;

            ValidarUsuario();

            new LoginForm().ShowDialog();

            ValidarUsuario();
        }

        private void vendasToolStripButton_Click(object sender, EventArgs e)
        {
            var form = new VendaForm();
            form.MdiParent = this;
            form.Show();
        }

        
    }

}
