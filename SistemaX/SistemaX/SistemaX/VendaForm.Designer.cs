namespace SistemaX
{
    partial class VendaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.adcionarButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.estoqueTextBox = new System.Windows.Forms.TextBox();
            this.valorTotalProdutoTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.valorUnitarioNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.quantidadeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.buscarProdutoButton = new System.Windows.Forms.Button();
            this.nomeProdutoTextBox = new System.Windows.Forms.TextBox();
            this.idProdutoTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.excluirProdutoButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itensGridBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salvarButton = new System.Windows.Forms.Button();
            this.valorTotalGeralTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.obseracaoTextBox = new System.Windows.Forms.TextBox();
            this.baixo = new System.Windows.Forms.Panel();
            this.vendagroupBox = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.telefoneClienteTextBox = new System.Windows.Forms.TextBox();
            this.buscarClienteButton = new System.Windows.Forms.Button();
            this.nomeClienteTextBox = new System.Windows.Forms.TextBox();
            this.idClienteTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valorUnitarioNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantidadeNumericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensGridBindingSource)).BeginInit();
            this.baixo.SuspendLayout();
            this.vendagroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.adcionarButton);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.estoqueTextBox);
            this.groupBox1.Controls.Add(this.valorTotalProdutoTextBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.valorUnitarioNumericUpDown);
            this.groupBox1.Controls.Add(this.quantidadeNumericUpDown);
            this.groupBox1.Controls.Add(this.buscarProdutoButton);
            this.groupBox1.Controls.Add(this.nomeProdutoTextBox);
            this.groupBox1.Controls.Add(this.idProdutoTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(888, 102);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionar produto";
            // 
            // adcionarButton
            // 
            this.adcionarButton.BackColor = System.Drawing.Color.Lime;
            this.adcionarButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.adcionarButton.Location = new System.Drawing.Point(3, 71);
            this.adcionarButton.Name = "adcionarButton";
            this.adcionarButton.Size = new System.Drawing.Size(882, 28);
            this.adcionarButton.TabIndex = 4;
            this.adcionarButton.Text = "Adicionar";
            this.adcionarButton.UseVisualStyleBackColor = false;
            this.adcionarButton.Click += new System.EventHandler(this.adcionarButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(503, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Estoque";
            // 
            // estoqueTextBox
            // 
            this.estoqueTextBox.Enabled = false;
            this.estoqueTextBox.Location = new System.Drawing.Point(506, 43);
            this.estoqueTextBox.Name = "estoqueTextBox";
            this.estoqueTextBox.Size = new System.Drawing.Size(85, 20);
            this.estoqueTextBox.TabIndex = 12;
            // 
            // valorTotalProdutoTextBox
            // 
            this.valorTotalProdutoTextBox.Enabled = false;
            this.valorTotalProdutoTextBox.Location = new System.Drawing.Point(771, 43);
            this.valorTotalProdutoTextBox.Name = "valorTotalProdutoTextBox";
            this.valorTotalProdutoTextBox.Size = new System.Drawing.Size(120, 20);
            this.valorTotalProdutoTextBox.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(768, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Valor total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(662, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Valor unitário";
            // 
            // valorUnitarioNumericUpDown
            // 
            this.valorUnitarioNumericUpDown.DecimalPlaces = 2;
            this.valorUnitarioNumericUpDown.Location = new System.Drawing.Point(662, 43);
            this.valorUnitarioNumericUpDown.Name = "valorUnitarioNumericUpDown";
            this.valorUnitarioNumericUpDown.Size = new System.Drawing.Size(103, 20);
            this.valorUnitarioNumericUpDown.TabIndex = 3;
            this.valorUnitarioNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.valorUnitarioNumericUpDown.ValueChanged += new System.EventHandler(this.valorUnitarioNumericUpDown_ValueChanged);
            // 
            // quantidadeNumericUpDown
            // 
            this.quantidadeNumericUpDown.Location = new System.Drawing.Point(597, 44);
            this.quantidadeNumericUpDown.Name = "quantidadeNumericUpDown";
            this.quantidadeNumericUpDown.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.quantidadeNumericUpDown.Size = new System.Drawing.Size(59, 20);
            this.quantidadeNumericUpDown.TabIndex = 2;
            this.quantidadeNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.quantidadeNumericUpDown.ValueChanged += new System.EventHandler(this.quantidadeNumericUpDown_ValueChanged);
            // 
            // buscarProdutoButton
            // 
            this.buscarProdutoButton.Location = new System.Drawing.Point(141, 41);
            this.buscarProdutoButton.Name = "buscarProdutoButton";
            this.buscarProdutoButton.Size = new System.Drawing.Size(27, 23);
            this.buscarProdutoButton.TabIndex = 6;
            this.buscarProdutoButton.Text = "...";
            this.buscarProdutoButton.UseVisualStyleBackColor = true;
            this.buscarProdutoButton.Click += new System.EventHandler(this.buscarProdutoButton_Click);
            this.buscarProdutoButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.idProdutoTextBox_KeyDown);
            // 
            // nomeProdutoTextBox
            // 
            this.nomeProdutoTextBox.Enabled = false;
            this.nomeProdutoTextBox.Location = new System.Drawing.Point(169, 43);
            this.nomeProdutoTextBox.Name = "nomeProdutoTextBox";
            this.nomeProdutoTextBox.Size = new System.Drawing.Size(331, 20);
            this.nomeProdutoTextBox.TabIndex = 1;
            // 
            // idProdutoTextBox
            // 
            this.idProdutoTextBox.Location = new System.Drawing.Point(6, 43);
            this.idProdutoTextBox.Name = "idProdutoTextBox";
            this.idProdutoTextBox.Size = new System.Drawing.Size(135, 20);
            this.idProdutoTextBox.TabIndex = 0;
            this.idProdutoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.idProdutoTextBox_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(594, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Quantidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nome";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Código";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.excluirProdutoButton);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(0, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(897, 245);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Itens da venda";
            // 
            // excluirProdutoButton
            // 
            this.excluirProdutoButton.BackColor = System.Drawing.Color.Salmon;
            this.excluirProdutoButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.excluirProdutoButton.Location = new System.Drawing.Point(3, 214);
            this.excluirProdutoButton.Name = "excluirProdutoButton";
            this.excluirProdutoButton.Size = new System.Drawing.Size(891, 28);
            this.excluirProdutoButton.TabIndex = 15;
            this.excluirProdutoButton.Text = "Excluir produto";
            this.excluirProdutoButton.UseVisualStyleBackColor = false;
            this.excluirProdutoButton.Click += new System.EventHandler(this.excluirProdutoButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDProdutoDataGridViewTextBoxColumn,
            this.nomeProdutoDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.valorUnitarioDataGridViewTextBoxColumn,
            this.valorTotalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.itensGridBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(891, 226);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDProdutoDataGridViewTextBoxColumn
            // 
            this.iDProdutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.iDProdutoDataGridViewTextBoxColumn.DataPropertyName = "IDProduto";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.iDProdutoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.iDProdutoDataGridViewTextBoxColumn.HeaderText = "IDProduto";
            this.iDProdutoDataGridViewTextBoxColumn.Name = "iDProdutoDataGridViewTextBoxColumn";
            this.iDProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDProdutoDataGridViewTextBoxColumn.Width = 80;
            // 
            // nomeProdutoDataGridViewTextBoxColumn
            // 
            this.nomeProdutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeProdutoDataGridViewTextBoxColumn.DataPropertyName = "NomeProduto";
            this.nomeProdutoDataGridViewTextBoxColumn.HeaderText = "Produto";
            this.nomeProdutoDataGridViewTextBoxColumn.Name = "nomeProdutoDataGridViewTextBoxColumn";
            this.nomeProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.quantidadeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorUnitarioDataGridViewTextBoxColumn
            // 
            this.valorUnitarioDataGridViewTextBoxColumn.DataPropertyName = "ValorUnitario";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            this.valorUnitarioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.valorUnitarioDataGridViewTextBoxColumn.HeaderText = "Valor Unitario";
            this.valorUnitarioDataGridViewTextBoxColumn.Name = "valorUnitarioDataGridViewTextBoxColumn";
            this.valorUnitarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorTotalDataGridViewTextBoxColumn
            // 
            this.valorTotalDataGridViewTextBoxColumn.DataPropertyName = "ValorTotal";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "C2";
            this.valorTotalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.valorTotalDataGridViewTextBoxColumn.HeaderText = "ValorTotal";
            this.valorTotalDataGridViewTextBoxColumn.Name = "valorTotalDataGridViewTextBoxColumn";
            this.valorTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itensGridBindingSource
            // 
            this.itensGridBindingSource.DataSource = typeof(SistemaX.Negocios.Mapeamento.ItensGrid);
            // 
            // salvarButton
            // 
            this.salvarButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.salvarButton.Location = new System.Drawing.Point(813, 51);
            this.salvarButton.Name = "salvarButton";
            this.salvarButton.Size = new System.Drawing.Size(75, 23);
            this.salvarButton.TabIndex = 4;
            this.salvarButton.Text = "Gravar venda";
            this.salvarButton.UseVisualStyleBackColor = false;
            this.salvarButton.Click += new System.EventHandler(this.salvarButton_Click);
            // 
            // valorTotalGeralTextBox
            // 
            this.valorTotalGeralTextBox.Location = new System.Drawing.Point(732, 24);
            this.valorTotalGeralTextBox.Name = "valorTotalGeralTextBox";
            this.valorTotalGeralTextBox.Size = new System.Drawing.Size(151, 20);
            this.valorTotalGeralTextBox.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(729, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Valor total";
            // 
            // cancelarButton
            // 
            this.cancelarButton.Location = new System.Drawing.Point(732, 51);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(75, 23);
            this.cancelarButton.TabIndex = 7;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Observação";
            // 
            // obseracaoTextBox
            // 
            this.obseracaoTextBox.Location = new System.Drawing.Point(9, 21);
            this.obseracaoTextBox.Multiline = true;
            this.obseracaoTextBox.Name = "obseracaoTextBox";
            this.obseracaoTextBox.Size = new System.Drawing.Size(720, 50);
            this.obseracaoTextBox.TabIndex = 9;
            // 
            // baixo
            // 
            this.baixo.Controls.Add(this.salvarButton);
            this.baixo.Controls.Add(this.label10);
            this.baixo.Controls.Add(this.cancelarButton);
            this.baixo.Controls.Add(this.obseracaoTextBox);
            this.baixo.Controls.Add(this.label11);
            this.baixo.Controls.Add(this.valorTotalGeralTextBox);
            this.baixo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.baixo.Location = new System.Drawing.Point(0, 418);
            this.baixo.Name = "baixo";
            this.baixo.Size = new System.Drawing.Size(888, 83);
            this.baixo.TabIndex = 10;
            // 
            // vendagroupBox
            // 
            this.vendagroupBox.Controls.Add(this.panel1);
            this.vendagroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.vendagroupBox.Location = new System.Drawing.Point(0, 0);
            this.vendagroupBox.Name = "vendagroupBox";
            this.vendagroupBox.Size = new System.Drawing.Size(888, 70);
            this.vendagroupBox.TabIndex = 0;
            this.vendagroupBox.TabStop = false;
            this.vendagroupBox.Text = "Dados do Cliente";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.telefoneClienteTextBox);
            this.panel1.Controls.Add(this.buscarClienteButton);
            this.panel1.Controls.Add(this.nomeClienteTextBox);
            this.panel1.Controls.Add(this.idClienteTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 156);
            this.panel1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(639, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone";
            // 
            // telefoneClienteTextBox
            // 
            this.telefoneClienteTextBox.Enabled = false;
            this.telefoneClienteTextBox.Location = new System.Drawing.Point(642, 28);
            this.telefoneClienteTextBox.Name = "telefoneClienteTextBox";
            this.telefoneClienteTextBox.Size = new System.Drawing.Size(243, 20);
            this.telefoneClienteTextBox.TabIndex = 5;
            // 
            // buscarClienteButton
            // 
            this.buscarClienteButton.Location = new System.Drawing.Point(138, 24);
            this.buscarClienteButton.Name = "buscarClienteButton";
            this.buscarClienteButton.Size = new System.Drawing.Size(27, 23);
            this.buscarClienteButton.TabIndex = 6;
            this.buscarClienteButton.Text = "...";
            this.buscarClienteButton.UseVisualStyleBackColor = true;
            this.buscarClienteButton.Click += new System.EventHandler(this.buscarClienteButton_Click);
            this.buscarClienteButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.idClienteTextBox_KeyDown);
            // 
            // nomeClienteTextBox
            // 
            this.nomeClienteTextBox.Enabled = false;
            this.nomeClienteTextBox.Location = new System.Drawing.Point(166, 27);
            this.nomeClienteTextBox.Name = "nomeClienteTextBox";
            this.nomeClienteTextBox.Size = new System.Drawing.Size(473, 20);
            this.nomeClienteTextBox.TabIndex = 4;
            // 
            // idClienteTextBox
            // 
            this.idClienteTextBox.Location = new System.Drawing.Point(6, 27);
            this.idClienteTextBox.Name = "idClienteTextBox";
            this.idClienteTextBox.Size = new System.Drawing.Size(135, 20);
            this.idClienteTextBox.TabIndex = 0;
            this.idClienteTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.idClienteTextBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // VendaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 501);
            this.Controls.Add(this.baixo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.vendagroupBox);
            this.Name = "VendaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VendaForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valorUnitarioNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantidadeNumericUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensGridBindingSource)).EndInit();
            this.baixo.ResumeLayout(false);
            this.baixo.PerformLayout();
            this.vendagroupBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox valorTotalProdutoTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown valorUnitarioNumericUpDown;
        private System.Windows.Forms.NumericUpDown quantidadeNumericUpDown;
        private System.Windows.Forms.Button buscarProdutoButton;
        private System.Windows.Forms.TextBox nomeProdutoTextBox;
        private System.Windows.Forms.TextBox idProdutoTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox estoqueTextBox;
        private System.Windows.Forms.Button adcionarButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button salvarButton;
        private System.Windows.Forms.TextBox valorTotalGeralTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox obseracaoTextBox;
        private System.Windows.Forms.Button excluirProdutoButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource itensGridBindingSource;
        private System.Windows.Forms.Panel baixo;
        private System.Windows.Forms.GroupBox vendagroupBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox telefoneClienteTextBox;
        private System.Windows.Forms.Button buscarClienteButton;
        private System.Windows.Forms.TextBox nomeClienteTextBox;
        private System.Windows.Forms.TextBox idClienteTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}