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
    public partial class ClientePesquisarForm : Form
    {
        public ClientePesquisarForm()
        {
            InitializeComponent();
            Application.DoEvents();
        }

        ClienteDAO clienteDAO = new ClienteDAO();
        List<Cliente> lista = new List<Cliente>();

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void voltarButton_Click(object sender, EventArgs e)
        {
            try
            {
                Compartilhada.IDCliente = Convert.ToInt32(
           dataGridView1.SelectedRows[0].Cells[0].Value);
            }
            catch { }

            Close();
        }

        private void nomeClienteTextBox_TextChanged(object sender, EventArgs e)
        {
            lista = clienteDAO.Listar(nomeClienteTextBox.Text.Trim());
            dataGridView1.DataSource = lista;
        }
    }
}
