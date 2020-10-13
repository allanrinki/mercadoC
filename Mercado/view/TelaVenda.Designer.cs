namespace Mercado
{
    partial class TelaVenda
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
            this.txtProcurar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTotalVenda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInserirProd = new System.Windows.Forms.Button();
            this.txtPrecovenda = new System.Windows.Forms.TextBox();
            this.txtQuantVenda = new System.Windows.Forms.TextBox();
            this.txtProdVenda = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnProd = new System.Windows.Forms.Button();
            this.dgvProd = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbid = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvItensVenda = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFinalizarVenda = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProcurar
            // 
            this.txtProcurar.Location = new System.Drawing.Point(15, 29);
            this.txtProcurar.Multiline = true;
            this.txtProcurar.Name = "txtProcurar";
            this.txtProcurar.Size = new System.Drawing.Size(100, 29);
            this.txtProcurar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Produto";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtTotalVenda);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(373, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 126);
            this.panel1.TabIndex = 4;
            // 
            // txtTotalVenda
            // 
            this.txtTotalVenda.Enabled = false;
            this.txtTotalVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalVenda.Location = new System.Drawing.Point(43, 67);
            this.txtTotalVenda.Multiline = true;
            this.txtTotalVenda.Name = "txtTotalVenda";
            this.txtTotalVenda.Size = new System.Drawing.Size(231, 44);
            this.txtTotalVenda.TabIndex = 1;
            this.txtTotalVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotalVenda.TextChanged += new System.EventHandler(this.txtTotalVenda_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "TOTAL DE VENDAS";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtId);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnInserirProd);
            this.panel2.Controls.Add(this.txtPrecovenda);
            this.panel2.Controls.Add(this.txtQuantVenda);
            this.panel2.Controls.Add(this.txtProdVenda);
            this.panel2.Location = new System.Drawing.Point(373, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 172);
            this.panel2.TabIndex = 5;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(212, 2);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(76, 20);
            this.txtId.TabIndex = 7;
            this.txtId.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(187, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Preço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quantidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Produto";
            // 
            // btnInserirProd
            // 
            this.btnInserirProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirProd.Image = global::Mercado.Properties.Resources.add;
            this.btnInserirProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInserirProd.Location = new System.Drawing.Point(197, 122);
            this.btnInserirProd.Name = "btnInserirProd";
            this.btnInserirProd.Size = new System.Drawing.Size(90, 38);
            this.btnInserirProd.TabIndex = 3;
            this.btnInserirProd.Text = "Inserir";
            this.btnInserirProd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInserirProd.UseVisualStyleBackColor = true;
            this.btnInserirProd.Click += new System.EventHandler(this.btnInserirProd_Click);
            // 
            // txtPrecovenda
            // 
            this.txtPrecovenda.Location = new System.Drawing.Point(187, 86);
            this.txtPrecovenda.Name = "txtPrecovenda";
            this.txtPrecovenda.Size = new System.Drawing.Size(100, 20);
            this.txtPrecovenda.TabIndex = 2;
            // 
            // txtQuantVenda
            // 
            this.txtQuantVenda.Location = new System.Drawing.Point(26, 86);
            this.txtQuantVenda.Name = "txtQuantVenda";
            this.txtQuantVenda.Size = new System.Drawing.Size(100, 20);
            this.txtQuantVenda.TabIndex = 1;
            this.txtQuantVenda.TextChanged += new System.EventHandler(this.txtQuantVenda_TextChanged);
            // 
            // txtProdVenda
            // 
            this.txtProdVenda.Location = new System.Drawing.Point(26, 31);
            this.txtProdVenda.Name = "txtProdVenda";
            this.txtProdVenda.Size = new System.Drawing.Size(261, 20);
            this.txtProdVenda.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.btnProd);
            this.panel3.Controls.Add(this.dgvProd);
            this.panel3.Controls.Add(this.txtProcurar);
            this.panel3.Controls.Add(this.btnPesquisar);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(27, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(340, 304);
            this.panel3.TabIndex = 7;
            // 
            // btnProd
            // 
            this.btnProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProd.Location = new System.Drawing.Point(227, 27);
            this.btnProd.Name = "btnProd";
            this.btnProd.Size = new System.Drawing.Size(92, 31);
            this.btnProd.TabIndex = 4;
            this.btnProd.Text = "Novo Produto";
            this.btnProd.UseVisualStyleBackColor = true;
            this.btnProd.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgvProd
            // 
            this.dgvProd.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProd.Location = new System.Drawing.Point(15, 72);
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.Size = new System.Drawing.Size(304, 84);
            this.dgvProd.TabIndex = 3;
            this.dgvProd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProd_CellContentClick);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.lbid);
            this.panel4.Controls.Add(this.lbData);
            this.panel4.Controls.Add(this.btnFinalizarVenda);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.dgvItensVenda);
            this.panel4.Location = new System.Drawing.Point(27, 334);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(664, 225);
            this.panel4.TabIndex = 8;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Location = new System.Drawing.Point(121, 194);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(16, 13);
            this.lbid.TabIndex = 4;
            this.lbid.Text = "...";
            this.lbid.Visible = false;
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbData.Location = new System.Drawing.Point(21, 184);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(19, 20);
            this.lbData.TabIndex = 3;
            this.lbData.Text = "..";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Itens da Venda";
            // 
            // dgvItensVenda
            // 
            this.dgvItensVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItensVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Produto,
            this.Quantidade,
            this.Preco});
            this.dgvItensVenda.Location = new System.Drawing.Point(15, 33);
            this.dgvItensVenda.Name = "dgvItensVenda";
            this.dgvItensVenda.Size = new System.Drawing.Size(633, 129);
            this.dgvItensVenda.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Produto
            // 
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade Total";
            this.Quantidade.Name = "Quantidade";
            // 
            // Preco
            // 
            this.Preco.HeaderText = "Preço Total";
            this.Preco.Name = "Preco";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Mercado.Properties.Resources.home_77937;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(375, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "Inicio";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFinalizarVenda
            // 
            this.btnFinalizarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarVenda.Image = global::Mercado.Properties.Resources.cart_120706;
            this.btnFinalizarVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinalizarVenda.Location = new System.Drawing.Point(543, 174);
            this.btnFinalizarVenda.Name = "btnFinalizarVenda";
            this.btnFinalizarVenda.Size = new System.Drawing.Size(105, 41);
            this.btnFinalizarVenda.TabIndex = 2;
            this.btnFinalizarVenda.Text = "Finalizar Venda";
            this.btnFinalizarVenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFinalizarVenda.UseVisualStyleBackColor = true;
            this.btnFinalizarVenda.Click += new System.EventHandler(this.btnFinalizarVenda_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mercado.Properties.Resources.cashier2_118071__1_1;
            this.pictureBox1.Location = new System.Drawing.Point(121, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 136);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Image = global::Mercado.Properties.Resources.xmag_search_find_export_locate_5984;
            this.btnPesquisar.Location = new System.Drawing.Point(121, 29);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(32, 29);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // TelaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(712, 571);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TelaVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.TelaVenda_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtProcurar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTotalVenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInserirProd;
        private System.Windows.Forms.TextBox txtPrecovenda;
        private System.Windows.Forms.TextBox txtQuantVenda;
        private System.Windows.Forms.TextBox txtProdVenda;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvProd;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnFinalizarVenda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvItensVenda;
        private System.Windows.Forms.Button btnProd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Label lbid;
        private System.Windows.Forms.Button button1;
    }
}