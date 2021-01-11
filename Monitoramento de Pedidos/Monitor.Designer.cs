
namespace Monitoramento_de_Pedidos
{
    partial class Monitor
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvCarrinho = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txnumeroPedido = new System.Windows.Forms.TextBox();
            this.formaPagamento = new System.Windows.Forms.TextBox();
            this.valorTroco = new System.Windows.Forms.TextBox();
            this.troco = new System.Windows.Forms.TextBox();
            this.total = new System.Windows.Forms.TextBox();
            this.taxaEntrega = new System.Windows.Forms.TextBox();
            this.subTotal = new System.Windows.Forms.TextBox();
            this.entrega = new System.Windows.Forms.TextBox();
            this.bairro = new System.Windows.Forms.TextBox();
            this.numero = new System.Windows.Forms.TextBox();
            this.endereco = new System.Windows.Forms.TextBox();
            this.telefone = new System.Windows.Forms.TextBox();
            this.nome = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.recusarPedido = new System.Windows.Forms.Button();
            this.aceitarPedido = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvAceitos = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblAceitos = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.dgvVendas = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.novasVendas = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinho)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAceitos)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1207, 749);
            this.panel1.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.panel2);
            this.panel9.Controls.Add(this.panel6);
            this.panel9.Controls.Add(this.panel3);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1207, 749);
            this.panel9.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(420, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 749);
            this.panel2.TabIndex = 177;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvCarrinho);
            this.groupBox2.Location = new System.Drawing.Point(8, 382);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox2.Size = new System.Drawing.Size(351, 241);
            this.groupBox2.TabIndex = 176;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produtos Pedidos";
            // 
            // dgvCarrinho
            // 
            this.dgvCarrinho.AllowUserToAddRows = false;
            this.dgvCarrinho.AllowUserToDeleteRows = false;
            this.dgvCarrinho.AllowUserToResizeColumns = false;
            this.dgvCarrinho.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvCarrinho.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCarrinho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCarrinho.BackgroundColor = System.Drawing.Color.White;
            this.dgvCarrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCarrinho.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvCarrinho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCarrinho.Location = new System.Drawing.Point(3, 23);
            this.dgvCarrinho.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgvCarrinho.MultiSelect = false;
            this.dgvCarrinho.Name = "dgvCarrinho";
            this.dgvCarrinho.ReadOnly = true;
            this.dgvCarrinho.RowHeadersVisible = false;
            this.dgvCarrinho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarrinho.Size = new System.Drawing.Size(345, 213);
            this.dgvCarrinho.TabIndex = 177;
            this.dgvCarrinho.TabStop = false;
            this.dgvCarrinho.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCarrinho_CellFormatting);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txnumeroPedido);
            this.groupBox1.Controls.Add(this.formaPagamento);
            this.groupBox1.Controls.Add(this.valorTroco);
            this.groupBox1.Controls.Add(this.troco);
            this.groupBox1.Controls.Add(this.total);
            this.groupBox1.Controls.Add(this.taxaEntrega);
            this.groupBox1.Controls.Add(this.subTotal);
            this.groupBox1.Controls.Add(this.entrega);
            this.groupBox1.Controls.Add(this.bairro);
            this.groupBox1.Controls.Add(this.numero);
            this.groupBox1.Controls.Add(this.endereco);
            this.groupBox1.Controls.Add(this.telefone);
            this.groupBox1.Controls.Add(this.nome);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Size = new System.Drawing.Size(367, 369);
            this.groupBox1.TabIndex = 175;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do Pedido";
            // 
            // txnumeroPedido
            // 
            this.txnumeroPedido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txnumeroPedido.Location = new System.Drawing.Point(8, 33);
            this.txnumeroPedido.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txnumeroPedido.Name = "txnumeroPedido";
            this.txnumeroPedido.Size = new System.Drawing.Size(98, 18);
            this.txnumeroPedido.TabIndex = 12;
            // 
            // formaPagamento
            // 
            this.formaPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.formaPagamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.formaPagamento.Location = new System.Drawing.Point(122, 166);
            this.formaPagamento.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.formaPagamento.Name = "formaPagamento";
            this.formaPagamento.Size = new System.Drawing.Size(237, 18);
            this.formaPagamento.TabIndex = 11;
            this.formaPagamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // valorTroco
            // 
            this.valorTroco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.valorTroco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valorTroco.ForeColor = System.Drawing.Color.Red;
            this.valorTroco.Location = new System.Drawing.Point(227, 299);
            this.valorTroco.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.valorTroco.Name = "valorTroco";
            this.valorTroco.Size = new System.Drawing.Size(130, 18);
            this.valorTroco.TabIndex = 10;
            this.valorTroco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // troco
            // 
            this.troco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.troco.Location = new System.Drawing.Point(187, 299);
            this.troco.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.troco.Name = "troco";
            this.troco.Size = new System.Drawing.Size(140, 18);
            this.troco.TabIndex = 9;
            // 
            // total
            // 
            this.total.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.total.ForeColor = System.Drawing.Color.Red;
            this.total.Location = new System.Drawing.Point(8, 299);
            this.total.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(154, 18);
            this.total.TabIndex = 8;
            // 
            // taxaEntrega
            // 
            this.taxaEntrega.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taxaEntrega.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.taxaEntrega.Location = new System.Drawing.Point(8, 255);
            this.taxaEntrega.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.taxaEntrega.Name = "taxaEntrega";
            this.taxaEntrega.Size = new System.Drawing.Size(65, 18);
            this.taxaEntrega.TabIndex = 7;
            // 
            // subTotal
            // 
            this.subTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.subTotal.Location = new System.Drawing.Point(8, 211);
            this.subTotal.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.subTotal.Name = "subTotal";
            this.subTotal.Size = new System.Drawing.Size(65, 18);
            this.subTotal.TabIndex = 6;
            // 
            // entrega
            // 
            this.entrega.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.entrega.Location = new System.Drawing.Point(8, 166);
            this.entrega.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.entrega.Name = "entrega";
            this.entrega.Size = new System.Drawing.Size(217, 18);
            this.entrega.TabIndex = 5;
            // 
            // bairro
            // 
            this.bairro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bairro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bairro.Location = new System.Drawing.Point(8, 122);
            this.bairro.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bairro.Name = "bairro";
            this.bairro.Size = new System.Drawing.Size(167, 18);
            this.bairro.TabIndex = 4;
            // 
            // numero
            // 
            this.numero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numero.Location = new System.Drawing.Point(269, 77);
            this.numero.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(88, 18);
            this.numero.TabIndex = 3;
            this.numero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // endereco
            // 
            this.endereco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.endereco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.endereco.Location = new System.Drawing.Point(8, 77);
            this.endereco.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.endereco.Name = "endereco";
            this.endereco.Size = new System.Drawing.Size(251, 18);
            this.endereco.TabIndex = 2;
            // 
            // telefone
            // 
            this.telefone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.telefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.telefone.Location = new System.Drawing.Point(258, 33);
            this.telefone.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(99, 18);
            this.telefone.TabIndex = 1;
            this.telefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nome
            // 
            this.nome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nome.Location = new System.Drawing.Point(112, 33);
            this.nome.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(140, 18);
            this.nome.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.Controls.Add(this.recusarPedido);
            this.panel8.Controls.Add(this.aceitarPedido);
            this.panel8.Location = new System.Drawing.Point(8, 652);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(346, 81);
            this.panel8.TabIndex = 173;
            // 
            // recusarPedido
            // 
            this.recusarPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.recusarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recusarPedido.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recusarPedido.Location = new System.Drawing.Point(168, 21);
            this.recusarPedido.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.recusarPedido.Name = "recusarPedido";
            this.recusarPedido.Size = new System.Drawing.Size(145, 41);
            this.recusarPedido.TabIndex = 165;
            this.recusarPedido.Text = "Recusar Pedido";
            this.recusarPedido.UseVisualStyleBackColor = true;
            this.recusarPedido.Visible = false;
            this.recusarPedido.Click += new System.EventHandler(this.btnRecusar_Click);
            // 
            // aceitarPedido
            // 
            this.aceitarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aceitarPedido.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceitarPedido.Location = new System.Drawing.Point(22, 21);
            this.aceitarPedido.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.aceitarPedido.Name = "aceitarPedido";
            this.aceitarPedido.Size = new System.Drawing.Size(160, 41);
            this.aceitarPedido.TabIndex = 164;
            this.aceitarPedido.Text = "Aceitar Pedido";
            this.aceitarPedido.UseVisualStyleBackColor = true;
            this.aceitarPedido.Visible = false;
            this.aceitarPedido.Click += new System.EventHandler(this.aceitarPedido_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button2);
            this.panel6.Controls.Add(this.dgvAceitos);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(787, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(420, 749);
            this.panel6.TabIndex = 176;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(149, 673);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 41);
            this.button2.TabIndex = 171;
            this.button2.Text = "Reimprimir Pedido";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // dgvAceitos
            // 
            this.dgvAceitos.AllowUserToAddRows = false;
            this.dgvAceitos.AllowUserToDeleteRows = false;
            this.dgvAceitos.AllowUserToResizeColumns = false;
            this.dgvAceitos.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvAceitos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvAceitos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAceitos.BackgroundColor = System.Drawing.Color.White;
            this.dgvAceitos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAceitos.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvAceitos.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvAceitos.Location = new System.Drawing.Point(0, 67);
            this.dgvAceitos.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgvAceitos.MultiSelect = false;
            this.dgvAceitos.Name = "dgvAceitos";
            this.dgvAceitos.ReadOnly = true;
            this.dgvAceitos.RowHeadersVisible = false;
            this.dgvAceitos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAceitos.Size = new System.Drawing.Size(420, 551);
            this.dgvAceitos.TabIndex = 169;
            this.dgvAceitos.TabStop = false;
            this.dgvAceitos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAceitos_CellDoubleClick);
            this.dgvAceitos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAceitos_CellFormatting);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lblAceitos);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(420, 67);
            this.panel7.TabIndex = 1;
            // 
            // lblAceitos
            // 
            this.lblAceitos.AutoSize = true;
            this.lblAceitos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAceitos.Location = new System.Drawing.Point(146, 16);
            this.lblAceitos.Name = "lblAceitos";
            this.lblAceitos.Size = new System.Drawing.Size(104, 17);
            this.lblAceitos.TabIndex = 0;
            this.lblAceitos.Text = "Pedidos Aceitos";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(420, 749);
            this.panel3.TabIndex = 175;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnAtualizar);
            this.panel4.Controls.Add(this.dgvVendas);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 67);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(420, 682);
            this.panel4.TabIndex = 170;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(107, 606);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(194, 41);
            this.btnAtualizar.TabIndex = 170;
            this.btnAtualizar.Text = "Atualizar Pedidos Pendentes";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // dgvVendas
            // 
            this.dgvVendas.AllowUserToAddRows = false;
            this.dgvVendas.AllowUserToDeleteRows = false;
            this.dgvVendas.AllowUserToResizeColumns = false;
            this.dgvVendas.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvVendas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvVendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVendas.BackgroundColor = System.Drawing.Color.White;
            this.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVendas.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvVendas.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvVendas.Location = new System.Drawing.Point(0, 0);
            this.dgvVendas.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgvVendas.MultiSelect = false;
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.ReadOnly = true;
            this.dgvVendas.RowHeadersVisible = false;
            this.dgvVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVendas.Size = new System.Drawing.Size(420, 551);
            this.dgvVendas.TabIndex = 169;
            this.dgvVendas.TabStop = false;
            this.dgvVendas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVendas_CellDoubleClick);
            this.dgvVendas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvVendas_CellFormatting);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(420, 67);
            this.panel5.TabIndex = 169;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pedidos Pendentes";
            // 
            // novasVendas
            // 
            this.novasVendas.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.novasVendas.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.novasVendas_RunWorkerCompleted);
            // 
            // Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 749);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Monitor";
            this.Text = "Monitoramento de Pedidos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinho)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAceitos)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvCarrinho;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txnumeroPedido;
        private System.Windows.Forms.TextBox formaPagamento;
        private System.Windows.Forms.TextBox valorTroco;
        private System.Windows.Forms.TextBox troco;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.TextBox taxaEntrega;
        private System.Windows.Forms.TextBox subTotal;
        private System.Windows.Forms.TextBox entrega;
        private System.Windows.Forms.TextBox bairro;
        private System.Windows.Forms.TextBox numero;
        private System.Windows.Forms.TextBox endereco;
        private System.Windows.Forms.TextBox telefone;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button recusarPedido;
        private System.Windows.Forms.Button aceitarPedido;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvAceitos;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblAceitos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.DataGridView dgvVendas;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker novasVendas;
    }
}

