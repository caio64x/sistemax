
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using System.Data.SqlClient;
using SistemaX.Negocios.Mapeamento;
using SistemaX.Negocios.DAL;
namespace SistemaX
{
    public partial class TesteForm : Form
    {
        SqlConnection banco;

        public TesteForm()
        {
            InitializeComponent();
        }
        CategoriaDAO categoria = new CategoriaDAO();

        private void button1_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = categoria.Listar1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //dataGridView2.DataSource = categoria.Listar2();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //dataGridView3.DataSource = categoria.Listar3();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            Categoria categoria = new Categoria();
            categoria.Nome = "cadastro " + DateTime.Now.ToString();
            categoria.Ativo = true;
            this.banco= Conexao.getConnection();

            int resp = banco.Execute("insert into categorias (nome,ativo) values (@Nome,@Ativo)", categoria);
            MessageBox.Show(resp.ToString());
        }
    }
}
